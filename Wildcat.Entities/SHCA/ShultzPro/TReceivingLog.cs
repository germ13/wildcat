using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TReceivingLog
    {
        public Guid SReceivingLogGuid { get; set; }
        public string SPonum { get; set; }
        public DateTime? DtReceived { get; set; }
        public Guid SMetalGuid { get; set; }
        public int? IPiecesReceived { get; set; }
        public string SCarrierName { get; set; }
        public string SReceiverUserGuid { get; set; }
        public string SIdentification { get; set; }
        public int? IWeightInPounds { get; set; }
        public int? ILengthInInches { get; set; }
        public int? IWidthInInches { get; set; }
        public int? IHeightInInches { get; set; }
        public string SType { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
