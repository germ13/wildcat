using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TAccessControlEvent
    {
        public Guid SAcguid { get; set; }
        public string SLastName { get; set; }
        public string SFirstName { get; set; }
        public string SMiddleName { get; set; }
        public string SAccessPanelName { get; set; }
        public string SReader { get; set; }
        public int? IHrdeptId { get; set; }
        public bool BIsVisitor { get; set; }
        public bool BIsGuard { get; set; }
        public string SCardNum { get; set; }
        public int? IEmpId { get; set; }
        public string SBadgeType { get; set; }
        public DateTime? DtBadgeActivated { get; set; }
        public DateTime? DtBadgeDeactivated { get; set; }
        public DateTime? DtLastChanged { get; set; }
        public DateTime? DtEvent { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
