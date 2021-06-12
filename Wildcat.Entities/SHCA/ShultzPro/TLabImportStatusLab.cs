using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportStatusLab
    {
        public TLabImportStatusLab()
        {
            TLabImportStatusDetail = new HashSet<TLabImportStatusDetail>();
        }

        public Guid SLabGuid { get; set; }
        public Guid SFacilityGuid { get; set; }
        public string SLabNumber { get; set; }
        public DateTime? DtDue { get; set; }
        public string SCompany { get; set; }
        public string SPonum { get; set; }
        public string SMaterial { get; set; }
        public DateTime? DtEntered { get; set; }
        public string SEnteredBy { get; set; }
        public string SNotes { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportStatusFacility SFacilityGu { get; set; }
        public ICollection<TLabImportStatusDetail> TLabImportStatusDetail { get; set; }
    }
}
