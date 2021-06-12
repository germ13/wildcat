using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSalesSurveyResult
    {
        public Guid SItemGuid { get; set; }
        public int IYear { get; set; }
        public string SKey { get; set; }
        public string SName { get; set; }
        public string SValue { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
