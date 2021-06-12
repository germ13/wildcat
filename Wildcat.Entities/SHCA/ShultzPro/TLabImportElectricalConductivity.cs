using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportElectricalConductivity
    {
        public Guid SEcguid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SRemarks { get; set; }
        public decimal? DblMinReqIacs { get; set; }
        public decimal? DblMaxReqIacs { get; set; }
        public decimal? DblMinReqMsm { get; set; }
        public decimal? DblMaxReqMsm { get; set; }
        public decimal? DblElecConductivityIacs { get; set; }
        public decimal? DblElecConductivityMsm { get; set; }
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
