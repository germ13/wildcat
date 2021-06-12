using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMillImportProducts
    {
        public TMillImportProducts()
        {
            TMillImportProductChemistryTests = new HashSet<TMillImportProductChemistryTests>();
            TMillImportProductStatements = new HashSet<TMillImportProductStatements>();
        }

        public Guid SProductGuid { get; set; }
        public Guid SCertificationGuid { get; set; }
        public string SProductId { get; set; }
        public string SProductType { get; set; }
        public string SMillHeatNumber { get; set; }
        public string SSalesOrderNum { get; set; }
        public int? SSalesOrderItem { get; set; }
        public string SLotId { get; set; }
        public string SMeltMethod { get; set; }
        public DateTime? DtMeltDate { get; set; }
        public string SMeltLocation { get; set; }
        public string SMeltCountry { get; set; }
        public string SProductDescription { get; set; }
        public string SSize { get; set; }
        public decimal? DblLengthInches { get; set; }
        public decimal? DblWeightPounds { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMillImportCertifications SCertificationGu { get; set; }
        public ICollection<TMillImportProductChemistryTests> TMillImportProductChemistryTests { get; set; }
        public ICollection<TMillImportProductStatements> TMillImportProductStatements { get; set; }
    }
}
