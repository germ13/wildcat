using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TVendorContact
    {
        public TVendorContact()
        {
            TVendorContactAddress = new HashSet<TVendorContactAddress>();
            TVendorContactPhone = new HashSet<TVendorContactPhone>();
        }

        public Guid SContactGuid { get; set; }
        public Guid SVendorGuid { get; set; }
        public string STitle { get; set; }
        public string SFirstName { get; set; }
        public string SMiddleName { get; set; }
        public string SLastName { get; set; }
        public string SSuffix { get; set; }
        public string SEmail { get; set; }
        public string SPositionTitle { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TVendor SVendorGu { get; set; }
        public ICollection<TVendorContactAddress> TVendorContactAddress { get; set; }
        public ICollection<TVendorContactPhone> TVendorContactPhone { get; set; }
    }
}
