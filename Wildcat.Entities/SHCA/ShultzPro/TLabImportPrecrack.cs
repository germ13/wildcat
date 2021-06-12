using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportPrecrack
    {
        public Guid SPrecrackGuid { get; set; }
        public Guid? SPlaneStrainGuid { get; set; }
        public string SRecId { get; set; }
        public decimal? DblMaxLoad { get; set; }
        public decimal? DblNumCycles { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportPlaneStrain SPlaneStrainGu { get; set; }
    }
}
