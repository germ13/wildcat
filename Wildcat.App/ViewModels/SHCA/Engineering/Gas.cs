using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.SHCA.Engineering.GasMeters;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.Engineering
{
    public class Gas
    {
        public GasMeterManager MeterManager { get; set; }

        public List<GasMeter> GasMeters { get; set; }
        public string SelectedFurnaceOption { get; set; }
        public List<SelectListItem> FurnaceOptions { get; set; }
        public string SelectedIntervalOption { get; set; }
        public List<SelectListItem> IntervalOptions { get; set; }

        public List<SocketWithName> SocketList { get; }

        public double MinimumCompleteness { get; set; }

        public string TimeSpanAsString { get; set; }

        private DateTime _start { get; set; }
        private DateTime _stop { get; set; }

        //int _finishedMeters = 0;
        // Set up a background worker array that we can use to read and update the meters
        //private List<BackgroundWorker> _bwArray = new List<BackgroundWorker>();
        // Set up the number of background worker threads we want to run
        //private int _bwThreadCount = 3;

        public Gas()
        {
            PopulateModel();
        }

        public string GetPortionBarHTML(string ControlID, double FilledPortion, double UnfilledPortion, bool IsPercent)
        {
            string rtv = string.Empty;

            int filledPortion = Conversion.SafeInteger(Math.Round(FilledPortion, 0));
            int unfilledPortion = Conversion.SafeInteger(Math.Round(UnfilledPortion, 0));

            rtv = HtmlBuilder.GetPortionBarHTML(ControlID, filledPortion, unfilledPortion, IsPercent);

            return rtv;
        }

        public void PopulateModel()
        {
            _start = DateTime.Today.AddDays(-7);
            _stop = DateTime.Today.AddDays(1);

            TimeSpanAsString = string.Format("{0} - {1}", _start, _stop);

            MinimumCompleteness = 0;

            using (WildcatContext wcc = new WildcatContext())
            {
                GasMeters = wcc.GasMeter.OrderBy(x => x.MeterName).ToList();
            }

            foreach (GasMeter gmt in GasMeters)
            {
                gmt.PercentComplete = 0;
                gmt.PercentIncomplete = 100;
            }

            LoadOptions();
        }

        public void ExecuteLogRequest()
        {
            MeterManager.ExecuteLogRequest(SelectedFurnaceOption, SelectedIntervalOption);
        }

        //public int GetThreadCount()
        //{
        //    //_finishedMeters = 0;

        // GasMeterManager gmm = new GasMeterManager(); gmm.ExecuteLogRequest(SelectedFurnaceOption, SelectedIntervalOption);

        //    return gmm.TaskThreadCount;
        //}

        //public string GetProgress()
        //{
        //    string rtv = string.Empty;

        // GasMeterManager gmm = new GasMeterManager(); gmm.GetProgress();

        //    return rtv;
        //}

        public FileStreamResult ReadSpreadsheet()
        {
            string exportFileName = @"meter.xls";
            string exportFilePath = @"C:\temp\";

            FileStream str = File.OpenRead(Path.Combine(exportFilePath, exportFileName));
            FileStreamResult fsr = new FileStreamResult(str, "application/vnd.ms-excel");

            return fsr;
        }

        /*
        private void PopulateWorksheetTab(string tableName, ref Workbook wb, ref Worksheet ws)
        {
            int dashIndex = this.TimeSpanAsString.IndexOf('-');

            if (dashIndex == -1)
                dashIndex = (this.TimeSpanAsString.Length - 1);

            //Exit early if unable to determine date range
            if (dashIndex == -1)
                return;

            this._start = Conversion.SafeDate(this.TimeSpanAsString.Substring(0, dashIndex));
            this._stop = Conversion.SafeDate(this.TimeSpanAsString.Substring(dashIndex + 1));

            //The bootstrap calendar does not allow one second prior to end time...so we adjust it here
            this._stop = this._stop.AddSeconds(-1);

            DataTable dt = this.GetReport(this, tableName);

            //DateTime periodStop = reportRequest.Start.AddHours(reportRequest.SelectedDurationOption);
            string title = string.Format("GAS METER READINGS, {0}-{1}", this._start, this._stop);

            Cell cellCursor = null;

            cellCursor = ws.Cells[0, 0];

            //Add title
            cellCursor.PutValue(title);

            ws.Cells.ImportDataTable(dt, true, "A3");

            //Beg bold title
            wb.Styles.Add();
            Aspose.Cells.Style style = wb.CreateStyle();

            //style.Pattern = BackgroundType.Solid;
            style.Font.IsBold = true;

            StyleFlag styleFlag = new StyleFlag();
            styleFlag.FontBold = true;

            cellCursor.SetStyle(style, styleFlag);
            //End bold title

            //Add day style to start-date
            style.Number = 14;
            style.Font.IsBold = false;
            styleFlag.NumberFormat = true;
            Column column = ws.Cells.Columns[1];
            column.ApplyStyle(style, styleFlag);

            //Add time style to start-date
            style.Number = 21;
            style.Font.IsBold = false;
            styleFlag.NumberFormat = true;
            column = ws.Cells.Columns[2];
            column.ApplyStyle(style, styleFlag);

            //Add time style to end-date
            style.Number = 21;
            style.Font.IsBold = false;
            styleFlag.NumberFormat = true;
            column = ws.Cells.Columns[3];
            column.ApplyStyle(style, styleFlag);

            //Add number style
            style.Number = 4;
            style.Font.IsBold = false;
            styleFlag.NumberFormat = true;
            column = ws.Cells.Columns[4];
            column.ApplyStyle(style, styleFlag);

            ////Add grey style
            //Range range = ws.Cells.CreateRange("A5", "A100");
            //style.Font.Color = System.Drawing.Color.LightGray;
            //styleFlag.Font = true;
            //range.ApplyStyle(style, styleFlag);

            //Reset
            style.Font.Color = System.Drawing.Color.Black;
            styleFlag.Font = false;

            //Improve clarity of day/time columns
            cellCursor = ws.Cells[2, 1];
            cellCursor.PutValue("START DAY");

            cellCursor = ws.Cells[2, 2];
            cellCursor.PutValue("START TIME");

            //Format numbers/averages
            style.Number = 4;
            style.Font.IsBold = false;
            styleFlag.NumberFormat = true;
            column = ws.Cells.Columns[4];
            column.ApplyStyle(style, styleFlag);

            //Bold column headers...do this formatting last, because
            // number formatting the averages last wipes out bold on
            // column header
            style.Font.IsBold = true;
            styleFlag.FontBold = true;

            Row row = ws.Cells.Rows[2];
            row.ApplyStyle(style, styleFlag);

            //TAG
            ws.Cells.SetColumnWidth(0, 60);
            //DAY
            ws.Cells.SetColumnWidth(1, 15);
            //HOUR
            ws.Cells.SetColumnWidth(2, 15);
            //STOP
            ws.Cells.HideColumn(3);
            //AVERAGE
            ws.Cells.SetColumnWidth(4, 15);
            //NOTES
            ws.Cells.SetColumnWidth(5, 15);
        }
        */

        public HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            return HtmlBuilder.Dropdown(id, selectListItems, label, selectedValue, width);
        }

        private void LoadOptions()
        {
            SelectedIntervalOption = "Monthly";

            IntervalOptions = new List<SelectListItem>();

            IntervalOptions.Add(new SelectListItem { Value = "MONTHLY", Text = "Monthly" });
            IntervalOptions.Add(new SelectListItem { Value = "DAILY", Text = "Daily" });
            IntervalOptions.Add(new SelectListItem { Value = "LIVE", Text = "Live" });

            //ON 07/19/19 MARIA SAYS SHE DOES NOT USE THIS OPTION
            //IntervalOptions.Add(new SelectListItem { Value = "15MIN", Text = "15 Minutes" });

            SelectedFurnaceOption = "ALL";
            ////TEMP
            //SelectedFurnaceOption = "FBF";

            FurnaceOptions = new List<SelectListItem>();

            FurnaceOptions.Add(new SelectListItem { Value = "ALL", Text = "ALL" });

            foreach (GasMeter g in GasMeters)
            {
                FurnaceOptions.Add(new SelectListItem { Value = g.MeterName, Text = g.MeterName });
            }
        }
    }
}