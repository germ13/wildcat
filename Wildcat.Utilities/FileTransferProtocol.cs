
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Wildcat.Utilities
{
    public class FileTransferProtocol
    {
        #region Private Fields

        private string _dllShortName = "ShultzPCCExtract";

        private Stream _stream = null;
        private FtpWebRequest _request = null;
        private FtpWebResponse _response = null;
        private readonly int _bufferSize = 4096;

        #endregion

        #region Constructors

        public FileTransferProtocol()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// ASCII only version of method below
        /// </summary>
        /// <param name="server"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="remoteDirectory"></param>
        /// <param name="localFilePaths"></param>
        /// <returns></returns>
        public void Put(string server, string username, string password, string remoteDirectory, List<string> localFilePaths)
        {
            Put(server, username, password, remoteDirectory, localFilePaths, false);
        }

        /// <summary>
        /// Uploads file
        /// </summary>
        /// <param name="server">Server</param>
        /// <param name="username">User name</param>
        /// <param name="password">Password</param>
        /// <param name="remoteDirectory">Directory on FTP server relative to access point</param>
        /// <param name="localFilePaths">Full paths of local files to upload</param>
        /// <param name="useBinary">Option to use ASCII or binary</param>
        /// <returns></returns>
        public void Put(string server, string username, string password, string remoteDirectory, List<string> localFilePaths, bool useBinary)
        {
            FormatServer(ref server);

            Uri baseUri = new Uri(server);

            foreach (string localfilePath in localFilePaths)
            {
                _request = (FtpWebRequest)FtpWebRequest.Create(new Uri(baseUri, Path.Combine(remoteDirectory, GetFileNameOnly(localfilePath))));
                _request.Credentials = new NetworkCredential(username, password);
                _request.UseBinary = useBinary;
                _request.UsePassive = true;
                _request.KeepAlive = true;
                _request.Method = WebRequestMethods.Ftp.UploadFile;

                try
                {
                    _stream = _request.GetRequestStream();
                    FileStream fs = new FileStream(localfilePath, FileMode.Open);

                    byte[] buffer = new byte[_bufferSize];
                    int bytesSent = fs.Read(buffer, 0, _bufferSize);

                    while (bytesSent != 0)
                    {
                        _stream.Write(buffer, 0, bytesSent);
                        bytesSent = fs.Read(buffer, 0, _bufferSize);
                    }

                    fs.Close();
                }
                catch (WebException e)
                {
                    //Logging.LogError(_dllShortName, "Web error while attempting to process " + localfilePath + ": " + e.Message);
                }
                catch (Exception ex)
                {
                    //Logging.LogError(_dllShortName, "Error while attempting to process " + localfilePath + ": " + ex.Message);
                }
                finally
                {
                    _stream.Close();
                    _request = null;
                }
            }
        }

        /// <summary>
        /// ASCII onlty version of method below
        /// </summary>
        /// <param name="server">Server name</param>
        /// <param name="username">User Name</param>
        /// <param name="password"> Password</param>
        /// <param name="localDirectory">Local Directory to place file in</param>
        /// <param name="remoteFilePaths">Relative path within FTP access point; if directory only, it must end with slash</param>
        /// <param name="fileNameRegex">Only used if paths are supplied (instead of specific files)</param>
        /// <returns></returns>
        public void Get(string server, string username, string password, string localDirectory, List<string> remoteFilePaths, string fileNameRegex)
        {
            Get(server, username, password, localDirectory, remoteFilePaths, false, fileNameRegex);
        }

        //Facilitate single file requests
        public void Get(string server, string username, string password, string localDirectory, string remoteFilePath)
        {
            List<string> remoteFilePaths = new List<string>();
            remoteFilePaths.Add(remoteFilePath);

            Get(server, username, password, localDirectory, remoteFilePaths, false, ".*");
        }

        /// <summary>
        /// Downloads file or files
        /// </summary>
        /// <param name="server">Server name</param>
        /// <param name="username">User Name</param>
        /// <param name="password"> Password</param>
        /// <param name="localDirectory">Local Directory to place file in</param>
        /// <param name="remoteFilePaths">relative path within FTP access point; if directory only, it must end with slash</param>
        /// <param name="useBinary">Option to use Binary or ASCII</param>
        /// <returns></returns>
        public void Get(string server, string username, string password, string localDirectory, List<string> remoteFilePaths, bool useBinary, string fileNameRegex)
        {
            FormatServer(ref server);

            Uri baseUri = new Uri(server);

            string[] tempFilePaths = new string[remoteFilePaths.Count];
            remoteFilePaths.CopyTo(tempFilePaths);

            Regex regex = new Regex(fileNameRegex);

            foreach (string tempFilePath in tempFilePaths)
            {
                try
                {
                    //It's not a local file system so we cannot inspect file attribute.  Also, we can't
                    // always count on a period to be part of the full file name.  As such, we required
                    // a slash
                    if (tempFilePath.EndsWith(@"\") || tempFilePath.EndsWith(@"/"))
                    {
                        //We've found this to be a folder, not a file, so take it out of the file list
                        remoteFilePaths.Remove(tempFilePath);

                        _request = (FtpWebRequest)FtpWebRequest.Create(new Uri(baseUri, tempFilePath));
                        _request.Credentials = new NetworkCredential(username, password);
                        _request.UseBinary = useBinary;
                        _request.UsePassive = true;
                        _request.KeepAlive = true;
                        _request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                        _response = (FtpWebResponse)_request.GetResponse();
                        _stream = _response.GetResponseStream();
                        StreamReader sr = new StreamReader(_stream);

                        string fileNameStartPosition = string.Empty;

                        while ((fileNameStartPosition = sr.ReadLine()) != null)
                        {
                            int colon = fileNameStartPosition.LastIndexOf(':');
                            string fileName = string.Empty;

                            if (colon > -1)
                            {
                                colon += 4;
                                fileName = fileNameStartPosition.Substring(colon).Trim();
                            }
                            else
                            {
                                fileName = fileNameStartPosition;
                            }

                            Match match = regex.Match(fileName);

                            if (match.Success)
                                remoteFilePaths.Add(Path.Combine(tempFilePath, fileName));
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Logging.LogError(_dllShortName, "Error while attempting to process " + tempFilePath + ": " + ex.Message);
                }
            }

            foreach (string remoteFilePath in remoteFilePaths)
            {
                Match match = regex.Match(remoteFilePath);

                if (!match.Success)
                    continue;

                _request = (FtpWebRequest)FtpWebRequest.Create(new Uri(baseUri, remoteFilePath));
                _request.Credentials = new NetworkCredential(username, password);
                _request.UseBinary = useBinary;
                _request.UsePassive = true;
                _request.KeepAlive = true;
                _request.Method = WebRequestMethods.Ftp.DownloadFile;

                string fullLocalPath = string.Empty;

                try
                {
                    _response = (FtpWebResponse)_request.GetResponse();
                    _stream = _response.GetResponseStream();

                    fullLocalPath = PredictNewFilePath(localDirectory, remoteFilePath);

                    FileStream fs = new FileStream(fullLocalPath, FileMode.Create);

                    byte[] buffer = new byte[_bufferSize];

                    int bytesRead = _stream.Read(buffer, 0, _bufferSize);

                    while (bytesRead > 0)
                    {
                        fs.Write(buffer, 0, bytesRead);
                        bytesRead = _stream.Read(buffer, 0, _bufferSize);
                    }

                    fs.Close();
                }
                catch (Exception ex)
                {
                    //Logging.LogError(_dllShortName, "Error while attempting to process " + fullLocalPath + ": " + ex.Message);
                }
                finally
                {
                    _stream.Close();
                    _response.Close();
                    _request = null;
                }
            }

            //return _errors;
        }

        /// <summary>
        /// Moves remote files to archive folder you choose
        /// </summary>
        /// <param name="server"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="sourcePaths">Sorry, directory-only parameter, with regex not yet supported</param>
        /// <param name="destinationFolder"></param>
        /// <returns></returns>
        public void Archive(string server, string username, string password, List<string> sourcePaths, string destinationFolder)
        {
            FormatServer(ref server);

            Uri baseUri = new Uri(server);

            string[] tempFilePaths = new string[sourcePaths.Count];
            sourcePaths.CopyTo(tempFilePaths);

            foreach (string tempFilePath in tempFilePaths)
            {

                try
                {
                    //It's not a local file system so we cannot inspect file attribute.  Also, we can't
                    // always count on a period to be part of the full file name.  As such, we required
                    // a slash
                    if (tempFilePath.EndsWith(@"\") || tempFilePath.EndsWith(@"/"))
                    {
                        //We've found this to be a folder, not a file, so take it out of the file list
                        sourcePaths.Remove(tempFilePath);

                        _request = (FtpWebRequest)FtpWebRequest.Create(new Uri(baseUri, tempFilePath));
                        _request.Credentials = new NetworkCredential(username, password);
                        _request.UseBinary = false;
                        _request.UsePassive = true;
                        _request.KeepAlive = true;
                        _request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                        _response = (FtpWebResponse)_request.GetResponse();
                        _stream = _response.GetResponseStream();
                        StreamReader sr = new StreamReader(_stream);

                        string fileNameStartPosition = string.Empty;

                        while ((fileNameStartPosition = sr.ReadLine()) != null)
                        {
                            int colon = fileNameStartPosition.LastIndexOf(':');
                            string fileName = string.Empty;

                            if (colon > -1)
                            {
                                colon += 4;
                                fileName = fileNameStartPosition.Substring(colon).Trim();
                            }
                            else
                            {
                                fileName = fileNameStartPosition;
                            }

                            sourcePaths.Add(Path.Combine(tempFilePath, fileName));
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Logging.LogError(_dllShortName, "Error while attempting to process " + tempFilePath + ": " + ex.Message);
                }
            }

            foreach (string sourcePath in sourcePaths)
            {
                Uri sourceUri = new Uri(baseUri, sourcePath);

                string fileNameOnly = sourcePath.Replace(@"\", @"/");
                int lastSlash = fileNameOnly.LastIndexOf(@"/");

                if (lastSlash > -1)
                    fileNameOnly = fileNameOnly.Substring(lastSlash + 1);

                Uri destinationUri = new Uri(baseUri, Path.Combine(destinationFolder, fileNameOnly));

                _request = (FtpWebRequest)FtpWebRequest.Create(sourceUri);
                _request.Credentials = new NetworkCredential(username, password);
                _request.UseBinary = false;
                _request.UsePassive = true;
                _request.KeepAlive = true;
                _request.Method = WebRequestMethods.Ftp.Rename;
                //Windows
                //_request.RenameTo = "../" + Path.Combine(destinationFolder, fileNameOnly).Replace(@"\", @"/");
                //Linux
                _request.RenameTo = "./../" + Path.Combine(destinationFolder, fileNameOnly).Replace(@"\", @"/");

                string result = string.Empty;

                try
                {
                    _response = (FtpWebResponse)_request.GetResponse();
                    result = _response.StatusDescription;
                }
                catch (Exception ex)
                {
                    //Logging.LogError(_dllShortName, "Error while attempting to process " + sourcePath + ": " + ex.Message);
                }
                finally
                {
                    _stream.Close();
                    _response.Close();
                    _request = null;
                }

            }
        }

        public string[] ListDirectoryContents(string server, string username, string password, string remoteDirectory, bool directoryDetails = false)
        {
            string names = string.Empty;

            try
            {

                FormatServer(ref server);
                Uri baseUri = new Uri(server);

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(baseUri, remoteDirectory));

                request.Method = directoryDetails ? WebRequestMethods.Ftp.ListDirectoryDetails : WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(username, password);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                names = reader.ReadToEnd();

                reader.Close();
                response.Close();

            }
            catch (Exception ex)
            {
                //Logging.LogError(_dllShortName, "Error while attempting to process " + remoteDirectory + ": " + ex.Message);
            }

            return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public DateTime GetDateTimestampOnServer(string server, string username, string password, string file)
        {
            FtpWebResponse response = null;

            try
            {
                FormatServer(ref server);
                Uri baseUri = new Uri(server);

                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(baseUri, file));
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                response = (FtpWebResponse)request.GetResponse();

            }
            catch (Exception ex)
            {
                //Logging.LogError(_dllShortName, ex.Message);
            }

            // The output from this method will vary depending on the 
            // file specified and your regional settings. It is similar to:
            // ftp://contoso.com/Data.txt 4/15/2003 10:46:02 AM
            return response.LastModified;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Predicts what a transferred file name will be 
        /// </summary>
        /// <param name="newDirectory">Directory its going to</param>
        /// <param name="originalFullPath">Original path, which provides file name</param>
        /// <returns></returns>
        private string PredictNewFilePath(string newDirectory, string originalFullPath)
        {
            string rtv = string.Empty;
            FileInfo fi = new FileInfo(originalFullPath);
            rtv = Path.Combine(newDirectory, fi.Name);

            return rtv;
        }

        /// <summary>
        /// Takes full path and returns only file name
        /// </summary>
        /// <param name="originalFullPath"></param>
        /// <returns></returns>
        private string GetFileNameOnly(string originalFullPath)
        {
            FileInfo fi = new FileInfo(originalFullPath);
            return fi.Name;
        }

        /// <summary>
        /// Adds formatting to server name, if needed
        /// </summary>
        /// <param name="server">User provided server...ip or name; note by ref</param>
        private void FormatServer(ref string server)
        {
            if (!server.ToLower().StartsWith("ftp"))
                server = string.Format(@"ftp://{0}", server);

            //Path.Combine probably makes this superfluous
            if (!server.EndsWith(@"/"))
                server += @"/";
        }

        #endregion  
    }
}
