using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStatusFacility
    {
        public TLabImportStatusFacility()
        {
            TLabImportStatusLab = new HashSet<TLabImportStatusLab>();
        }

        public Guid SFacilityGuid { get; set; }
        public Guid SStatusGuid { get; set; }
        public string STitle { get; set; }
        public string SNumber { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportStatus SStatusGu { get; set; }
        public ICollection<TLabImportStatusLab> TLabImportStatusLab { get; set; }
    }
}
