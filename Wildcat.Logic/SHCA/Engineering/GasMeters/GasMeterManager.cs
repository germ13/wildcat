
using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.Logic.SHCA.Engineering.GasMeters
{
    public sealed class GasMeterManager
    {
        /*
         ************************* READ THIS *************************************************************
        I don't know exactly what the maximum number of logs the meter stores in its memory.
        I have calculated it to be for one year, 12 months. It works for up to three logs. 
        I have to wait for another few months to see if the code generates any error or fails
        to read all the data. 
        This value can be change with MONTHLY_LOG_LAST_ADDRESS. 
         *************************************************************************************************
        */

        private byte[] _startAddress = null;
        private int? _endAddress = null;

        private bool _breakpoint = false;

        private bool _currentRequestExported = false;

        const int PORT_NUMBER = 10001;
        // Each meter can hold about 3000 15 minute interval logs. Since we will update the 
        // for every ten read, we will make the size of the progress bar for each meter 
        // to be 300, and for the overall progress bar to 300 x the number of meters.
        //const int METER_PROGRESS_BAR_COUNTER = 300;
        //const int OVERALL_PROGRESS_COUNTER = 300;
        // The int daily log start address is 236456. To this we add 68 (length of one log) x 365 (days, maximum 
        // number of logs that the meter will hold for the daily logs, 24820) 
        const int DAILY_LOG_LAST_ADDRESS = 261276;
        // The monthly log is the same as the daily log with the exception that its start address is 156,252,3,0 
        // which is 261276. To this we add 68*12 to get the last address.
        const int MONTHLY_LOG_LAST_ADDRESS = 262024;
        // Each logged data is 68 bytes long. however, when reading it, the returned
        // byte array includes 8 bytes of the command echo and 2 CRC bytes. Hence, the next two variables.
        //const int LOGGED_DATA_ARRAY_LENGHT = 68;
        //const int LOGS_INFO_ARRAY_LENGTH_WITHOUT_ECHOandCRC = 74;
        //const int LOGS_INFO_ARRAY_LENGTH = 84; // The return is 74 plus echo=8 and crc=2.
        // This used for pressure conversion purpose.
        const decimal PRESSURE_CONVERSION_FACTOR = 14.5037738M;
        //byte[] INTERVAL_COMMAND_START_ADDRESS = new byte[] { 240, 18, 0, 0 };
        // The start address of daily log reading.
        byte[] DAILY_COMMAND_START_ADDRESS = new byte[] { 168, 155, 3, 0 };
        // The start address of monthly log reading.
        byte[] MONTHLY_COMMAND_START_ADDRESS = new byte[] { 156, 252, 3, 0 };
        DateTime DATE_TIME_2000 = new DateTime(2000, 1, 1, 0, 0, 0);
        DateTime LOGING_START_DATE = new DateTime(2014, 5, 1);   //"2000-01-02 00:00:00.000");
        //string CHANGE_SERIAL_TO_IP_BAUDRATE_TO_1200 = "0211200";
        //string CHANGE_SERIAL_TO_IP_BAUDRATE_TO_9600 = "0219600";
        //byte[] METER_BAUDRATE_CHANGE_COMMAND_1200 = new byte[] { 0, 0, 0, 0, 66, 0, 0, 1, 0 };
        //byte[] METER_BAUDRATE_CHANGE_COMMAND_9600 = new byte[] { 0, 0, 0, 0, 66, 0, 0, 1, 3 };
        // If meter returns an error, the error letter (P for pressure, T temperature, etc.) will be 
        // appended by the follwoing ERROR_STRING string. So, any return data from a meter that has this 
        // substring in it, it is an error. 
        string ERROR_STRING = "-00-C0-7F";
        List<GasMeter> _coll_GasMeters = null;
        //bool _isInProduction = false;
        int _finishedMeters = 0;
        // Set up a background worker array that we can use to read and update the meters
        private List<BackgroundWorker> _bwArray = new List<BackgroundWorker>();
        // Set up the number of background worker threads we want to run
        private int _bwThreadCount = 8;

        // A gas meter collection from the database used to read the values of each gas meters
        private List<GasMeter> _gasMeters = new List<GasMeter>();
        private List<string> _completedMeters = new List<string>();
        // A global collection used for reading/hold only the Corrected Volume values of each meter. 
        private Dictionary<string, int> _coll_meterNameAndCorrectedVolume = new Dictionary<string, int>();

        // Global collection that will hold onto the values for the grid
        private MeterReadItemCollection _meterReadItemCollection = new MeterReadItemCollection();
        public List<SocketWithName> SocketsList = new List<SocketWithName>();
        System.Timers.Timer tmrRun = null;

        public string SelectedFurnaceOption { get; set; }
        public string SelectedIntervalOption { get; set; }

        private string _feedback = string.Empty;

        public string ExecuteLogRequest(string Furnace, string Interval)
        {
            _feedback = string.Empty;

            SelectedFurnaceOption = Furnace;
            SelectedIntervalOption = Interval;

            PopulateMeters();

            _currentRequestExported = false;
            _meterReadItemCollection = new MeterReadItemCollection();

            SocketsList = GasMeterHelper.GetSocketCollection(_coll_GasMeters);

            try
            {
                switch (SelectedIntervalOption.ToUpper())
                {
                    case "MONTHLY":
                        _startAddress = MONTHLY_COMMAND_START_ADDRESS;
                        _endAddress = MONTHLY_LOG_LAST_ADDRESS;
                        break;
                    case "DAILY":
                        _startAddress = DAILY_COMMAND_START_ADDRESS;
                        _endAddress = DAILY_LOG_LAST_ADDRESS;
                        break;
                }

                tmrRun = new System.Timers.Timer();
                tmrRun.Enabled = false;
                tmrRun.Interval = 2000;
                tmrRun.Elapsed += tmrRun_Tick;

                if (_bwArray.Count == 0)
                    InitializeBackgroundWorkers();

                tmrRun.Enabled = true;
            }
            catch (Exception exc)
            {
                if (_feedback.Length > 0)
                    _feedback += Environment.NewLine;

                _feedback += exc.Message.ToString();
            }

            return _feedback;
        }

        //Formerly known as frmTestGE_MCUT_Reader_Load
        private void InitializeBackgroundWorkers()
        {
            // Set up the background worker array to have nothing more 
            // than the number of threads we've specified at the top
            _bwArray = new List<BackgroundWorker>();
            for (int i = 0; i < _bwThreadCount; i++)
            {
                BackgroundWorker bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true;
                bw.WorkerSupportsCancellation = true;
                bw.DoWork += bw_DoWork;
                bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                _bwArray.Add(bw);
            }

            _completedMeters = new List<string>();
        }

        private void PopulateMeters()
        {
            using (WildcatContext wcc = new WildcatContext())
            {
                if (SelectedFurnaceOption == "ALL")
                    _coll_GasMeters = wcc.GasMeter.ToList();
                else
                {
                    _coll_GasMeters = new List<GasMeter>();
                    _coll_GasMeters.Add(wcc.GasMeter.Where(x => x.MeterName.Equals(SelectedFurnaceOption)).FirstOrDefault());
                }
            }

            foreach (GasMeter gmt in _coll_GasMeters)
            {
                _coll_meterNameAndCorrectedVolume.Add(gmt.MeterName, 0);
                gmt.Message = string.Empty;
            }

            _gasMeters = _coll_GasMeters.ToList();
        }

        //Formerly known as tmrRun_Tick
        private void tmrRun_Tick(object sender, EventArgs e)
        {
            // When the timer ticks off, go through the list of 
            // background worker processes and find an empty/sleeping one
            if (_gasMeters.Count == _meterReadItemCollection.Count)
            {
                int busyCount = 0;
                foreach (BackgroundWorker bw in _bwArray)
                {
                    if (bw.IsBusy)
                    { busyCount++; }
                }
                if (busyCount == 0 &&
                    tmrRun.Enabled)
                {
                    tmrRun.Enabled = false;
                    return;	 // We've already processed them all
                }
            }
            foreach (BackgroundWorker bw in _bwArray)
            {
                // Fire off the process
                MeterReadItem item = null;
                foreach (GasMeter gm in _gasMeters)
                {
                    if (!bw.IsBusy)
                    {
                        if (!_completedMeters.Contains(gm.MeterName))
                        {
                            gm.Message = "Processing";

                            _completedMeters.Add(gm.MeterName);
                            item = new MeterReadItem(gm.MeterName, "Waiting");
                            _meterReadItemCollection.Add(item);
                            bw.RunWorkerAsync(item);
                        }
                    }
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //RefreshGrid();		// Refresh the grid

            // Check if we can turn back on the form
            int busyCount = 0;

            foreach (BackgroundWorker bw in _bwArray)
            {
                if (bw.IsBusy) { busyCount++; }
            }

            if (busyCount == 0 && tmrRun.Enabled && _meterReadItemCollection.Count == _gasMeters.Count)
            {
                tmrRun.Enabled = false;

                if (!_currentRequestExported)
                {
                    switch (SelectedIntervalOption.ToUpper())
                    {
                        default:
                        case "LIVE":
                            WriteToXlsFile();
                            break;
                        case "DAILY":
                            WriteDailyLogsToXlsFile();
                            break;
                        case "MONTHLY":
                            WriteMonthlyLogsToXlsFile();
                            break;
                    }

                    //Wait a second to give the methods above time to wrap up.  Once
                    // we say update is 100 percent, the client will try to download, so
                    // it MUST be ready before
                    Thread.Sleep(2000);

                    UpdateProgressToComplete();
                }
            }
        }

        private void UpdateProgressToComplete()
        {
            foreach (var swn in this.SocketsList)
            {
                swn.meterReadItem.Message = "Completed";
                swn.meterReadItem.Progress = 100;
            }
        }

        private int DivideByHundred(int value)
        {
            int rtv = value;

            if (value == 0)
                return rtv;

            rtv = Conversion.SafeInteger(Math.Round(rtv / 100.0, 0));

            return rtv;
        }

        /// <summary>
        /// This method formats the dictionary per James Wilbourn's request
        /// </summary>
        private Dictionary<string, int> FormatDictionary(Dictionary<string, int> unformattedDictionary)
        {
            Dictionary<string, int> formattedDictionary = new Dictionary<string, int>();

            if (SelectedFurnaceOption == "ALL")
            {
                formattedDictionary.Add("FPM", 0);
                formattedDictionary.Add("FHN", 0);
                formattedDictionary.Add("FPN", 0);
                formattedDictionary.Add("FUF", 0);
                formattedDictionary.Add("FHH", 0);
                formattedDictionary.Add("FPL", 0);
                formattedDictionary.Add("FRB", 0);

                //Probably doesn't exist
                formattedDictionary.Add("FFE", 0);

                formattedDictionary.Add("FBE", 0);

                //Probably doesn't exist
                formattedDictionary.Add("FFD", 0);

                formattedDictionary.Add("FFB", 0);
                formattedDictionary.Add("FBF", 0);
                formattedDictionary.Add("FBR", 0);
                formattedDictionary.Add("FD8", 0);
                formattedDictionary.Add("FUS", 0);
                formattedDictionary.Add("FUR", 0);
                formattedDictionary.Add("FPK", 0);
                formattedDictionary.Add("FNH", 0);
                formattedDictionary.Add("FNE", 0);
                formattedDictionary.Add("FXR", 0);
                formattedDictionary.Add("FXT", 0);
                formattedDictionary.Add("FDR", 0);

                //Probably doesn't exist
                formattedDictionary.Add("FDS", 0);

                formattedDictionary.Add("FHX", 0);
                formattedDictionary.Add("RHA", 0);
                formattedDictionary.Add("FUH", 0);
                formattedDictionary.Add("AFB", 0);
                formattedDictionary.Add("FDV", 0);
                formattedDictionary.Add("RHC", 0);
                formattedDictionary.Add("RHT", 0);
                formattedDictionary.Add("FBD", 0);
            }
            else
            {
                formattedDictionary.Add(SelectedFurnaceOption, 0);
            }

            foreach (KeyValuePair<string, int> kvp in unformattedDictionary)
            {
                var gmr = _coll_GasMeters.Where(x => x.MeterName.Equals(kvp.Key)).FirstOrDefault();

                if (gmr != null)
                    formattedDictionary[gmr.MeterName] = DivideByHundred(kvp.Value);
            }

            return formattedDictionary;
        }

        private List<DateTime> GetCalendarDays(int LookBackPeriod, bool OnlyFirstOfMonth)
        {
            List<DateTime> rtv = new List<DateTime>();

            for (int i = LookBackPeriod; i > 0; i--)
            {
                //Today gets midnight
                DateTime newDay = DateTime.Today.AddDays(-1 * i);

                if (!OnlyFirstOfMonth)
                    rtv.Add(newDay);
                else
                {
                    if (newDay.Day == 1)
                        rtv.Add(newDay);
                }
            }

            return rtv;
        }

        public void WriteMonthlyLogsToXlsFile()
        {
            _currentRequestExported = true;

            Console.WriteLine("Writing monthly log");

            int daystoLookBack = 95;

            Workbook wb = new Workbook();
            Worksheet ws = wb.Worksheets[0];

            Cell cellCursor = null;

            int rowIndex = 0;
            int columnIndex = 0;

            string title = "Date";
            cellCursor = ws.Cells[rowIndex, columnIndex];
            cellCursor.PutValue(title);

            //Get Meters in Order
            Dictionary<string, int> formattedDictionary = FormatDictionary(_coll_meterNameAndCorrectedVolume);

            //Get midnight timestamp for last 90 days
            List<DateTime> daysOfInterest = GetCalendarDays(daystoLookBack, true);

            //Populate first column with the midnight dates
            foreach (DateTime dayOfInterest in daysOfInterest)
            {
                rowIndex++;
                cellCursor = ws.Cells[rowIndex, 0];
                cellCursor.PutValue(dayOfInterest.ToShortDateString());
            }

            GasMeterLog gml = null;

            using (WildcatContext wcc = new WildcatContext())
            {
                foreach (KeyValuePair<string, int> kvp in formattedDictionary)
                {
                    //Reset rowIndex for each meter
                    rowIndex = 0;
                    columnIndex++;

                    List<GasMeterLog> recentLogs = wcc.GasMeterLog.Where(x => x.Timestamp >= DateTime.Now.AddDays(-1 * daystoLookBack) && x.MeterName.Equals(kvp.Key)).ToList();

                    //Insert meter name
                    cellCursor = ws.Cells[rowIndex, columnIndex];
                    cellCursor.PutValue(kvp.Key);

                    int monthsExamined = Conversion.SafeInteger(daystoLookBack / 30f);

                    for (int i = 0; i < daysOfInterest.Count; i++)
                    {
                        rowIndex = i + 1;

                        //Note monthly is orderby and daily is orderbydescending; this discrepancy was already in place so you kept it in order for the 
                        // numbers to match the legacy system developed by JM
                        //Temporarily add 1 day and find max date that precedes the midnight time
                        gml = recentLogs.Where(x => x.Timestamp >= daysOfInterest[i] && x.Timestamp < daysOfInterest[i].AddDays(1)).OrderBy(x => x.Timestamp).FirstOrDefault();

                        //If we got nothing, be prepared to report a zero
                        if (gml == null)
                            gml = new GasMeterLog();

                        //Insert meter value
                        cellCursor = ws.Cells[rowIndex, columnIndex];
                        cellCursor.PutValue(Conversion.SafeInteger(gml.CorrectedVolume));
                    }
                }
            }

            string exportFileName = @"meter.xls";
            string exportFilePath = @"C:\temp\";

            if (File.Exists(Path.Combine(exportFilePath, exportFileName)))
                File.Delete(Path.Combine(exportFilePath, exportFileName));

            FileStream stream = new FileStream(Path.Combine(exportFilePath, exportFileName), FileMode.Create);

            wb.FileName = exportFileName;
            wb.Save(stream, new XlsSaveOptions(SaveFormat.Excel97To2003));

            stream.Position = 0;
            stream.Close();
        }

        //This is a new method because Maria did not have a daily xls before Wildcat
        public void WriteDailyLogsToXlsFile()
        {
            _currentRequestExported = true;

            Console.WriteLine("Writing daily log");

            int daystoLookBack = 30;

            Workbook wb = new Workbook();
            Worksheet ws = wb.Worksheets[0];

            Cell cellCursor = null;

            int rowIndex = 0;
            int columnIndex = 0;

            string title = "Date";
            cellCursor = ws.Cells[rowIndex, columnIndex];
            cellCursor.PutValue(title);

            //Get Meters in Order
            Dictionary<string, int> formattedDictionary = FormatDictionary(_coll_meterNameAndCorrectedVolume);

            //Get midnight timestamp for last sixty days
            List<DateTime> daysOfInterest = GetCalendarDays(daystoLookBack, false);

            //Populate first column with the midnight dates
            foreach (DateTime dayOfInterest in daysOfInterest)
            {
                rowIndex++;
                cellCursor = ws.Cells[rowIndex, 0];
                cellCursor.PutValue(dayOfInterest.ToShortDateString());
            }

            GasMeterLog gml = null;

            using (WildcatContext wcc = new WildcatContext())
            {
                foreach (KeyValuePair<string, int> kvp in formattedDictionary)
                {
                    //Reset rowIndex for each meter
                    rowIndex = 0;
                    columnIndex++;

                    //Convert meter name back to ID int, since that is the only way we can look up data entries
                    //GasMeter gmt = _coll_GasMeters.Where(x => x.MeterName.Equals(kvp.Key)).FirstOrDefault();

                    List<GasMeterLog> recentLogs = wcc.GasMeterLog.Where(x => x.Timestamp >= DateTime.Now.AddDays(-1 * daystoLookBack) && x.MeterName.Equals(kvp.Key)).ToList();

                    //Insert meter name
                    cellCursor = ws.Cells[rowIndex, columnIndex];
                    cellCursor.PutValue(kvp.Key);

                    for (int i = 0; i < daystoLookBack; i++)
                    {
                        rowIndex = i + 1;

                        //Temporarily add 1 day and find max date that precedes the midnight time
                        gml = recentLogs.Where(x => x.Timestamp >= daysOfInterest[i] && x.Timestamp < daysOfInterest[i].AddDays(1)).OrderByDescending(x => x.Timestamp).FirstOrDefault();

                        //If we got nothing, be prepared to report a zero
                        if (gml == null)
                            gml = new GasMeterLog();

                        //Insert meter value
                        cellCursor = ws.Cells[rowIndex, columnIndex];
                        cellCursor.PutValue(Conversion.SafeInteger(gml.CorrectedVolume));
                    }
                }
            }

            string exportFileName = @"meter.xls";
            string exportFilePath = @"C:\temp\";

            if (File.Exists(Path.Combine(exportFilePath, exportFileName)))
                File.Delete(Path.Combine(exportFilePath, exportFileName));

            FileStream stream = new FileStream(Path.Combine(exportFilePath, exportFileName), FileMode.Create);

            wb.FileName = exportFileName;
            wb.Save(stream, new XlsSaveOptions(SaveFormat.Excel97To2003));

            stream.Position = 0;
            stream.Close();
        }

        public void WriteToXlsFile()
        {
            _currentRequestExported = true;

            Workbook wb = new Workbook();
            Worksheet ws = wb.Worksheets[0];

            Cell cellCursor = null;

            string title = "Date";
            cellCursor = ws.Cells[0, 0];
            cellCursor.PutValue(title);

            string dateAsString = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
            cellCursor = ws.Cells[1, 0];
            cellCursor.PutValue(dateAsString);

            Dictionary<string, int> formattedDictionary = FormatDictionary(_coll_meterNameAndCorrectedVolume);

            int meters = formattedDictionary.Count;

            for (int i = 1; i <= meters; i++)
            {
                cellCursor = ws.Cells[0, i];
                cellCursor.PutValue(formattedDictionary.ElementAt(i - 1).Key);
            }

            for (int i = 1; i <= meters; i++)
            {
                cellCursor = ws.Cells[1, i];
                cellCursor.PutValue(formattedDictionary.ElementAt(i - 1).Value);
            }

            string exportFileName = @"meter.xls";
            string exportFilePath = @"C:\temp\";

            if (File.Exists(Path.Combine(exportFilePath, exportFileName)))
                File.Delete(Path.Combine(exportFilePath, exportFileName));

            FileStream stream = new FileStream(Path.Combine(exportFilePath, exportFileName), FileMode.Create);

            wb.FileName = exportFileName;
            wb.Save(stream, new XlsSaveOptions(SaveFormat.Excel97To2003));

            stream.Position = 0;
            stream.Close();
        }

        /// <summary>
        /// The method used to do the background work of reading from the meters
        /// </summary>
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            bool exitEarly = false;

            BackgroundWorker worker = sender as BackgroundWorker;
            MeterReadItem item = (MeterReadItem)e.Argument;
            GasMeterReading gmReading = null;
            GasMeter gm = _gasMeters.Where(x => x.MeterName.Equals(item.ItemName)).FirstOrDefault();

            SocketWithName swn = SocketsList.Where(x => x.meterName.Equals(gm.MeterName)).FirstOrDefault();

            switch (SelectedIntervalOption.ToUpper())
            {
                case "MONTHLY":
                case "DAILY":
                    CollectAllLogs(swn);
                    exitEarly = true;
                    break;
            }

            if (exitEarly)
                return;

            try
            {
                swn.meterReadItem.Progress = item.Progress = 33;
                swn.meterReadItem.Message = item.Message = "Processing";

                // Connect to the meter
                // ** Write your code here to connect to the meter ** //              
                // Array to hold the received data from the socket.
                byte[] receivedData = new byte[80];

                if (gm != null)
                {
                    // Define the socket 
                    IPEndPoint MeterServerEP = new IPEndPoint(System.Net.IPAddress.Parse((gm as GasMeter).MeterIp), PORT_NUMBER);
                    Socket requester = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    requester.ReceiveTimeout = 5000;
                    requester.Connect(MeterServerEP);

                    // The fifth item (108) in the command array represent the char 'l'  which requests live data from the meter. 
                    // The last two items(183,254) are the calculated CRC values. 
                    Byte[] command = new byte[] { 204, 204, 204, 204, 108, 0, 0, 1, 0, 183, 254 };

                    int byteSent = requester.Send(command);

                    //New, per Nicolae's suggestion (Rau, Nicolae (First Reserve, Non-GE) <Rau.Nicolae@bhge.com>)
                    Thread.Sleep(1000);

                    // Update the status of the control
                    swn.meterReadItem.Progress = item.Progress = 66;
                    swn.meterReadItem.Message = item.Message = "Processing";

                    // Read the meter
                    // ** Write your code here to read the meter ** //
                    // Read the socket response into the byte array.
                    int byteReceived = requester.Receive(receivedData);
                    if (receivedData[4] != 108)
                    {
                        swn.meterReadItem.Message = item.Message = "Request Denied";
                        //Progress should never be 100 until a file is created
                        swn.meterReadItem.Progress = item.Progress = 98;
                    }

                    // Instance of a SQL row/record.
                    gmReading = new GasMeterReading();

                    byte[] bCorectedValume = new byte[4];
                    Buffer.BlockCopy(receivedData, 8, bCorectedValume, 0, 4);
                    Int32 PresentFaults = receivedData[56];
                    Int32 OccuredFaults = receivedData[57];
                    Int32 PresentAlarms = receivedData[58];
                    Int32 OccurredAlarms = receivedData[59];
                    Int32 iCorrectedValume = BitConverter.ToInt32(bCorectedValume, 0);
                    gmReading.MeterName = (gm as GasMeter).MeterName;
                    gmReading.CorrectedVolume = iCorrectedValume;

                    _coll_meterNameAndCorrectedVolume[gmReading.MeterName] = Conversion.SafeInteger(gmReading.CorrectedVolume);

                    gmReading.PresentFaults = PresentFaults;
                    gmReading.OccurredFaults = OccuredFaults;
                    gmReading.PresentAlarms = PresentAlarms;
                    gmReading.OccurredAlarms = OccurredAlarms;

                    using (WildcatContext wcc = new WildcatContext())
                    {
                        gmReading.Timestamp = DateTime.Now;
                        wcc.GasMeterReading.Add(gmReading);
                        wcc.SaveChanges();
                    }

                    requester.Shutdown(SocketShutdown.Both);
                    requester.Close();
                }
            }
            catch (Exception ex)
            {
                //item.ItemIcon = MeterReadItemIcon.Error;

                string feedback = string.Empty;

                if (ex.Message.Length > 50)
                    feedback = ex.Message.Substring(0, 50);
                else
                    feedback = ex.Message;

                swn.meterReadItem.Message = item.Message = "Unable To Read"; // feedback;
                //item.TaskDetail = "Error";

            }
            finally
            {
                if (item.Message == "Processing")
                    swn.meterReadItem.Message = item.Message = "Ready To Export";

                //Progress should never be 100 until file is created
                if (swn.meterReadItem.Progress < 100)
                    swn.meterReadItem.Progress = item.Progress = 98;
            }
        }

        private void CollectAllLogs(SocketWithName socketWithName)
        {
            int commandResendCount = 0;
            int readCount = 0;

            socketWithName.meterReadItem.Message = "Processing";
            socketWithName.meterReadItem.TaskDetail = "Detail";
            // The command for reading the extended memory is the same (126), however the start address of 
            // the registers for each command differs. The first four bytes are the start address bytes. 
            // They are all zeros here but they will be changed for each command.            
            byte[] DATA_READ_COMMAND = new byte[] { 0, 0, 0, 0, 126, 0, 0, 68, 0 };

            //_meterReadItemCollection.Add(socketWithName.meterReadItem);

            // -------------------------------------------------------- Application.DoEvents();
            // Based on which start address is passed, the command will read either the 15min interval or the daily.
            // Copy the start address argument value into the command byte array.
            Buffer.BlockCopy(_startAddress, 0, DATA_READ_COMMAND, 0, 4);
            // Create an array to hold the read logged data
            // The length of the returned data is 68 +10 (8 bytes for echo and 2 for CRC).
            byte[] loggedData_CommandReturn = new byte[78];

            // This is for debugging purpose. 
            StringBuilder errors_Info = new StringBuilder();
            //errors_Info.AppendLine("-------------- " + socketWithName.meterName + " -----------------");
            //errors_Info.AppendLine("Start Time: " + DateTime.Now.ToString());

            // socket is ready for reading.
            socketWithName.IsOpen = true;
            // An instance of the gasMeterLog to hold the values of each log
            GasMeterLog gasMeterLog = new GasMeterLog();
            // Collection to hold all the logs for each meter. 
            List<GasMeterLog> coll_GasMeterLogs = new List<GasMeterLog>();

            // Create a socket for each meter.
            Socket requester = socketWithName.socket;
            requester.ReceiveTimeout = 10000;

            try
            {
                // Connect to the socket.
                requester.Connect(socketWithName.IpEndPoint);
                //Create byte arrays, one for each item in the log.
                byte[] _logDateTime = new byte[4];
                byte[] _correctedValume = new byte[4];
                byte[] _unCorrectedValume = new byte[4];
                byte[] _correctionFactor = new byte[4];
                byte[] _uncorrectedVolUnderFault = new byte[4];
                byte[] _averagePressure = new byte[4];
                byte[] _averageTemperature = new byte[4];
                byte[] _averageCorrectedFlow = new byte[4];
                byte[] _peakCorrectedFlow = new byte[4];
                byte[] _superCompressibility = new Byte[4];
                byte[] _minimumPressure = new byte[4];
                byte[] _maxPressure = new byte[4];
                byte[] _endingPressure = new byte[4];
                byte[] _minTemperature = new byte[4];
                byte[] _maxTemperature = new byte[4];
                byte[] _endingTemperature = new byte[4];
                byte[] _batteryVoltage = new byte[4];

                // The following Boolean will stay true until the last log is read.
                bool KeepReadingLogs = true;
                // The first read starts with the specific address. Each subsequent read's address
                // is 68 + previous address. 
                bool IsItTheFirstRead = true;
                // Holds the value of the previous address.
                int oldAddressNumber = 0;
                // This byte will hold the previous command's address byte. This is so if the crc values do not match
                // we will be able to attempt to resend (3 times) the previous command before declaring it a failure.
                byte[] previousAddressBytes = new Byte[4];
                byte[] currentAddressBytes = new byte[4];

                //socketWithName.meterReadItem.Progress += 5;

                //**********************************************************************
                // Read until all the unRecorded logs are read.
                while (KeepReadingLogs)
                {
                    if (DateTime.Now.Second % 5 == 0)
                        socketWithName.meterReadItem.Progress += 1;

                    Debug.WriteLine("Still reading " + socketWithName.meterReadItem.ItemName + "...with progress " + socketWithName.meterReadItem.Progress);

                    // If the timer has stopped, end the thread reading.
                    //if (_progressBarTimer.Enabled == false)
                    //{
                    //    break;
                    //}
                    // There is about 3300 logs per meter for 15min interval logs
                    // The length of the control is 100, so, if we advance the control by one for 
                    // every 30 read, the display will pretty closely show the progress. 
                    // The same is true for the daily log read except that the total of logs for
                    // daily log is about 33. So, if we increment the bars three notches for every log
                    // we are pretty close to 100, the bar's max number.
                    if (_startAddress[0] == 240 && readCount == 30)
                    {
                        //socketWithName.meterReadItem.Progress++;
                        readCount = 0;
                    }
                    else if (_startAddress[0] == 168 && readCount == 3)
                    {
                        //socketWithName.meterReadItem.Progress++;
                        readCount = 0;
                    }

                    // Since the number of read items is greater than the progress bar's maximum number
                    // the readCount in used as a multiplier/divider to match the read items with progress 
                    // bar's max number. Take a look at the above code and comments. 
                    readCount++;

                    // Items to hold the values for each log item
                    int correctedVolume;
                    int unCorrectedVolume;
                    decimal correctionFactor;
                    int uncorrectedVolUnderFault;
                    decimal batteryVoltage;
                    decimal averagePressure;
                    decimal averageTemperature;
                    decimal minimumPressure;
                    decimal maxPressure;
                    decimal endingPressure;
                    decimal minTemperature;
                    decimal maxTemperature;
                    decimal endingTemperature;
                    decimal averageCorrectedFlow;
                    decimal peakCorrectedFlow;
                    decimal superCompressibility;

                    // If it is not the first read, we need to increment the current address by 68 to 
                    // find the start address of the next log. 
                    if (!IsItTheFirstRead)
                    {
                        // Since the command is all in byte format, we need to convert the byte address
                        // of the current command to int, add 68, and convert it back to a byte array
                        // before injecting it in the command. 
                        Buffer.BlockCopy(DATA_READ_COMMAND, 0, previousAddressBytes, 0, 4);
                        int previousAddressNumber = BitConverter.ToInt32(previousAddressBytes, 0);
                        // The start address is byte[]{240,18} which is 4848. 
                        // The data length  is 68 bytes. The start of the next address is
                        // current address + 68. 
                        int currentAddressNumber = previousAddressNumber + 68;
                        // When the iteration reaches the end of its allocated range (238564)
                        //  or goes out of bound (negative number) we need to stop further reading. 
                        // For the daily log it will go beyond the DAILY_LOG_LAST_ADDRESS. For the 
                        // 15min interval, it goes to a negative number. 
                        if (currentAddressNumber > _endAddress || currentAddressNumber < 0) //DAILY_LOG_LAST_ADDRESS
                        {
                            //Debug.WriteLine(string.Format("--------current address {0}, last address{1}", newAddressNumber, endAddress));
                            break;
                        }
                        // Save the current address value for the next iteration's comparison. 
                        oldAddressNumber = currentAddressNumber;
                        // Convert the new address to byte array.
                        currentAddressBytes = BitConverter.GetBytes(currentAddressNumber);
                        // Inject the address bytes into the command byte's first four bytes. 
                        Buffer.BlockCopy(currentAddressBytes, 0, DATA_READ_COMMAND, 0, 4);
                        // Get the CRC for the command with a new address.
                        DATA_READ_COMMAND = GasMeterHelper.GetCommandWithCRC(DATA_READ_COMMAND);
                    }
                    else
                    {
                        // Use the static value of the start address and 
                        // calculate the CRC value of the command with it.
                        DATA_READ_COMMAND = GasMeterHelper.GetCommandWithCRC(DATA_READ_COMMAND);
                        // OK. We have read the first log. We don't need to run this again. 
                        IsItTheFirstRead = false;
                    }

                    // Increment the progress bar.
                    //Interlocked.Increment(ref _taskThreadCount);
                    //Debug.WriteLine("task thread count )" + _taskThreadCount);

                    if (requester.Connected)
                    {
                        // send the command.                      
                        int bytesSent = requester.Send(DATA_READ_COMMAND);
                        // The following sleep is for 1200 baud rate connection.
                        // It seems like anything faster than this fails the read. 
                        if (socketWithName.meterName == "FDR")
                            Thread.Sleep(3000);

                        // Read back the received data
                        int bytesReceived = requester.Receive(loggedData_CommandReturn);

                        // Verifying the validity of the returned data using the CRC. 
                        #region Checksum calculation/validation

                        // Returned byte array has 78 bytes: first 8 are echo + 68 data 2 CRC
                        byte[] crcByte = new byte[2];
                        Buffer.BlockCopy(loggedData_CommandReturn, 76, crcByte, 0, 2);

                        ushort crcValue = BitConverter.ToUInt16(crcByte, 0);
                        byte[] bufptr = new byte[76];
                        Buffer.BlockCopy(loggedData_CommandReturn, 0, bufptr, 0, 76);
                        int len = 76;  // LOGS_INFO_ARRAY_LENGTH_WITHOUT_ECHOandCRC;
                        ushort chr_bit = 0;
                        ushort crc_bit = 0;
                        ushort checkSumResult = 0;

                        byte chr = (byte)'0';
                        ushort bit_cnt = 0;
                        int _counter = 0;

                        if (len > 0)
                        {
                            do
                            {
                                chr = bufptr[_counter++];
                                for (bit_cnt = 0; bit_cnt < 8; bit_cnt++)
                                {
                                    chr_bit = (ushort)(chr & 0x01);
                                    crc_bit = (ushort)(checkSumResult & 0x01);
                                    checkSumResult >>= 1;
                                    chr >>= 1;
                                    if (0 != (chr_bit ^ crc_bit))
                                    {
                                        checkSumResult ^= 0x8408;
                                    }
                                }
                            }
                            while (--len > 0);
                        }

                        #endregion Checksum calculation/validation

                        if (checkSumResult != crcValue)
                        {
                            if (commandResendCount < 3)
                            {
                                commandResendCount++;
                                Thread.Sleep(1000);
                                continue;
                            }
                            #region Will do on the next version

                            // Generally the voracity of a serial communication should be verified by calculating and comparing the CRC values.
                            // However, since this will dramatically slow down this code, we are going to compare the sent command byte and the 
                            // received echo. If they are the same, then there is greater chance that the data is valid. 

                            //if (DATA_READ_COMMAND[4] != loggedData_CommandReturn[4])
                            //{
                            // To reduce the number of failures, we will try for three errors. 
                            //if (readTry < 3)
                            //{
                            //    if (!_isInProduction)
                            //    {
                            //        Debug.WriteLine(string.Format(" meter name {0}, command echo {1} read Try {2}", socketWithName.meterName,
                            //            loggedData_CommandReturn[4].ToString(), readTry));
                            //    }
                            //    readTry++;
                            //    continue;
                            //}


                            //*************************************
                            /* Whenever a meter is disconnected from its serial line, it reverts to its default 1200 baud rate. Since the 
                             * IP to serial devices stay at 9600, the communication between ShultzPro and the meter servers. The following code that uses
                             * the ChangeMeterBaudRate class does all the things that are necessary for chaning the meters baud rate back to 9600.
                             * However, as Ricu (GE engineer from East Europe) said, there is more to the MCUT app than just changing the baud rate.
                             * SO, for now, this feature is disconnected and James Willbourn will have to manually run the MCUT app and reset the meter's 
                             * baud rate to 9600. For now, the code below is commented out.
                             * ***********************************************
                            */
                            //if (socketWithName.meterName == "FHX" )
                            //{
                            //    string name = "FHX";
                            //}

                            //classes.ChangeMeterBaudRate changeMeterBaueRate = new classes.ChangeMeterBaudRate();
                            //// Let's change the IP to serial device baud rate first
                            //if (changeMeterBaueRate.ChangeSerialToIPDevice(socketWithName.IpEndPoint.Address.ToString(), CHANGE_SERIAL_TO_IP_BAUDRATE_TO_1200))
                            //{
                            //    if (changeMeterBaueRate.ChangeMeterBaudRateValue(socketWithName, METER_BAUDRATE_CHANGE_COMMAND_9600))
                            //    {
                            //        string s = "success";
                            //        //requester.Connect(socketWithName.IpEndPoint);
                            //    }
                            //    else
                            //    {
                            //        throw new Exception(String.Format("Could not connect with {0}'s gas meter.", socketWithName.meterName));
                            //    }
                            //    // If we were successful changing the meter's baud rate, let's change the IP to serial devices baud rate to match the meter's
                            //    changeMeterBaueRate.ChangeSerialToIPDevice(socketWithName.IpEndPoint.Address.ToString(), CHANGE_SERIAL_TO_IP_BAUDRATE_TO_9600);
                            //}
                            //else
                            //{ 
                            //}
                            #endregion Will do on the next version.
                            //********************************************
                            // The following string will be added to the exception in the catch block.
                            errors_Info.AppendLine(String.Format("Thrown Exception:  Meter Name: {0}.  The command was {1}.  The echo was {2}, at {3}",
                                socketWithName.meterName, DATA_READ_COMMAND[4].ToString(), loggedData_CommandReturn[4].ToString(), DateTime.Now.ToString()));
                            throw new Exception();
                        }

                        // The code will generate exception if any command fails three consecutive times.
                        // If the code has reached this line, that means that the command has succeeded. So we reset the number of tries back to zero.
                        commandResendCount = 0;

                        // If the CRC matched, then preserve the currentAddressByte as the previousAddressByte for next read. 
                        Buffer.BlockCopy(currentAddressBytes, 0, previousAddressBytes, 0, 4);

                        // Segregate the received data into each of its parts and Copy them into each specified byte array. 
                        // The first one is the DataTime of the log, Keep in mind that bytes 0-7 are the command echo. 
                        // Hence, we start from byte 8.
                        Buffer.BlockCopy(loggedData_CommandReturn, 8, _logDateTime, 0, 4);
                        // The log's dateTime format is in seconds from year 2000,1,1,0,0,0. 
                        // Let's calculate the seconds first.
                        int seconds = BitConverter.ToInt32(_logDateTime, 0);
                        // Create a timeSpan from the seconds.
                        TimeSpan ts = TimeSpan.FromSeconds(seconds);
                        // Determine the DateTime of the log. 
                        DateTime logDateTime = DATE_TIME_2000 + ts;

                        // Debug.WriteLine(string.Format(" meter name {0},  Date time {1}", socketWithName.meterName, logDateTime));
                        // Since the meters have very old data in their memory, we will discard any with 
                        // a log date of older than 2014/5/1. 
                        // incase we have some odd number that translate to a time in the future, we will ignore them also.
                        if (logDateTime < LOGING_START_DATE || logDateTime > DateTime.Now.AddMinutes(1))
                        {
                            continue;
                        }
                        // Check to see if the log already exists in the database. 
                        long retCount = 0;

                        using (WildcatContext wcc = new WildcatContext())
                        {
                            retCount = wcc.GasMeterLog.Where(x => x.MeterName.Equals(socketWithName.meterName) && x.Timestamp.Equals(logDateTime)).LongCount();
                        }

                        // If the log already exists in the database, go to the next log.
                        if (retCount > 0)
                        {
                            continue;
                        }

                        // Read and copy each items byte value from the returned 78 byte array. 
                        // Keep in mind that the first 8 bytes are the echo, and bytes 8-11 are the for Datetime.
                        Buffer.BlockCopy(loggedData_CommandReturn, 12, _correctedValume, 0, 4);

                        if (BitConverter.ToString(_correctedValume).Substring(2, 9) == "-00-C0-7F")
                        {
                            correctedVolume = -1000;
                        }
                        else
                        {
                            correctedVolume = BitConverter.ToInt32(_correctedValume, 0) / 100;

                            _coll_meterNameAndCorrectedVolume[socketWithName.meterName] = Conversion.SafeInteger(correctedVolume);
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 16, _unCorrectedValume, 0, 4);
                        if (BitConverter.ToString(_unCorrectedValume).Substring(2, 9) == ERROR_STRING)
                        {
                            unCorrectedVolume = -1000;
                        }
                        else
                        {
                            unCorrectedVolume = BitConverter.ToInt32(_unCorrectedValume, 0) / 100;
                        }
                        Buffer.BlockCopy(loggedData_CommandReturn, 20, _correctionFactor, 0, 4);

                        if (BitConverter.ToString(_correctionFactor).Substring(2, 9) == ERROR_STRING)
                        {
                            correctionFactor = -1000;
                        }
                        else
                        {
                            correctionFactor = (decimal)BitConverter.ToSingle(_correctionFactor, 0);
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 24, _uncorrectedVolUnderFault, 0, 4);
                        if (BitConverter.ToString(_uncorrectedVolUnderFault).Substring(2, 9) == ERROR_STRING)
                        {
                            uncorrectedVolUnderFault = -1000;
                        }
                        else
                        {
                            uncorrectedVolUnderFault = BitConverter.ToInt32(_uncorrectedVolUnderFault, 0);
                        }
                        // The following items each has a fault value string. To detect that, we will use the first character of that string
                        // If it is a match, we will set the value of that item to -1000. Engineering department knows that when they 
                        // see a -1000 value, there has been a fault registered for that log. 
                        Buffer.BlockCopy(loggedData_CommandReturn, 28, _averagePressure, 0, 4);

                        if (BitConverter.ToString(_averagePressure).Substring(2, 9) == ERROR_STRING)
                        {
                            averagePressure = -1000;
                        }
                        else
                        {
                            averagePressure = Math.Round((decimal)BitConverter.ToSingle(_averagePressure, 0) * PRESSURE_CONVERSION_FACTOR, 3);
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 32, _averageTemperature, 0, 4);

                        if (BitConverter.ToString(_averageTemperature).Substring(2, 9) == ERROR_STRING)
                        {
                            averageTemperature = -1000;
                        }
                        else
                        {
                            averageTemperature = Conversion.CelsiusToFahrenheit(Conversion.SafeDecimal(BitConverter.ToSingle(_averageTemperature, 0)));
                        }
                        Buffer.BlockCopy(loggedData_CommandReturn, 36, _averageCorrectedFlow, 0, 4);

                        if (BitConverter.ToString(_averageCorrectedFlow).Substring(2, 9) == ERROR_STRING)
                        {
                            averageCorrectedFlow = -1000;
                        }
                        else
                        {
                            averageCorrectedFlow = Math.Round((decimal)BitConverter.ToSingle(_averageCorrectedFlow, 0));
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 40, _peakCorrectedFlow, 0, 4);

                        if (BitConverter.ToString(_peakCorrectedFlow).Substring(2, 9) == ERROR_STRING)
                        {
                            peakCorrectedFlow = -1000;
                        }
                        else
                        {
                            peakCorrectedFlow = Math.Round((decimal)BitConverter.ToSingle(_peakCorrectedFlow, 0));
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 44, _superCompressibility, 0, 4);

                        if (BitConverter.ToString(_superCompressibility).Substring(2, 9) == ERROR_STRING)
                        {
                            superCompressibility = -1000;
                        }
                        else
                        {
                            superCompressibility = Math.Round((decimal)BitConverter.ToSingle(_superCompressibility, 0), 4);
                        }
                        // Meters hold alphaNumeric text for errors. In case there is an error and we know what character that error
                        // starts with, we can detect it and set the value for that item to -1000. This will let the Engineering guys 
                        // know that there has been an error recorded for this item.
                        Buffer.BlockCopy(loggedData_CommandReturn, 48, _minimumPressure, 0, 4);

                        if (BitConverter.ToString(_minimumPressure).Substring(2, 9) == ERROR_STRING)
                        {
                            minimumPressure = -1000;
                        }
                        else
                        {
                            minimumPressure = Math.Round((decimal)BitConverter.ToSingle(_minimumPressure, 0) * PRESSURE_CONVERSION_FACTOR, 3);
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 52, _maxPressure, 0, 4);

                        if (BitConverter.ToString(_maxPressure).Substring(2, 9) == ERROR_STRING)
                        {
                            maxPressure = -1000;
                        }
                        else
                        {
                            maxPressure = Math.Round((decimal)BitConverter.ToSingle(_maxPressure, 0) * PRESSURE_CONVERSION_FACTOR, 3);
                        }

                        Buffer.BlockCopy(loggedData_CommandReturn, 56, _endingPressure, 0, 4);

                        if (BitConverter.ToString(_endingPressure).Substring(2, 9) == ERROR_STRING)
                        {
                            endingPressure = -1000;
                        }
                        else
                        {
                            endingPressure = Math.Round((decimal)BitConverter.ToSingle(_endingPressure, 0) * PRESSURE_CONVERSION_FACTOR, 3);
                        }
                        Buffer.BlockCopy(loggedData_CommandReturn, 60, _minTemperature, 0, 4);

                        if (BitConverter.ToString(_minTemperature).Substring(2, 9) == ERROR_STRING)
                        {

                            minTemperature = -1000;
                        }
                        else
                        {
                            minTemperature = Conversion.CelsiusToFahrenheit(Conversion.SafeDecimal(BitConverter.ToSingle(_minTemperature, 0)));
                        }
                        Buffer.BlockCopy(loggedData_CommandReturn, 64, _maxTemperature, 0, 4);

                        if (BitConverter.ToString(_maxTemperature).Substring(2, 9) == ERROR_STRING)
                        {
                            maxTemperature = -1000;
                        }
                        else
                        {
                            maxTemperature = Conversion.CelsiusToFahrenheit(Conversion.SafeDecimal(BitConverter.ToSingle(_maxTemperature, 0)));
                        }
                        Buffer.BlockCopy(loggedData_CommandReturn, 68, _endingTemperature, 0, 4);

                        if (BitConverter.ToString(_endingTemperature).Substring(2, 9) == ERROR_STRING)
                        {
                            endingTemperature = -1000;
                        }
                        else
                        {
                            endingTemperature = Conversion.CelsiusToFahrenheit(Conversion.SafeDecimal(BitConverter.ToSingle(_endingTemperature, 0)));
                        }

                        // ASCII 76 is UPPER case L which signifies for 'Lo bAtt' (low battery)
                        Buffer.BlockCopy(loggedData_CommandReturn, 72, _batteryVoltage, 0, 4);
                        //if (_batteryVoltage[0] == 80 || _batteryVoltage[0] == 84 || _batteryVoltage[0] == 116 ||
                        //    BitConverter.ToString(_batteryVoltage) == "05-00-C0-7F" || BitConverter.ToString(_batteryVoltage) == ERRO_SRING_1)

                        if (BitConverter.ToString(_batteryVoltage).Substring(2, 9) == ERROR_STRING)
                        {
                            batteryVoltage = -1000;
                        }
                        else
                        {
                            batteryVoltage = (decimal)BitConverter.ToSingle(_batteryVoltage, 0);
                        }

                        // Fill the instance of the DailyReadings class to add to the collection.
                        //gasMeterLog.RecGUID = Guid.NewGuid().ToString();
                        gasMeterLog.Timestamp = logDateTime;
                        gasMeterLog.CorrectedVolume = correctedVolume;
                        gasMeterLog.UncorrectedVolume = unCorrectedVolume;
                        gasMeterLog.CorrectionFactor = correctionFactor;
                        gasMeterLog.UncorrectedVolUnderFault = uncorrectedVolUnderFault;
                        gasMeterLog.AveragePressure = averagePressure;
                        gasMeterLog.AverageTemperature = averageTemperature;
                        gasMeterLog.AvgCorrectedFlowRate = averageCorrectedFlow;
                        gasMeterLog.PeakCorrectedFlowRate = peakCorrectedFlow;
                        gasMeterLog.SupperCompressibility = superCompressibility;
                        gasMeterLog.MinimumPressure = minimumPressure;
                        gasMeterLog.MaxPressure = maxPressure;
                        gasMeterLog.EndingPressure = endingPressure;
                        gasMeterLog.MinTemperature = minTemperature;
                        gasMeterLog.MaxTemperature = maxTemperature;
                        gasMeterLog.EndingTemperature = endingTemperature;
                        gasMeterLog.BatteryVoltage = batteryVoltage;
                        gasMeterLog.MeterName = socketWithName.meterName;
                        // Add this log to the log collection.
                        coll_GasMeterLogs.Add(gasMeterLog);
                        // Reset the log object for the next log.
                        gasMeterLog = new GasMeterLog();
                    }
                    else
                    {
                        // If for some reason the meter is not connected yet, connect to it.
                        requester.Connect(socketWithName.IpEndPoint);
                    }

                    // I use the following to reduce the errors.
                    Thread.Sleep(100);
                }

                if (coll_GasMeterLogs.Count > 0)
                {
                    SaveToDataBase(socketWithName, errors_Info, coll_GasMeterLogs);
                }
            }
            catch (Exception ex)
            {
                // If for whatever reason there is a problem with reading data from a meter, And if there is any data
                // in the collection, try to save that in the DB. 
                if (coll_GasMeterLogs.Count > 0)
                {
                    SaveToDataBase(socketWithName, errors_Info, coll_GasMeterLogs);
                }

                // This is for debugging. Not sure if I should add log to the event viewer. 
                // It seems like updating the database always returns an error info. 
                //Progress should never be 100 until a file is created
                socketWithName.meterReadItem.Progress = 98;

                string feedback = string.Empty;

                if (ex.Message.Length > 50)
                    feedback = ex.Message.Substring(0, 50);
                else
                    feedback = ex.Message;

                socketWithName.meterReadItem.Message = "Unable To Read"; // feedback;
                socketWithName.meterReadItem.TaskDetail = "Unable To Read";
            }
            finally
            {
                if (socketWithName.IsOpen && requester.Connected)
                {
                    requester.Shutdown(SocketShutdown.Both);
                    requester.Close();
                    socketWithName.IsOpen = false;
                }

                Interlocked.Increment(ref _finishedMeters);

                _feedback = errors_Info.ToString();

                if (socketWithName.meterReadItem.Message == "Processing")
                    socketWithName.meterReadItem.Message = "Ready To Export";

                //Progress should never be 100 until file is created
                socketWithName.meterReadItem.Progress = 98;


            }
        }

        private static void SaveToDataBase(SocketWithName socketWithName, StringBuilder errors_Info, List<GasMeterLog> coll_GasMeterLogs)
        {
            using (WildcatContext wcc = new WildcatContext())
            {
                foreach (GasMeterLog gml in coll_GasMeterLogs)
                {
                    wcc.GasMeterLog.Add(gml);
                }

                try
                {
                    wcc.SaveChanges();
                }
                catch (Exception exc)
                {
                    //Log dup record errors here
                }
            }
        }
    }

    public class MeterReadItemCollection : List<MeterReadItem>
    {
        public MeterReadItemCollection()
        {
        }
    }
}
