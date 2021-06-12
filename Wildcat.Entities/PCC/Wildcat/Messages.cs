using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Messages
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool HasAttachment { get; set; }
        public string Folder { get; set; }
        public bool IsReply { get; set; }
    }
}
