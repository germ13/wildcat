using System;
using System.Collections.Generic;

namespace Wildcat.Logic.Models
{
    #region - API

    public abstract class Request
    {
        public string UserID { get; set; }
        public int FileOwnerID { get; set; }
    }

    public abstract class Response
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Exception exception { get; set; }
    }

    #endregion - API

    #region - Global

    public class ExceptionDTO
    {
        public string Source { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string HResult { get; set; }
        public Dictionary<string, string> Data { get; set; }

    }

    public class EmailerRequest : Request
    {
        public string From { get; set; }
        public List<string> To { get; set; }
        public List<string> CC { get; set; }
        public List<string> Bcc { get; set; }
        public int Priority { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
    }

    public class EmailerResponse : Response
    {

    }

    #endregion - Global

    #region - AppSettings

    public class AppSettings
    {
        public class LogLevel
        {
            public string Default { get; set; }
        }

        public class Logging
        {
            public LogLevel LogLevel { get; set; }
        }

        public class LoupeUser
        {
            public string Domain { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class ConnectionStrings
        {
            public string Loupe { get; set; }
            public string Wildcat { get; set; }
        }

        public class RootObject
        {
            public Logging Logging { get; set; }
            public string AllowedHosts { get; set; }
            public LoupeUser LoupeUser { get; set; }
            public ConnectionStrings ConnectionStrings { get; set; }
        }
    }

    #endregion - AppSettings


    #region - File/Directory

    public class DirectoryInfoDTO
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string ParentId { get; set; }
        public string RootId { get; set; }
        public string Created { get; set; }
        public string LastAccess { get; set; }
        public string LastWrite { get; set; }
        public bool Active { get; set; }
        public bool Exists { get; set; }
    }

    public class FileInfoDTO
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string DirectoryId { get; set; }
        public string Extension { get; set; }
        public string Created { get; set; }
        public string LastAccess { get; set; }
        public string LastWrite { get; set; }
        public bool Active { get; set; }
        public bool Exists { get; set; }
        public byte[] ByteArray { get; set; }
    }

    #endregion - File/Directory



    #region - ViewComponent - TreeviewModel

    public class TreeviewModel
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }
        public bool children { get; set; }
        public treeviewdata data { get; set; }
    }

    public class treeviewdata
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    #endregion - ViewComponent - TreeviewModel
}
