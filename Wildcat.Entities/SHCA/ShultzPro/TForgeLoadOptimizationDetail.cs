using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadOptimizationDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SDisplayGuid { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public int IStepNum { get; set; }
        public decimal DblXcoordinate { get; set; }
        public decimal DblYcoordinate { get; set; }
        public decimal DblZforce { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeLoadOptimizationMaster SDisplayGu { get; set; }
    }
}
