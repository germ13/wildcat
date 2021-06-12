using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadOptimizationMaster
    {
        public TForgeLoadOptimizationMaster()
        {
            TForgeLoadOptimizationDetail = new HashSet<TForgeLoadOptimizationDetail>();
        }

        public Guid SDisplayGuid { get; set; }
        public string SJobNum { get; set; }
        public string SPress { get; set; }
        public string SOperation { get; set; }
        public decimal DblLeft { get; set; }
        public decimal DblTop { get; set; }
        public decimal DblRight { get; set; }
        public decimal DblBottom { get; set; }
        public decimal? DblDieRegisterX { get; set; }
        public decimal? DblDieRegisterY { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public string SNote { get; set; }

        public ICollection<TForgeLoadOptimizationDetail> TForgeLoadOptimizationDetail { get; set; }
    }
}
