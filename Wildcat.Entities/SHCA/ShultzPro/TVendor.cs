using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TVendor
    {
        public TVendor()
        {
            TVendorAddress = new HashSet<TVendorAddress>();
            TVendorContact = new HashSet<TVendorContact>();
            TVendorPhone = new HashSet<TVendorPhone>();
        }

        public Guid SVendorGuid { get; set; }
        public string SKey { get; set; }
        public int? IDeptNum { get; set; }
        public string SAccountNumber { get; set; }
        public string SCompanyName { get; set; }
        public string SHrshorthand { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TVendorAddress> TVendorAddress { get; set; }
        public ICollection<TVendorContact> TVendorContact { get; set; }
        public ICollection<TVendorPhone> TVendorPhone { get; set; }
    }
}
