using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TCustS
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public int? ICustomerNumber { get; set; }
        public int? ICustomerNumber2 { get; set; }
        public string SName { get; set; }
        public string SOpen1 { get; set; }
        public string SOpen2 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
