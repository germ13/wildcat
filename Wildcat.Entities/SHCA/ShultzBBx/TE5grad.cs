using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TE5grad
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SClass { get; set; }
        public string SGradeCode { get; set; }
        public string SGradeDescription { get; set; }
        public string SColorDescription { get; set; }
        public string SOpen01 { get; set; }
        public string SOpen02 { get; set; }
        public string SOpen03 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
