using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class CustomerContact
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Definition { get; set; }
        public string Value { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public Customer Customer { get; set; }
    }
}
