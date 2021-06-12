using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStatus
    {
        public TLabImportStatus()
        {
            TLabImportStatusFacility = new HashSet<TLabImportStatusFacility>();
        }

        public Guid SStatusGuid { get; set; }
        public Guid SCompanyGuid { get; set; }
        public DateTime DtGenerated { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TLabImportStatusFacility> TLabImportStatusFacility { get; set; }
    }
}
