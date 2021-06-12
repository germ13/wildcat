using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class WildcatContext : DbContext
    {
        public virtual DbSet<EndUserMapping> EndUserMapping { get; set; }
    }

    public partial class EndUserMapping
    {
        public string Domain { get; set; }
        [Key]
        public int EndUserID { get; set; }
        public string EndUserName { get; set; }
        public string EndUserWithDomain { get; set; }
        public string Email { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string MenuAppName { get; set; }
        public string MenuLocationCode { get; set; }
        public string MenuItemPath { get; set; }
        public string MenuItemName { get; set; }
        public string DatabaseLocationCode { get; set; }
        public string DatabaseAppName { get; set; }
        public string DatabaseTableName { get; set; }
        public string FieldName { get; set; }
        public Nullable<bool> Create { get; set; }
        public Nullable<bool> Read { get; set; }
        public Nullable<bool> Update { get; set; }
        public Nullable<bool> Delete { get; set; }
        public string EndUserLocationCode { get; set; }
        public Nullable<int> MenuItemID { get; set; }
    }
}
