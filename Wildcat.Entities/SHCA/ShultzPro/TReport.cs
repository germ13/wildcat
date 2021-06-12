using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TReport
    {
        public TReport()
        {
            TReportToGroup = new HashSet<TReportToGroup>();
        }

        public Guid SReportGuid { get; set; }
        public string SModule { get; set; }
        public bool BIsFormLetter { get; set; }
        public string SReportTitle { get; set; }
        public string SViewTitle { get; set; }
        public string SFilterCriteria { get; set; }
        public byte[] SPreview { get; set; }
        public byte[] SStream { get; set; }
        public string SReportAsXml { get; set; }
        public Guid? SCreatorUserGuid { get; set; }
        public string SBackgroundStatus { get; set; }
        public string SElementType { get; set; }
        public string SFormLetterRtf { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TReportToGroup> TReportToGroup { get; set; }
    }
}
