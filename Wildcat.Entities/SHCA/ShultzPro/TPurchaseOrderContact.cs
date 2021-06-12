using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPurchaseOrderContact
    {
        public TPurchaseOrderContact()
        {
            TPurchaseOrderContactAddress = new HashSet<TPurchaseOrderContactAddress>();
            TPurchaseOrderContactPhone = new HashSet<TPurchaseOrderContactPhone>();
        }

        public Guid SContactGuid { get; set; }
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

        public ICollection<TPurchaseOrderContactAddress> TPurchaseOrderContactAddress { get; set; }
        public ICollection<TPurchaseOrderContactPhone> TPurchaseOrderContactPhone { get; set; }
    }
}
