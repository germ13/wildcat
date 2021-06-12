using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawCustomer
    {
        public Guid SRecGuid { get; set; }
        public string SJobNum { get; set; }
        public string SJobNumPrefix { get; set; }
        public string SJobNumDashed { get; set; }
        public string SCustomerName { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
