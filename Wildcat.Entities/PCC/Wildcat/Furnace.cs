using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Furnace
    {
        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string FurnaceName { get; set; }
        public string Ipaddress { get; set; }
        public string DbinstanceName { get; set; }
        public string Dbname { get; set; }
        public string DbuserName { get; set; }
        public string DbuserPassword { get; set; }
        public bool IsForHeatTreatment { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public Location LocationCodeNavigation { get; set; }
    }
}
