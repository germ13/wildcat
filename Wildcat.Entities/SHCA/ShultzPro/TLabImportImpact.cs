using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportImpact
    {
        public TLabImportImpact()
        {
            TLabImportEnergyAbsorbed = new HashSet<TLabImportEnergyAbsorbed>();
            TLabImportImpactLateralExpansion = new HashSet<TLabImportImpactLateralExpansion>();
            TLabImportImpactShear = new HashSet<TLabImportImpactShear>();
        }

        public Guid SImpactGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string STestType { get; set; }
        public string SNotchType { get; set; }
        public string SRemarks { get; set; }
        public string STestTemp { get; set; }
        public decimal? DblTestTempF { get; set; }
        public decimal? DblTestTempC { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
        public ICollection<TLabImportEnergyAbsorbed> TLabImportEnergyAbsorbed { get; set; }
        public ICollection<TLabImportImpactLateralExpansion> TLabImportImpactLateralExpansion { get; set; }
        public ICollection<TLabImportImpactShear> TLabImportImpactShear { get; set; }
    }
}
