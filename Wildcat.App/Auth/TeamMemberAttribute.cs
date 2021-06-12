using Microsoft.AspNetCore.Authorization;
using System;

namespace Wildcat.App.Auth
{
    public class TeamAttribute : AuthorizeAttribute
    {
        private const string POLICY_PREFIX = "Team:";

        public TeamAttribute(string team) => Team = team;

        public string Team
        {
            get
            {
                var teamString = Policy.Substring(POLICY_PREFIX.Length);
                if (!String.IsNullOrEmpty(teamString))
                {
                    return teamString;
                }
                return String.Empty;
            }
            set
            {
                Policy = $"{POLICY_PREFIX}{value.ToString()}";
            }
        }
    }
}