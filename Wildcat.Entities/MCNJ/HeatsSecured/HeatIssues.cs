using System;

namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class HeatIssues
    {
        public int Crn { get; set; }
        public int? Hrn { get; set; }
        public DateTime? Date { get; set; }
        public string Die { get; set; }
        public string WorkOrder { get; set; }
        public string Billet { get; set; }
        public short? Pieces { get; set; }
        public string Range { get; set; }
        public string HtCode { get; set; }
        public bool? BilletOut { get; set; }
    }
}
