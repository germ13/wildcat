using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAppEntryComputerProperty
    {
        public Guid SPropGuid { get; set; }
        public string SComputerName { get; set; }
        public string SIpaddress { get; set; }
        public string SPropName { get; set; }
        public string SValue { get; set; }
        public int IValue { get; set; }
        public bool BValue { get; set; }
        public byte[] ImgValue { get; set; }
        public string SValueText { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
