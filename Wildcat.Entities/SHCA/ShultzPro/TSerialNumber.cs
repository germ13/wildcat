using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSerialNumber
    {
        public long ISerialNumberId { get; set; }
        public string SJobNumberMaster { get; set; }
        public string SJobNumberSequence { get; set; }
        public string SCustomerPartNumber { get; set; }
        public string SJobNumberPreceding { get; set; }
        public bool? BIsWymanGordon { get; set; }
        public string SPartnerSerialNumber { get; set; }
        public string SPrefix { get; set; }
        public string SSerialNumber { get; set; }
        public string SSuffix { get; set; }
        public string SFullSerialNumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
