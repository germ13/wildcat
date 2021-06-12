using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class ReportAttribute
    {
        public int ReportAttributeId { get; set; }
        public string Module { get; set; }
        public bool IsFormLetter { get; set; }
        public string ReportTitle { get; set; }
        public string ViewTitle { get; set; }
        public string FilterCriteria { get; set; }
        public byte[] Preview { get; set; }
        public byte[] Stream { get; set; }
        public string ReportAsXml { get; set; }
        public Guid? CreatorUserGuid { get; set; }
        public string BackgroundStatus { get; set; }
        public string ElementType { get; set; }
        public string FormLetterRtf { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
