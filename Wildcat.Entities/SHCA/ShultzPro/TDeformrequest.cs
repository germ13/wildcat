using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDeformrequest
    {
        public Guid SRequestGuid { get; set; }
        public string SJobNum { get; set; }
        public string SOtherNum { get; set; }
        public DateTime DtRequest { get; set; }
        public string SModelStlfilePath { get; set; }
        public string SSimulationType { get; set; }
        public string SProcess { get; set; }
        public string SMachine { get; set; }
        public int? IForgingTemp { get; set; }
        public int? IDieTemp { get; set; }
        public decimal? DblPressSpeed { get; set; }
        public string SMaterial { get; set; }
        public decimal? DblBilletSizeMin { get; set; }
        public decimal? DblBilletSizeMax { get; set; }
        public string SInfoRequest { get; set; }
        public string SInfoRequestOther { get; set; }
        public string SInstruction { get; set; }
        public string SRequestBy { get; set; }
        public DateTime? DtExpected { get; set; }
        public Guid? SDeformlogGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
