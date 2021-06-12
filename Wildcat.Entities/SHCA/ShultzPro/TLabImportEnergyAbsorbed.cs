using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportEnergyAbsorbed
    {
        public Guid SEaguid { get; set; }
        public Guid SImpactGuid { get; set; }
        public string SRecId { get; set; }
        public decimal? DblMinReqFtLbf { get; set; }
        public decimal? DblMaxReqFtLbf { get; set; }
        public decimal? DblMinReqJ { get; set; }
        public decimal? DblMinReqJcm { get; set; }
        public decimal? DblMinReqDaJcm { get; set; }
        public decimal? DblEnergyAbsorbedFtLbf { get; set; }
        public bool? BConforms { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportImpact SImpactGu { get; set; }
    }
}
