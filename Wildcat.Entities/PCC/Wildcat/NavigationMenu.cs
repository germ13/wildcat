using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class NavigationMenu
    {
        public NavigationMenu()
        {
            InverseParent = new HashSet<NavigationMenu>();
            NavigationMenuToLocation = new HashSet<NavigationMenuToLocation>();
            NavigationMenuToSecurityGroup = new HashSet<NavigationMenuToSecurityGroup>();
        }

        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string AppName { get; set; }
        public string DisplayName { get; set; }
        public string ToolTip { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Link { get; set; }
        public string IconCss { get; set; }
        public string CssClass { get; set; }
        public double? SortOrder { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public NavigationMenu Parent { get; set; }
        public ICollection<NavigationMenu> InverseParent { get; set; }
        public ICollection<NavigationMenuToLocation> NavigationMenuToLocation { get; set; }
        public ICollection<NavigationMenuToSecurityGroup> NavigationMenuToSecurityGroup { get; set; }
    }
}
