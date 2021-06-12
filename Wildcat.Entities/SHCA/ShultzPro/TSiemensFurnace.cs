using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSiemensFurnace
    {
        public Guid SSiemensFurnaceGuid { get; set; }
        public string SFurnaceName { get; set; }
        public string SIpaddress { get; set; }
        public string SDbinstanceName { get; set; }
        public string SDatabaseName { get; set; }
        public string SDbuserName { get; set; }
        public string SDbuserPassword { get; set; }
        public bool? BIsForHeatTreat { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
