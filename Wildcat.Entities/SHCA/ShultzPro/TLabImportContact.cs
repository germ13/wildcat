using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportContact
    {
        public Guid SContactGuid { get; set; }
        public Guid SCompanyGuid { get; set; }
        public string SName { get; set; }
        public string SEmail { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportCompany SCompanyGu { get; set; }
    }
}
