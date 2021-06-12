using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TMsspec
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SGradeInKey { get; set; }
        public string SSpecAbbreviation { get; set; }
        public string SOrderNumber { get; set; }
        public string SGrade { get; set; }
        public string SSpecs { get; set; }
        public string SPartNumberOrBarSize { get; set; }
        public string SDateWrittenIntoFile { get; set; }
        public string SMaterialCode { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
