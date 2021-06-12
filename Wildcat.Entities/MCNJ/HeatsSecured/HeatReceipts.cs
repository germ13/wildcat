using System;

namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class HeatReceipts
    {
        public int? Crn { get; set; }
        public int Hrn { get; set; }
        public DateTime? Date { get; set; }
        public string Size { get; set; }
        public string McWPo { get; set; }
        public short? VendorId { get; set; }
        public int? TotWt { get; set; }
        public short? Billets { get; set; }
        public string BilletId { get; set; }
        public bool Bsr { get; set; }
        public bool CutBillets { get; set; }
        public string Remarks { get; set; }

        public CertsMill CrnNavigation { get; set; }
    }
}
