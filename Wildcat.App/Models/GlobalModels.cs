using System;

namespace Wildcat.App.Models
{
    public abstract class Request
    {
        public string UserID { get; set; }
        public int FileOwnerID { get; set; }
    }

    //TODO why the weird notation? Why cant we refactor this? Takes a minute.
    public abstract class Response
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Exception exception { get; set; }
    }

    public class GlobalModels
    {
    }

    //public class DownloadResponse : Response
    //{
    //    public string ContentType { get; set; }
    //    public string Path { get; set; }
    //}

    //TODO why the weird notation? Why cant we refactor this? Takes a minute.
    public class TreeviewModel
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }
        public bool children { get; set; }
        public treeviewdata data { get; set; }
    }

    //TODO why the weird notation? Why cant we refactor this? Takes a minute.
    public class treeviewdata
    {
        public string id { get; set; }
        public string type { get; set; }
    }
}