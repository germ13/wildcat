using System;
using System.Collections.Generic;

namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class CertsMill
    {
        public CertsMill()
        {
            HeatReceipts = new HashSet<HeatReceipts>();
        }

        public int Crn { get; set; }
        public DateTime? DateIn { get; set; }
        public int? MillId { get; set; }
        public string MillCn { get; set; }
        public string Heat { get; set; }
        public string HtDesc { get; set; }
        public string Material { get; set; }
        public string Spec { get; set; }
        public string Pwcode { get; set; }
        public string BetaTransus { get; set; }

        public ICollection<HeatReceipts> HeatReceipts { get; set; }
    }
}
