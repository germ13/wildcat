using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportBend
    {
        public Guid SBendGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSpecimenDirection { get; set; }
        public decimal? DblSpecimenThickness { get; set; }
        public string SRemarks { get; set; }
        public string SBendFactor { get; set; }
        public decimal? DblBendRadius { get; set; }
        public decimal? DblBendDiameter { get; set; }
        public decimal? DblBendAngle { get; set; }
        public bool? BCracksObserved { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
    }
}
