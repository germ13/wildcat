using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Wildcat.App.Auth
{
    public class TeamPolicyProvider : IAuthorizationPolicyProvider
    {
        private const string POLICY_PREFIX = "Team:";
        public DefaultAuthorizationPolicyProvider FallbackPolicyProvider { get; }

        public TeamPolicyProvider(IOptions<AuthorizationOptions> options)
        {
            FallbackPolicyProvider = new DefaultAuthorizationPolicyProvider(options);
        }

        public Task<AuthorizationPolicy> GetDefaultPolicyAsync() => FallbackPolicyProvider.GetDefaultPolicyAsync();

        public Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            if (policyName.StartsWith(POLICY_PREFIX, StringComparison.OrdinalIgnoreCase) &&
                policyName.Substring(POLICY_PREFIX.Length).Length > 0)
            {
                var team = policyName.Substring(POLICY_PREFIX.Length);
                var policy = new AuthorizationPolicyBuilder();
                policy.AddRequirements(new TeamRequirement(team));
                return Task.FromResult(policy.Build());
            }

            return FallbackPolicyProvider.GetPolicyAsync(policyName);
        }

        public Task<AuthorizationPolicy> GetFallbackPolicyAsync()
        {
            throw new NotImplementedException();
        }
    }
}