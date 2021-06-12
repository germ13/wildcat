using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabPurchaseOrder
    {
        public TLabPurchaseOrder()
        {
            TLabPurchaseOrderDetail = new HashSet<TLabPurchaseOrderDetail>();
            TLabPurchaseOrderError = new HashSet<TLabPurchaseOrderError>();
            TLabPurchaseOrderHeatTreatmentLotNumber = new HashSet<TLabPurchaseOrderHeatTreatmentLotNumber>();
            TLabPurchaseOrderHistory = new HashSet<TLabPurchaseOrderHistory>();
            TLabPurchaseOrderNote = new HashSet<TLabPurchaseOrderNote>();
            TLabPurchaseOrderQualityClause = new HashSet<TLabPurchaseOrderQualityClause>();
            TLabPurchaseOrderSpec = new HashSet<TLabPurchaseOrderSpec>();
            TLabPurchaseOrderTestItem = new HashSet<TLabPurchaseOrderTestItem>();
        }

        public Guid SPoguid { get; set; }
        public string SFileId { get; set; }
        public string SSuffix { get; set; }
        public string STestNum { get; set; }
        public string SRevNum { get; set; }
        public DateTime? DtRequired { get; set; }
        public DateTime? DtApproved { get; set; }
        public DateTime? DtOrder { get; set; }
        public decimal? CurPototalAmount { get; set; }
        public string SPriceQuotedBy { get; set; }
        public Guid? SExtensionByEmployeeGuid { get; set; }
        public Guid SMetalGuid { get; set; }
        public string SPartNumber { get; set; }
        public string SFinalCustomer { get; set; }
        public string SFinalCustomerPonum { get; set; }
        public string SAccountNum { get; set; }
        public string SSite { get; set; }
        public string SModel { get; set; }
        public string SExportCompliance { get; set; }
        public string SDescription { get; set; }
        public string SHeatTreatmentCondition { get; set; }
        public Guid? SApprovedByEmployeeGuid { get; set; }
        public Guid SFromCompanyGuid { get; set; }
        public Guid SToCompanyGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TCompany SFromCompanyGu { get; set; }
        public TMetal SMetalGu { get; set; }
        public TLabImportCompany SToCompanyGu { get; set; }
        public ICollection<TLabPurchaseOrderDetail> TLabPurchaseOrderDetail { get; set; }
        public ICollection<TLabPurchaseOrderError> TLabPurchaseOrderError { get; set; }
        public ICollection<TLabPurchaseOrderHeatTreatmentLotNumber> TLabPurchaseOrderHeatTreatmentLotNumber { get; set; }
        public ICollection<TLabPurchaseOrderHistory> TLabPurchaseOrderHistory { get; set; }
        public ICollection<TLabPurchaseOrderNote> TLabPurchaseOrderNote { get; set; }
        public ICollection<TLabPurchaseOrderQualityClause> TLabPurchaseOrderQualityClause { get; set; }
        public ICollection<TLabPurchaseOrderSpec> TLabPurchaseOrderSpec { get; set; }
        public ICollection<TLabPurchaseOrderTestItem> TLabPurchaseOrderTestItem { get; set; }
    }
}
