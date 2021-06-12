using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THrapplicantDate
    {
        public Guid SDateGuid { get; set; }
        public Guid SApplicantGuid { get; set; }
        public DateTime DtTransaction { get; set; }
        public string SKey { get; set; }
        public string SDesc { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public THrapplicant SApplicantGu { get; set; }
    }
}
