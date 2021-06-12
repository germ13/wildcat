using System;

namespace Wildcat.Entities.PCC.PCC03Integration
{
    public partial class EmailAddresses
    {
        public string EmailAddress { get; set; }
        public int Direction { get; set; }
        public bool? Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
