//using Microsoft.Win32.SafeHandles;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Principal;
//using System.Text;

//namespace Wildcat.Utilities
//{
//    public static class MimetypeHelper
//    {
//        private static List<string> knownTypes;

//        private static Dictionary<string, string> mimeTypes;

//        [DllImport("urlmon.dll", CharSet = CharSet.Auto)]
//        private static extern UInt32 FindMimeFromData(
//            UInt32 pBC, [MarshalAs(UnmanagedType.LPStr)]
//        string pwzUrl, [MarshalAs(UnmanagedType.LPArray)]
//        byte[] pBuffer, UInt32 cbSize, [MarshalAs(UnmanagedType.LPStr)]
//        string pwzMimeProposed, UInt32 dwMimeFlags, ref UInt32 ppwzMimeOut, UInt32 dwReserverd
//        );

//        private const int LOGON32_PROVIDER_DEFAULT = 0;

//        //This parameter causes LogonUser to create a primary token.
//        private const int LOGON32_LOGON_INTERACTIVE = 2;

//        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
//        public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
//        int dwLogonType, int dwLogonProvider, out SafeAccessTokenHandle phToken);

//        /// <summary>
//        /// username, password, domain for impersonation
//        /// </summary>
//        /// <param name="fileName"></param>
//        /// <param name="username"></param>
//        /// <param name="password"></param>
//        /// <param name="domain"></param>
//        /// <returns></returns>
//        public static string GetContentType(string fileName, string username, string password, string domain)
//        {
//            if (knownTypes == null || mimeTypes == null)
//                InitializeMimeTypeLists();
//            string contentType = "";
//            string extension = System.IO.Path.GetExtension(fileName).Replace(".", "").ToLower();
//            mimeTypes.TryGetValue(extension, out contentType);
//            if (string.IsNullOrEmpty(contentType) || !knownTypes.Contains(contentType))
//            {
//                string headerType = ScanFileForMimeType(fileName, username, password, domain);
//                if (headerType != "application/octet-stream" || string.IsNullOrEmpty(contentType))
//                    contentType = headerType;
//            }
//            return contentType;
//        }

//        private static string ScanFileForMimeType(string fileName, string username, string password, string domain)
//        {
//            string mime = "";
//            try
//            {
//                // Call LogonUser to obtain a handle to an access token.
//                SafeAccessTokenHandle safeAccessTokenHandle;
//                bool returnValue = LogonUser(username, domain, password,
//                    LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
//                    out safeAccessTokenHandle);

//                if (!returnValue)
//                {
//                    int ret = Marshal.GetLastWin32Error();
//                    Console.WriteLine("LogonUser failed with error code : {0}", ret);
//                }
//                else
//                {
//                    // Note: if you want to run as unimpersonated, pass
//                    // 'SafeAccessTokenHandle.InvalidHandle' instead of variable 'safeAccessTokenHandle'
//                    WindowsIdentity.RunImpersonated(
//                        safeAccessTokenHandle,
//                        // User action
//                        () =>
//                        {
//                            //WindowsIdentity useri = WindowsIdentity.GetCurrent();
//                            //System.Console.WriteLine(useri.Name);
//                            byte[] buffer = new byte[256];
//                            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
//                            {
//                                int readLength = Convert.ToInt32(Math.Min(256, fs.Length));
//                                fs.Read(buffer, 0, readLength);
//                            }

//                            UInt32 mimeType = default(UInt32);
//                            FindMimeFromData(0, null, buffer, 256, null, 0, ref mimeType, 0);
//                            IntPtr mimeTypePtr = new IntPtr(mimeType);
//                            try
//                            {
//                                mime = Marshal.PtrToStringUni(mimeTypePtr);
//                                Marshal.FreeCoTaskMem(mimeTypePtr);
//                            }
//                            catch (Exception e)
//                            {
//                                mime = "application/octet-stream";
//                            }
//                            if (string.IsNullOrEmpty(mime))
//                                mime = "application/octet-stream";
//                        }
//                        );
//                }

//                //using (WindowsLogin wi = new WindowsLogin(username,domain, password))
//                //{
//                //    WindowsIdentity.RunImpersonated(wi.Identity.AccessToken, () =>
//                //    {
//                //        WindowsIdentity useri = WindowsIdentity.GetCurrent();
//                //        System.Console.WriteLine(useri.Name);
//                //        byte[] buffer = new byte[256];
//                //        using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
//                //        {
//                //            int readLength = Convert.ToInt32(Math.Min(256, fs.Length));
//                //            fs.Read(buffer, 0, readLength);
//                //        }

//                // UInt32 mimeType = default(UInt32); FindMimeFromData(0, null, buffer, 256, null, 0,
//                // ref mimeType, 0); IntPtr mimeTypePtr = new IntPtr(mimeType); mime =
//                // Marshal.PtrToStringUni(mimeTypePtr); Marshal.FreeCoTaskMem(mimeTypePtr); if
//                // (string.IsNullOrEmpty(mime)) mime = "application/octet-stream";

//                // });

//                //}
//                return mime;
//            }
//            catch (Exception ex)
//            {
//                return "application/octet-stream";
//            }
//        }

//        private static void InitializeMimeTypeLists()
//        {
//            knownTypes = new string[] {
//                "text/plain",
//                "text/html",
//                "text/xml",
//                "text/richtext",
//                "text/scriptlet",
//                "audio/x-aiff",
//                "audio/basic",
//                "audio/mid",
//                "audio/wav",
//                "image/gif",
//                "image/jpg",
//                "image/jpeg",
//                "image/pjpeg",
//                "image/png",
//                "image/x-png",
//                "image/tiff",
//                "image/tif",
//                "image/bmp",
//                "image/x-xbitmap",
//                "image/x-jg",
//                "image/x-emf",
//                "image/x-wmf",
//                "video/avi",
//                "video/mpeg",
//                "application/octet-stream",
//                "application/postscript",
//                "application/base64",
//                "application/macbinhex40",
//                "application/pdf",
//                "application/xml",
//                "application/atom+xml",
//                "application/rss+xml",
//                "application/x-compressed",
//                "application/x-zip-compressed",
//                "application/x-gzip-compressed",
//                "application/java",
//                "application/x-msdownload"
//            }.ToList();

//            mimeTypes = new Dictionary<string, string>
//        {
//            {"ai", "application/postscript"},
//            {"aif", "audio/x-aiff"},
//            {"aifc", "audio/x-aiff"},
//            {"aiff", "audio/x-aiff"},
//            {"asc", "text/plain"},
//            {"atom", "application/atom+xml"},
//            {"au", "audio/basic"},
//            {"avi", "video/x-msvideo"},
//            {"bcpio", "application/x-bcpio"},
//            {"bin", "application/octet-stream"},
//            {"bmp", "image/bmp"},
//            {"cdf", "application/x-netcdf"},
//            {"cgm", "image/cgm"},
//            {"class", "application/octet-stream"},
//            {"cpio", "application/x-cpio"},
//            {"cpt", "application/mac-compactpro"},
//            {"csh", "application/x-csh"},
//            {"css", "text/css"},
//            {"dcr", "application/x-director"},
//            {"dif", "video/x-dv"},
//            {"dir", "application/x-director"},
//            {"djv", "image/vnd.djvu"},
//            {"djvu", "image/vnd.djvu"},
//            {"dll", "application/octet-stream"},
//            {"dmg", "application/octet-stream"},
//            {"dms", "application/octet-stream"},
//            {"doc", "application/msword"},
//            {"docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
//            {"dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
//            {"docm", "application/vnd.ms-word.document.macroEnabled.12"},
//            {"dotm", "application/vnd.ms-word.template.macroEnabled.12"},
//            {"dtd", "application/xml-dtd"},
//            {"dv", "video/x-dv"},
//            {"dvi", "application/x-dvi"},
//            {"dxr", "application/x-director"},
//            {"eps", "application/postscript"},
//            {"etx", "text/x-setext"},
//            {"exe", "application/octet-stream"},
//            {"ez", "application/andrew-inset"},
//            {"gif", "image/gif"},
//            {"gram", "application/srgs"},
//            {"grxml", "application/srgs+xml"},
//            {"gtar", "application/x-gtar"},
//            {"hdf", "application/x-hdf"},
//            {"hqx", "application/mac-binhex40"},
//            {"htc", "text/x-component"},
//            {"htm", "text/html"},
//            {"html", "text/html"},
//            {"ice", "x-conference/x-cooltalk"},
//            {"ico", "image/x-icon"},
//            {"ics", "text/calendar"},
//            {"ief", "image/ief"},
//            {"ifb", "text/calendar"},
//            {"iges", "model/iges"},
//            {"igs", "model/iges"},
//            {"jnlp", "application/x-java-jnlp-file"},
//            {"jp2", "image/jp2"},
//            {"jpe", "image/jpeg"},
//            {"jpeg", "image/jpeg"},
//            {"jpg", "image/jpeg"},
//            {"js", "application/x-javascript"},
//            {"kar", "audio/midi"},
//            {"latex", "application/x-latex"},
//            {"lha", "application/octet-stream"},
//            {"lzh", "application/octet-stream"},
//            {"m3u", "audio/x-mpegurl"},
//            {"m4a", "audio/mp4a-latm"},
//            {"m4b", "audio/mp4a-latm"},
//            {"m4p", "audio/mp4a-latm"},
//            {"m4u", "video/vnd.mpegurl"},
//            {"m4v", "video/x-m4v"},
//            {"mac", "image/x-macpaint"},
//            {"man", "application/x-troff-man"},
//            {"mathml", "application/mathml+xml"},
//            {"me", "application/x-troff-me"},
//            {"mesh", "model/mesh"},
//            {"mid", "audio/midi"},
//            {"midi", "audio/midi"},
//            {"mif", "application/vnd.mif"},
//            {"mov", "video/quicktime"},
//            {"movie", "video/x-sgi-movie"},
//            {"mp2", "audio/mpeg"},
//            {"mp3", "audio/mpeg"},
//            {"mp4", "video/mp4"},
//            {"mpe", "video/mpeg"},
//            {"mpeg", "video/mpeg"},
//            {"mpg", "video/mpeg"},
//            {"mpga", "audio/mpeg"},
//            {"ms", "application/x-troff-ms"},
//            {"msh", "model/mesh"},
//            {"mxu", "video/vnd.mpegurl"},
//            {"nc", "application/x-netcdf"},
//            {"oda", "application/oda"},
//            {"ogg", "application/ogg"},
//            {"pbm", "image/x-portable-bitmap"},
//            {"pct", "image/pict"},
//            {"pdb", "chemical/x-pdb"},
//            {"pdf", "application/pdf"},
//            {"pgm", "image/x-portable-graymap"},
//            {"pgn", "application/x-chess-pgn"},
//            {"pic", "image/pict"},
//            {"pict", "image/pict"},
//            {"png", "image/png"},
//            {"pnm", "image/x-portable-anymap"},
//            {"pnt", "image/x-macpaint"},
//            {"pntg", "image/x-macpaint"},
//            {"ppm", "image/x-portable-pixmap"},
//            {"ppt", "application/vnd.ms-powerpoint"},
//            {"pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
//            {"potx", "application/vnd.openxmlformats-officedocument.presentationml.template"},
//            {"ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
//            {"ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12"},
//            {"pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
//            {"potm", "application/vnd.ms-powerpoint.template.macroEnabled.12"},
//            {"ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
//            {"ps", "application/postscript"},
//            {"qt", "video/quicktime"},
//            {"qti", "image/x-quicktime"},
//            {"qtif", "image/x-quicktime"},
//            {"ra", "audio/x-pn-realaudio"},
//            {"ram", "audio/x-pn-realaudio"},
//            {"ras", "image/x-cmu-raster"},
//            {"rdf", "application/rdf+xml"},
//            {"rgb", "image/x-rgb"},
//            {"rm", "application/vnd.rn-realmedia"},
//            {"roff", "application/x-troff"},
//            {"rtf", "text/rtf"},
//            {"rtx", "text/richtext"},
//            {"sgm", "text/sgml"},
//            {"sgml", "text/sgml"},
//            {"sh", "application/x-sh"},
//            {"shar", "application/x-shar"},
//            {"silo", "model/mesh"},
//            {"sit", "application/x-stuffit"},
//            {"skd", "application/x-koan"},
//            {"skm", "application/x-koan"},
//            {"skp", "application/x-koan"},
//            {"skt", "application/x-koan"},
//            {"smi", "application/smil"},
//            {"smil", "application/smil"},
//            {"snd", "audio/basic"},
//            {"so", "application/octet-stream"},
//            {"spl", "application/x-futuresplash"},
//            {"src", "application/x-wais-source"},
//            {"sv4cpio", "application/x-sv4cpio"},
//            {"sv4crc", "application/x-sv4crc"},
//            {"svg", "image/svg+xml"},
//            {"swf", "application/x-shockwave-flash"},
//            {"t", "application/x-troff"},
//            {"tar", "application/x-tar"},
//            {"tcl", "application/x-tcl"},
//            {"tex", "application/x-tex"},
//            {"texi", "application/x-texinfo"},
//            {"texinfo", "application/x-texinfo"},
//            {"tif", "image/tiff"},
//            {"tiff", "image/tiff"},
//            {"tr", "application/x-troff"},
//            {"tsv", "text/tab-separated-values"},
//            {"txt", "text/plain"},
//            {"ustar", "application/x-ustar"},
//            {"vcd", "application/x-cdlink"},
//            {"vrml", "model/vrml"},
//            {"vxml", "application/voicexml+xml"},
//            {"wav", "audio/x-wav"},
//            {"wbmp", "image/vnd.wap.wbmp"},
//            {"wbmxl", "application/vnd.wap.wbxml"},
//            {"wml", "text/vnd.wap.wml"},
//            {"wmlc", "application/vnd.wap.wmlc"},
//            {"wmls", "text/vnd.wap.wmlscript"},
//            {"wmlsc", "application/vnd.wap.wmlscriptc"},
//            {"wrl", "model/vrml"},
//            {"xbm", "image/x-xbitmap"},
//            {"xht", "application/xhtml+xml"},
//            {"xhtml", "application/xhtml+xml"},
//            {"xls", "application/vnd.ms-excel"},
//            {"xml", "application/xml"},
//            {"xpm", "image/x-xpixmap"},
//            {"xsl", "application/xml"},
//            {"xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
//            {"xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
//            {"xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12"},
//            {"xltm", "application/vnd.ms-excel.template.macroEnabled.12"},
//            {"xlam", "application/vnd.ms-excel.addin.macroEnabled.12"},
//            {"xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
//            {"xslt", "application/xslt+xml"},
//            {"xul", "application/vnd.mozilla.xul+xml"},
//            {"xwd", "image/x-xwindowdump"},
//            {"xyz", "chemical/x-xyz"},
//            {"zip", "application/zip"}
//            };
//        }
//    }
//}
