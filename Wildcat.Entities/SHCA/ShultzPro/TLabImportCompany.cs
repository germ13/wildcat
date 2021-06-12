using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportCompany
    {
        public TLabImportCompany()
        {
            TLabImportContact = new HashSet<TLabImportContact>();
            TLabImportTest = new HashSet<TLabImportTest>();
            TLabPurchaseOrder = new HashSet<TLabPurchaseOrder>();
        }

        public Guid SCompanyGuid { get; set; }
        public string SName { get; set; }
        public string SAddress { get; set; }
        public string SCity { get; set; }
        public string SState { get; set; }
        public string SZip { get; set; }
        public string SPhone { get; set; }
        public string SFax { get; set; }
        public string SWebsite { get; set; }
        public string SRecId { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TLabImportContact> TLabImportContact { get; set; }
        public ICollection<TLabImportTest> TLabImportTest { get; set; }
        public ICollection<TLabPurchaseOrder> TLabPurchaseOrder { get; set; }
    }
}
