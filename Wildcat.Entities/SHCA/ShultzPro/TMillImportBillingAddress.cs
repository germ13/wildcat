using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportBillingAddress
    {
        public Guid SBillingAddressGuid { get; set; }
        public Guid SCertificationGuid { get; set; }
        public string SName { get; set; }
        public string SAddress { get; set; }
        public string SCity { get; set; }
        public string SState { get; set; }
        public string SZip { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMillImportCertifications SCertificationGu { get; set; }
    }
}
