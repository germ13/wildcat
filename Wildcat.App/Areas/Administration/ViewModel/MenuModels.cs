using System.Collections.Generic;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.ViewModels
{
    //TODO renamespace
    #region - ViewModels

    public class MenuModels
    {
    }

    public class LocationsTreeClickViewModel
    {
        public string MenuId { get; set; }
        public string selectedLocation { get; set; }
        public NavigationMenu navmenu { get; set; }
        public MenuLocations menuLocations { get; set; }
        public List<Location> locations { get; set; }
    }

    public class TeamTreeClickViewModel
    {
        public string MenuId { get; set; }
        public string selectedLocation { get; set; }
        public NavigationMenu navmenu { get; set; }
        public MenuTeams menuteams { get; set; }
        public List<SecurityGroup> securityGroups { get; set; }
    }

    #endregion - ViewModels

    #region - Models

    public class MenuLocations
    {
        public NavigationMenu navigationMenu { get; set; }
        public List<Location> menuLocations { get; set; }
    }

    public class MenuTeams
    {
        public NavigationMenu navigationMenu { get; set; }
        public List<SecurityGroup> menuSecurityGroups { get; set; }
    }

    #endregion - Models
}