using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.Auth
{
    internal class TeamAuthorizationHandler : AuthorizationHandler<TeamRequirement>
    {
        private readonly IServiceScopeFactory scopeFactory;
        private readonly double JwtTTL = 60 * 9; // Cookie time to live in minutes.
        private string JwtCookieName = "Mxyzptlk";
        private bool EnableAdministratorsByPass = false;
        private string Secret = "Robot-minds-of-robot-slaves-Lead-them-to-atomic-graves";

        public TeamAuthorizationHandler(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        // Checks to see if TeamRequirement is met.
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TeamRequirement requirement)
        {
            var teamsToCheckFor = requirement.Team.Split(',');
            IEnumerable<string> intersections;

            // This gets called when a [Team="..."] attribute is met, the else-if handles the html
            // attribute <div asp-authorize asp-policy="Team:Developers,Engineers">...</div>
            if (context.Resource is AuthorizationFilterContext decoratorContext) // make sure we have httpContext.
            {
                var authCookie = decoratorContext.HttpContext.Request.Cookies[JwtCookieName] ?? null;
                var user = decoratorContext.HttpContext.User.Identity.Name;
                var teamMembership = BelongsToTeams(user);

                // Administrator bypass.
                if (EnableAdministratorsByPass && teamMembership.Contains("Administrators"))
                {
                    context.Succeed(requirement);
                    return Task.CompletedTask;
                }

                if (authCookie == null)
                {
                    var jwtToken = GenerateJWT(decoratorContext);
                    PopulateCookie(jwtToken, decoratorContext);
                }
                else
                {
                    var groups = ValidateAndDecode(authCookie, decoratorContext);

                    // a null return value means that jwt did not validate or malformed.
                    if (groups == null)
                    {
                        return Task.CompletedTask;
                    }
                    // jwt_expired
                    else if (groups.Count() == 0)
                    {
                        decoratorContext.Result = new RedirectToActionResult("ExpiredToken", "Home", null);
                        context.Succeed(requirement); // even though it says "Succeed" it didnt.
                        return Task.CompletedTask;
                    }

                    var gclaims = groups.Select(c => c.Value).ToArray();
                    intersections = teamsToCheckFor.Intersect(gclaims);

                    if (intersections.Any())
                    {
                        context.Succeed(requirement);
                        return Task.CompletedTask;
                    }
                    else
                    {
                        decoratorContext.Result = new RedirectToActionResult("RestrictedAccess", "Home", null);
                        context.Succeed(requirement); // even though it says "Succeed" it didnt.
                    }
                }

                intersections = teamsToCheckFor.Intersect(teamMembership);

                if (intersections.Any())
                {
                    context.Succeed(requirement);
                }
                else
                {
                    decoratorContext.Result = new RedirectToActionResult("RestrictedAccess", "Home", null);
                    context.Succeed(requirement); // even though it says "Succeed" it didnt.
                }
            }
            else if (context is AuthorizationHandlerContext tagContext)
            {
                var user = tagContext.User.Identity.Name;
                var teamMembership = BelongsToTeams(user);

                // Administrator bypass.
                if (EnableAdministratorsByPass && teamMembership.Contains("Administrators"))
                {
                    context.Succeed(requirement);
                    return Task.CompletedTask;
                }

                intersections = teamsToCheckFor.Intersect(teamMembership);

                if (intersections.Any())
                {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }

        private string[] BelongsToTeams(string user)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var _dbContext = scope.ServiceProvider.GetRequiredService<WildcatContext>();
                var query = from u in _dbContext.EndUser
                            join e2t in _dbContext.EndUserToSecurityGroup
                                on u.AppLoginName equals e2t.EndUserAppLoginName
                            join t in _dbContext.SecurityGroup
                                on e2t.SecurityName equals t.SecurityName
                            where u.AppLoginName == user
                            select t.SecurityName;

                return query.ToArray();
            }
        }

        private string GenerateJWT(AuthorizationFilterContext context)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, context.HttpContext.User.Identity.Name)
                };

                foreach (var team in BelongsToTeams(context.HttpContext.User.Identity.Name))
                {
                    claims.Add(new Claim(team, team));
                }
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "wildcat",
                    audience: "wildcat",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(JwtTTL), // nine hours
                    signingCredentials: creds);

                var m = new JwtSecurityTokenHandler().WriteToken(token);
                return m;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private IEnumerable<Claim> ValidateAndDecode(string jwt, AuthorizationFilterContext decoratorContext)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));

            var validationParameters = new TokenValidationParameters
            {
                ClockSkew = TimeSpan.FromMinutes(30),
                IssuerSigningKey = key,
                RequireSignedTokens = true,
                RequireExpirationTime = true,
                ValidateLifetime = true,
                ValidateAudience = true,
                ValidAudience = "wildcat",
                ValidateIssuer = true,
                ValidIssuer = "wildcat"
            };

            try
            {
                var claimsPrincipal = new JwtSecurityTokenHandler()
                    .ValidateToken(jwt, validationParameters, out var rawValidatedToken);

                return ((JwtSecurityToken)rawValidatedToken).Claims;
            }
            catch (SecurityTokenValidationException tokenError)
            {
                if (tokenError.Message.Contains("Lifetime validation failed"))
                {
                    var m = GenerateJWT(decoratorContext);
                    PopulateCookie(m, decoratorContext);
                    return new List<Claim>(); //renewed cookie.
                }
                return null; // Error happened and cannot renew cookie;
            }
            catch (ArgumentException argumentError)
            {
                return null; // Did not validate and error happended
            }
        }

        private void PopulateCookie(string jwtToken, AuthorizationFilterContext decoratorContext)
        {
            decoratorContext.HttpContext.Response.Cookies.Append(JwtCookieName, jwtToken);
        }
    }
}