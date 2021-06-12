using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportCertifications
    {
        public TMillImportCertifications()
        {
            TMillImportBillingAddress = new HashSet<TMillImportBillingAddress>();
            TMillImportComplianceStatements = new HashSet<TMillImportComplianceStatements>();
            TMillImportProducts = new HashSet<TMillImportProducts>();
            TMillImportShippingAddress = new HashSet<TMillImportShippingAddress>();
            TMillImportSpecifications = new HashSet<TMillImportSpecifications>();
        }

        public Guid SCertificationGuid { get; set; }
        public Guid SMillGuid { get; set; }
        public string SCertificationId { get; set; }
        public DateTime DtCertification { get; set; }
        public string SFinish { get; set; }
        public string SCustomerPonum { get; set; }
        public string SGrade { get; set; }
        public string SDeliveryCondition { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMillImportMills SMillGu { get; set; }
        public ICollection<TMillImportBillingAddress> TMillImportBillingAddress { get; set; }
        public ICollection<TMillImportComplianceStatements> TMillImportComplianceStatements { get; set; }
        public ICollection<TMillImportProducts> TMillImportProducts { get; set; }
        public ICollection<TMillImportShippingAddress> TMillImportShippingAddress { get; set; }
        public ICollection<TMillImportSpecifications> TMillImportSpecifications { get; set; }
    }
}
