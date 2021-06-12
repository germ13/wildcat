using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportMills
    {
        public TMillImportMills()
        {
            TMillImportCertifications = new HashSet<TMillImportCertifications>();
        }

        public Guid SMillGuid { get; set; }
        public string SMillName { get; set; }
        public string SFileId { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMillImportCertifications> TMillImportCertifications { get; set; }
    }
}
