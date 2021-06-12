using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportProductStatements
    {
        public Guid SProductStatementGuid { get; set; }
        public Guid SProductGuid { get; set; }
        public string SStatementId { get; set; }
        public string SStatementName { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMillImportProducts SProductGu { get; set; }
    }
}
