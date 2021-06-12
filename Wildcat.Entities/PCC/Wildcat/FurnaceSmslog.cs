using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class FurnaceSmslog
    {
        public int Id { get; set; }
        public Guid? MessageGrouping { get; set; }
        public string Sid { get; set; }
        public string FurnaceName { get; set; }
        public string TextBody { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SentDate { get; set; }
        public string Direction { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public string MessagingServiceSid { get; set; }
        public string NumberMedia { get; set; }
        public string NumberOfSegments { get; set; }
        public decimal? Price { get; set; }
        public string PriceUnit { get; set; }
        public string MessageStatus { get; set; }
    }
}
