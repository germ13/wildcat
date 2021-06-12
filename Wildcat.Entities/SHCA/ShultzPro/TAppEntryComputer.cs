using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAppEntryComputer
    {
        public Guid SAppEntryGuid { get; set; }
        public string SComputerName { get; set; }
        public string SIpaddress { get; set; }
        public string SAppToRun { get; set; }
        public bool BLoginRequired { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
