
using Aspose.Cells;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Wildcat.Entities.SHCA.Engineering.FUP;
using Wildcat.Entities.SHCA.Engineering.FXP;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.Engineering
{
    public class PressData
    {
        public PressData()
        {
            _start = DateTime.Today.AddDays(-2);
            _stop = DateTime.Today.AddDays(1);

            TimeSpanAsString = string.Format("{0} - {1}", _start, _stop);

            LoadOptions();
        }

        public bool ProcessingDownload { get; set; }

        private DateTime _start { get; set; }
        private DateTime _stop { get; set; }

        public string TimeSpanAsString { get; set; }
        public string SelectedDatabases { get; set; }
        public string divLoadContent { get; set; }
        public List<SelectListItem> DataBaseOptions { get; set; }

        private void LoadOptions()
        {

            //SelectedDatabases = "FXP";

            DataBaseOptions = new List<SelectListItem>();

            DataBaseOptions.Add(new SelectListItem { Value = "FXP", Text = "FXP" });
            DataBaseOptions.Add(new SelectListItem { Value = "FUP", Text = "FUP" });

            //int optionCount = DataBaseOptions.Count;
        }

        public HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            return HtmlBuilder.Dropdown(id, selectListItems, label, selectedValue, width);
        }

        public HtmlString ListBox(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            return HtmlBuilder.ListBox(id, selectListItems, label, selectedValue, width);
        }

        public string MakeExportFile()
        {
            ProcessingDownload = true;

            string exportFileName = string.Empty;

            int dashIndex = TimeSpanAsString.IndexOf('-');

            if (dashIndex == -1)
                dashIndex = (TimeSpanAsString.Length - 1);

            //Exit early if unable to determine date range
            if (dashIndex == -1)
            {
                ProcessingDownload = false;

                return string.Empty;
            }

            _start = Conversion.SafeDate(TimeSpanAsString.Substring(0, dashIndex));
            _stop = Conversion.SafeDate(TimeSpanAsString.Substring(dashIndex + 1));

            //The bootstrap calendar does not allow one second prior to end time...so we adjust it here
            _stop = _stop.AddSeconds(-1);

            TimeSpan timeSpan = _stop - _start;

            Stopwatch sw = new Stopwatch();

            try
            {
                sw.Start();

                exportFileName = WriteDataToXlsxFile();
            }
            catch (Exception e)
            {

            }
            finally
            {
                sw.Stop();
            }

            long elapsedSeconds = sw.ElapsedMilliseconds / 1000;

            ProcessingDownload = false;

            return exportFileName;
        }

        /// <summary>
        /// Do not use old school xls because we over 1M, not 65K records
        /// </summary>
        private string WriteDataToXlsxFile()
        {
            Workbook wb = new Workbook();
            Worksheet ws = wb.Worksheets[0];

            Cell cellCursor = null;

            int rowIndex = 0;
            int columnIndex = 0;

            List<string> headers = new List<string>();

            headers.Add("ID");
            headers.Add("NAME");
            headers.Add("NUMERICID");
            headers.Add("VALUE");
            headers.Add("TIMESTAMP");
            headers.Add("QUALITY");

            wb.Styles.Add();

            StyleFlag stf = new StyleFlag();

            stf.FontBold = true;

            Style stl = wb.CreateStyle();

            stl.Font.IsBold = true;
            stl.Pattern = BackgroundType.Solid;
            stl.ForegroundColor = System.Drawing.Color.LightGray;

            for (int i = 0; i < headers.Count; i++)
            {
                columnIndex = i;

                cellCursor = ws.Cells[rowIndex, columnIndex];
                cellCursor.PutValue(headers[columnIndex]);

                cellCursor.SetStyle(stl, stf);
            }

            //Widen name column
            ws.Cells.SetColumnWidth(1, 60);
            //Widen timestamp column
            ws.Cells.SetColumnWidth(4, 20);

            ////Apply number format
            //sty.Number = 4;
            //sty.Font.IsBold = false;
            //stf.NumberFormat = true;

            //Column column = ws.Cells.Columns[3];
            ////column = ws.Cells.Columns[4];
            //column.ApplyStyle(sty, stf);

            //Reset
            columnIndex = 0;
            int recordCount = 0;

            //Note, press choices are not mutually exclusive
            if (SelectedDatabases.Contains("FXP"))
            {
                using (FXPContext fxc = new FXPContext())
                {
                    List<TFxp> rec = fxc.TFxp.Where(x => x.Timestamp >= _start && x.Timestamp <= _stop).ToList();

                    recordCount = rec.Count;

                    for (int i = 0; i < recordCount; i++)
                    {
                        rowIndex++;

                        cellCursor = ws.Cells[rowIndex, columnIndex];
                        cellCursor.PutValue(rec[i].Id);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 1];
                        cellCursor.PutValue(rec[i].Name);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 2];
                        cellCursor.PutValue(rec[i].Numericid);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 3];
                        cellCursor.PutValue(rec[i].Value);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 4];
                        cellCursor.PutValue(Conversion.SafeDate(rec[i].Timestamp).ToString("MM/dd/yyyy HH:mm:ss"));

                        cellCursor = ws.Cells[rowIndex, columnIndex + 5];
                        cellCursor.PutValue(rec[i].Quality);

                        //This caps our rows so we don't exceed Excel 2004+ limits
                        if (rowIndex > 1000000)
                            i = recordCount;
                    }
                }
            }

            if (SelectedDatabases.Contains("FUP"))
            {
                using (FUPContext fpc = new FUPContext())
                {
                    List<TFup> rec = fpc.TFup.Where(x => x.Timestamp >= _start && x.Timestamp <= _stop).ToList();

                    recordCount = rec.Count;

                    for (int i = 0; i < recordCount; i++)
                    {
                        rowIndex++;

                        cellCursor = ws.Cells[rowIndex, columnIndex];
                        cellCursor.PutValue(rec[i].Id);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 1];
                        cellCursor.PutValue(rec[i].Name);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 2];
                        cellCursor.PutValue(rec[i].Numericid);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 3];
                        cellCursor.PutValue(rec[i].Value);

                        cellCursor = ws.Cells[rowIndex, columnIndex + 4];
                        cellCursor.PutValue(Conversion.SafeDate(rec[i].Timestamp).ToString("MM/dd/yyyy HH:mm:ss"));

                        cellCursor = ws.Cells[rowIndex, columnIndex + 5];
                        cellCursor.PutValue(rec[i].Quality);

                        //This caps our rows so we don't exceed Excel 2004+ limits
                        if (rowIndex > 1000000)
                            i = recordCount;
                    }
                }
            }

            string exportFileName = string.Format("press_{0}.xlsx", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            string exportFilePath = @"C:\temp\";

            if (File.Exists(Path.Combine(exportFilePath, exportFileName)))
                File.Delete(Path.Combine(exportFilePath, exportFileName));

            FileStream stream = new FileStream(Path.Combine(exportFilePath, exportFileName), FileMode.Create);

            wb.FileName = exportFileName;
            wb.Save(stream, new XlsSaveOptions(SaveFormat.Xlsx));

            stream.Position = 0;
            stream.Close();

            return exportFileName;
        }
    }
}
