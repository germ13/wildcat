using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportPlaneStrainInvalidity
    {
        public Guid SInvalidityGuid { get; set; }
        public Guid SPlaneStrainGuid { get; set; }
        public string SRecId { get; set; }
        public string SInvalidity { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportPlaneStrain SPlaneStrainGu { get; set; }
    }
}
