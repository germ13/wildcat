using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCompany
    {
        public TCompany()
        {
            TLabPurchaseOrder = new HashSet<TLabPurchaseOrder>();
        }

        public Guid SCompanyGuid { get; set; }
        public string SName { get; set; }
        public string SAddress { get; set; }
        public string SCity { get; set; }
        public string SState { get; set; }
        public string SZipCode { get; set; }
        public bool BOnsiteOv { get; set; }
        public bool BHragency { get; set; }
        public string SHrshorthand { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TLabPurchaseOrder> TLabPurchaseOrder { get; set; }
    }
}
