using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPurchaseOrder
    {
        public TPurchaseOrder()
        {
            TPurchaseOrderAccount = new HashSet<TPurchaseOrderAccount>();
            TPurchaseOrderDetail = new HashSet<TPurchaseOrderDetail>();
        }

        public Guid SPoguid { get; set; }
        public string SPonum { get; set; }
        public string SStatus { get; set; }
        public DateTime DtPocreated { get; set; }
        public DateTime? DtOrderPlaced { get; set; }
        public DateTime? DtApproved { get; set; }
        public DateTime? DtExpected { get; set; }
        public string STrackingNumber { get; set; }
        public string SRefQuote { get; set; }
        public string SMachineName { get; set; }
        public string SChargeTo { get; set; }
        public string STerms { get; set; }
        public string SFob { get; set; }
        public string SShipVia { get; set; }
        public bool BResaleTaxable { get; set; }
        public bool? BDeliveryRequired { get; set; }
        public Guid? SShipToContactGuid { get; set; }
        public Guid? SShipToAddressGuid { get; set; }
        public Guid? SShipToPhoneGuid { get; set; }
        public Guid? SShipToFaxGuid { get; set; }
        public Guid? SBillToContactGuid { get; set; }
        public Guid? SBillToAddressGuid { get; set; }
        public Guid? SBillToPhoneGuid { get; set; }
        public Guid? SBillToFaxGuid { get; set; }
        public Guid? SVendorGuid { get; set; }
        public Guid? SVendorContactGuid { get; set; }
        public Guid? SVendorAddressGuid { get; set; }
        public Guid? SVendorPhoneGuid { get; set; }
        public Guid? SVendorFaxGuid { get; set; }
        public decimal? CurShipping { get; set; }
        public bool BShippingTaxable { get; set; }
        public string SToBeUsedFor { get; set; }
        public string SReason { get; set; }
        public string SSignedForDeptText { get; set; }
        public DateTime? DtSigned { get; set; }
        public string SOriginalFileName { get; set; }
        public string SImportKey { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TPurchaseOrderAccount> TPurchaseOrderAccount { get; set; }
        public ICollection<TPurchaseOrderDetail> TPurchaseOrderDetail { get; set; }
    }
}
