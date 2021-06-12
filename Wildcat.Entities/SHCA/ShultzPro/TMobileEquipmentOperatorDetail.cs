using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMobileEquipmentOperatorDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SOperatorGuid { get; set; }
        public string SCategory { get; set; }
        public bool BApproved { get; set; }
        public DateTime? DtCert { get; set; }
        public DateTime? DtExpires { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
