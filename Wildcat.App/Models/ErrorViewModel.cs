using System;

namespace Wildcat.App.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public int StatusCode { get; set; }
        public string User { get; set; }
        public string Referer { get; set; }
        public object QueryString { get; internal set; }
    }
}
