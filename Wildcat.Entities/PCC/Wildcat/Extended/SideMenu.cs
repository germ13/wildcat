using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class WildcatContext : DbContext
    {
        public virtual DbSet<SideMenu> SideMenu { get; set; }
    }

    public partial class SideMenu
    {
        [Key] public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string AppName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Link { get; set; }
        public string DisplayName { get; set; }
        public string IconCss { get; set; }
        public string CssClass { get; set; }
        public double SortOrder { get; set; }
        public bool Active { get; set; }

    }
}

