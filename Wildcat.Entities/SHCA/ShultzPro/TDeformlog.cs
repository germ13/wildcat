using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDeformlog
    {
        public TDeformlog()
        {
            TDeformlogStep = new HashSet<TDeformlogStep>();
        }

        public Guid SLogGuid { get; set; }
        public DateTime? DtSimulation { get; set; }
        public string SJobNum { get; set; }
        public string SOtherNum { get; set; }
        public string SOperation { get; set; }
        public int? IFemrunTimeInMinutes { get; set; }
        public int? IRemeshRunTimeInMinutes { get; set; }
        public string SMachine { get; set; }
        public int? ITotalElements { get; set; }
        public string SMaterial { get; set; }
        public int? ITemp { get; set; }
        public decimal? DblPressSpeed { get; set; }
        public decimal? DblDieGap { get; set; }
        public decimal? DblFriction { get; set; }
        public decimal? DblCoeffHeatTransfer { get; set; }
        public int? IPva { get; set; }
        public int? ISurfaceArea { get; set; }
        public int? IWeight { get; set; }
        public int? ITonnage { get; set; }
        public string SRunBy { get; set; }
        public decimal? DblRadiationFactor { get; set; }
        public string SNote { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TDeformlogStep> TDeformlogStep { get; set; }
    }
}
