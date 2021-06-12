using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TIpaddress
    {
        public Guid SIpguid { get; set; }
        public string SIpaddress { get; set; }
        public string SWorkstationName { get; set; }
        public string SWorkstationDesc { get; set; }
        public string SBuilding { get; set; }
        public string SMachineType { get; set; }
        public int? IOctetPosition1 { get; set; }
        public int? IOctetPosition2 { get; set; }
        public int? IOctetPosition3 { get; set; }
        public int? IOctetPosition4 { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
