namespace Wildcat.App.Models
{
    //TODO renamespace
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
            //TODO Remove if after 2019-03-01
            //public string WgSecurity { get; set; }
        }

        public class RootObject
        {
            public Logging Logging { get; set; }
            public string AllowedHosts { get; set; }
            public LoupeUser LoupeUser { get; set; }
            public ConnectionStrings ConnectionStrings { get; set; }
        }
    }

}