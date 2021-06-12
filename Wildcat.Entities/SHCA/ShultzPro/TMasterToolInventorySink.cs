using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMasterToolInventorySink
    {
        public Guid SSinkGuid { get; set; }
        public Guid SPartGuid { get; set; }
        public int ISinkNum { get; set; }
        public DateTime? DtOrdered { get; set; }
        public DateTime? DtReceived { get; set; }
        public int? IInspectAtQty { get; set; }
        public DateTime? DtLastInspection { get; set; }
        public string SInspectionType { get; set; }
        public int? ITotalStrikesPerSink { get; set; }
        public int? ITotalPcsPerSink { get; set; }
        public decimal? DblSinkUtilizationStrikes { get; set; }
        public decimal? DblSinkUtilizationPieces { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMasterToolInventory SPartGu { get; set; }
    }
}
