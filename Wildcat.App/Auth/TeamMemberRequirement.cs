using Microsoft.AspNetCore.Authorization;

namespace Wildcat.App.Auth
{
    public class TeamRequirement : IAuthorizationRequirement
    {
        public string Team { get; private set; }

        public TeamRequirement(string team)
        {
            Team = team;
        }
    }
}