using System;

namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class CertsMcW
    {
        public int? Crn { get; set; }
        public int McWCn { get; set; }
        public DateTime? Date { get; set; }
        public int? CustId { get; set; }
        public string CustPo { get; set; }
        public string Heat { get; set; }
        public string GsMcW { get; set; }
        public string Hardness { get; set; }
        public string HeatTreatNotes { get; set; }
        public string CertificationNotes { get; set; }
        public string ProcessNo { get; set; }
        public string NoteType { get; set; }
        public int? QtyShipped { get; set; }
        public string Die { get; set; }
        public string WorkOrder { get; set; }
    }
}
