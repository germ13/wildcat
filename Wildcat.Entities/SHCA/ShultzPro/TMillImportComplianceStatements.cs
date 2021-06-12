using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportComplianceStatements
    {
        public Guid SComplianceStatementGuid { get; set; }
        public Guid SCertificationGuid { get; set; }
        public string SStatementId { get; set; }
        public string SStatementName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMillImportCertifications SCertificationGu { get; set; }
    }
}
