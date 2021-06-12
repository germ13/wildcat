using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportMagneticParticle
    {
        public Guid SParticleGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SInspectedAt { get; set; }
        public string SRemarks { get; set; }
        public string SReferenceSpec { get; set; }
        public string SObservation { get; set; }
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
