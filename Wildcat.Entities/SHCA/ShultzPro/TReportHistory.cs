using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TReportHistory
    {
        public Guid SReportHistoryGuid { get; set; }
        public bool BIsFormLetter { get; set; }
        public string SReportTitle { get; set; }
        public string SViewTitle { get; set; }
        public string SFilterCriteria { get; set; }
        public byte[] SStream { get; set; }
        public string SBackgroundStatus { get; set; }
        public string SElementType { get; set; }
        public string SFormLetterRtf { get; set; }
        public DateTime DtRun { get; set; }
        public Guid? SEntityGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
