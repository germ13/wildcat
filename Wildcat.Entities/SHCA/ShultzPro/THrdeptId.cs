using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THrdeptId
    {
        public int IId { get; set; }
        public string SFirstName { get; set; }
        public string SLastName { get; set; }
        public string SDeptId { get; set; }
        public int IRandNum { get; set; }
        public int? IProxId { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
