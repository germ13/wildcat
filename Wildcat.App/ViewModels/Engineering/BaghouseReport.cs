using Aspose.Cells;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.Engineering
{
    public class BaghouseReport
    {
        //TODO SqlConnection not working, so commented out 
        //private readonly string _connectionString = @"Server=shca-sql01;Database=AQMD;User Id=DC_User;Password=DC_Userpwd";
        ////private readonly string _connectionString = @"Password=DC_Userpwd;Persist Security Info=True;User ID=DC_User;Initial Catalog=AQMD;Data Source=\\shca-sql01;Connection Timeout=7200";

        //public BaghouseReport()
        //{
        //    _start = DateTime.Today.AddDays(-2);
        //    _stop = DateTime.Today.AddDays(1);

        //    TimeSpanAsString = string.Format("{0} - {1}", _start, _stop);

        //    LoadOptions();
        //}

        //public bool ProcessingDownload { get; set; }

        //private DateTime _start { get; set; }
        //private DateTime _stop { get; set; }

        //public string TimeSpanAsString { get; set; }

        //public string SelectedMinValueOption { get; set; }
        //public string SelectedDatabases1 { get; set; }
        //public string SelectedDatabases2 { get; set; }
        //public string SelectedDatabases3 { get; set; }

        //public string SelectedDurationOption { get; set; }
        //public string divLoadContent { get; set; }

        //public List<SelectListItem> DurationOptions { get; set; }
        //public List<SelectListItem> DataBaseOptions1 { get; set; }
        //public List<SelectListItem> DataBaseOptions2 { get; set; }
        //public List<SelectListItem> DataBaseOptions3 { get; set; }
        //public List<SelectListItem> MinValueOptions { get; set; }

        //private void LoadOptions()
        //{
        //    DataBaseOptions1 = new List<SelectListItem>();

        //    DataBaseOptions1.Add(new SelectListItem { Value = "[DC1].dbo.tDC1", Text = "DC1" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[DC2].dbo.tDC2", Text = "DC2" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[DC3].dbo.tDC3", Text = "DC3" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[DC4].dbo.tDC4", Text = "DC4" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[DC5].dbo.tDC5", Text = "DC5" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[DC6].dbo.tDC6", Text = "DC6" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[FGL].dbo.tFGL1", Text = "FGL1" });
        //    DataBaseOptions1.Add(new SelectListItem { Value = "[FGL].dbo.tFGL2", Text = "FGL2" });

        //    StringBuilder sbr = new StringBuilder();

        //    sbr.Clear();

        //    foreach (SelectListItem sli in DataBaseOptions1)
        //    {
        //        if (sbr.Length > 0)
        //            sbr.Append(",");

        //        sbr.Append(sli.Value);
        //    }

        //    SelectedDatabases1 = sbr.ToString();

        //    DataBaseOptions2 = new List<SelectListItem>();

        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FGH].dbo.tFGH", Text = "FGH" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FG1].dbo.tFG1", Text = "FG1" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FG6].dbo.tFG6", Text = "FG6" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FGN].dbo.tFGN", Text = "FGN" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FGN_AD].dbo.tFGN_AD", Text = "FGN_AD" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[DOB].dbo.tDOB", Text = "DOB" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FGR].dbo.tFGRL", Text = "FGRL" });
        //    DataBaseOptions2.Add(new SelectListItem { Value = "[FGR].dbo.tFGRU", Text = "FGRU" });

        //    sbr.Clear();

        //    foreach (SelectListItem sli in DataBaseOptions2)
        //    {
        //        if (sbr.Length > 0)
        //            sbr.Append(",");

        //        sbr.Append(sli.Value);
        //    }

        //    SelectedDatabases2 = sbr.ToString();

        //    DataBaseOptions3 = new List<SelectListItem>();

        //    DataBaseOptions3.Add(new SelectListItem { Value = "[FGD].dbo.tFGD_1", Text = "FGD1" });
        //    DataBaseOptions3.Add(new SelectListItem { Value = "[FGD].dbo.tFGD_2", Text = "FGD2" });
        //    DataBaseOptions3.Add(new SelectListItem { Value = "[FGD].dbo.tFGD_3", Text = "FGD3" });
        //    DataBaseOptions3.Add(new SelectListItem { Value = "[FGD].dbo.tFGD_4", Text = "FGD4" });
        //    DataBaseOptions3.Add(new SelectListItem { Value = "[FGD].dbo.tFGD_5", Text = "FGD5" });
        //    DataBaseOptions3.Add(new SelectListItem { Value = "[FGD].dbo.tFGD_6", Text = "FGD6" });

        //    sbr.Clear();

        //    foreach (SelectListItem sli in DataBaseOptions3)
        //    {
        //        if (sbr.Length > 0)
        //            sbr.Append(",");

        //        sbr.Append(sli.Value);
        //    }

        //    SelectedDatabases3 = sbr.ToString();

        //    int optionCount = DataBaseOptions1.Count + DataBaseOptions2.Count + DataBaseOptions3.Count;

        //    SelectedMinValueOption = "0.05";

        //    MinValueOptions = new List<SelectListItem>();

        //    MinValueOptions.Add(new SelectListItem { Value = "0.00", Text = "0.00" });
        //    MinValueOptions.Add(new SelectListItem { Value = "0.01", Text = "0.01" });
        //    MinValueOptions.Add(new SelectListItem { Value = "0.02", Text = "0.02" });
        //    MinValueOptions.Add(new SelectListItem { Value = "0.03", Text = "0.03" });
        //    MinValueOptions.Add(new SelectListItem { Value = "0.04", Text = "0.04" });
        //    MinValueOptions.Add(new SelectListItem { Value = "0.05", Text = "0.05" });

        //    SelectedDurationOption = "8";

        //    DurationOptions = new List<SelectListItem>();

        //    DurationOptions.Add(new SelectListItem { Value = "1", Text = "1" });
        //    DurationOptions.Add(new SelectListItem { Value = "2", Text = "2" });
        //    DurationOptions.Add(new SelectListItem { Value = "4", Text = "4" });
        //    DurationOptions.Add(new SelectListItem { Value = "8", Text = "8" });
        //}

        //public HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        //{
        //    return HtmlBuilder.Dropdown(id, selectListItems, label, selectedValue, width);
        //}

        //public HtmlString ListBox(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        //{
        //    return HtmlBuilder.ListBox(id, selectListItems, label, selectedValue, width);
        //}

        //public string MakeSpreadsheet()
        //{
        //    ProcessingDownload = true;

        //    string fullPath = string.Empty;

        //    Workbook wb = new Workbook();

        //    string[] tableNames = ParseSelectedDatabases();

        //    string simpleTableName = string.Empty;

        //    foreach (string tableName in tableNames)
        //    {
        //        int lastDotPosition = tableName.LastIndexOf('.');

        //        //Add two to jump past the dot and the t prefix in table name
        //        simpleTableName = tableName.Substring(lastDotPosition + 2);

        //        if (wb.Worksheets[0].Name != "Sheet1")
        //            wb.Worksheets.Add();

        //        int wsIndex = wb.Worksheets.Count - 1;

        //        Worksheet ws = wb.Worksheets[wsIndex];

        //        PopulateWorksheetTab(tableName, ref wb, ref ws);

        //        ws.Name = simpleTableName;
        //    }

        //    string exportFileName = string.Format("aqmd_{0}.xls", DateTime.Now.ToString("yyyyMMdd_HHmmss"));

        //    string exportFilePath = @"C:\temp\";

        //    fullPath = Path.Combine(exportFilePath, exportFileName);

        //    FileStream str = new FileStream(fullPath, FileMode.Create);

        //    wb.FileName = exportFileName;
        //    wb.Save(str, new XlsSaveOptions(SaveFormat.Excel97To2003));
        //    str.Position = 0;
        //    str.Close();

        //    ProcessingDownload = false;

        //    return exportFileName;
        //}

        //public DataTable GetReport(BaghouseReport reportRequest, string tableName)
        //{
        //    DataTable dt = new DataTable();

        //    decimal? minValue = Convert.ToDecimal(reportRequest.SelectedMinValueOption);

        //    int duration = Convert.ToInt32(reportRequest.SelectedDurationOption);

        //    TimeSpan timeSpan = reportRequest._stop - reportRequest._start;
        //    decimal timeGroups = Math.Ceiling(Convert.ToDecimal(timeSpan.TotalHours) / Convert.ToDecimal(duration));

        //    DateTime reportStart = reportRequest._start;
        //    DateTime reportStop = reportRequest._start.AddHours(duration).AddSeconds(-1);

        //    string sql = string.Empty;

        //    StringBuilder sb = new StringBuilder();

        //    sql =
        //        @"SELECT
        //        o.sTagName AS TAG,
        //        innerSql.START1,
        //        innerSql.START2,
        //        innerSql.STOP,
        //        innerSql.AVERAGE,
        //        CASE WHEN innerSql.AVERAGE IS NULL THEN 'NO DATA' ELSE '' END AS NOTES
        //    FROM tAirQualityAudit o WITH(NOLOCK) LEFT JOIN (";

        //    sb.Append(sql);

        //    for (int i = 0; i < timeGroups; i++)
        //    {
        //        sql = string.Format(
        //            @"SELECT
        //                i.sTagName AS TAG,
        //                dtStartRange AS START1,
        //                dtStartRange AS START2,
        //                dtEndRange AS STOP,
        //                AVG(ISNULL(dblValue, 0)) AS AVERAGE
        //            FROM tAirQualityAudit i WITH(NOLOCK) INNER JOIN
        //            (

        //            SELECT
        //                _NAME AS sTagName,
        //                TRY_CAST(ISNULL(_VALUE, '0') AS NUMERIC(6, 3)) AS dblValue,
        //                [_TIMESTAMP] AS dtTimestamp,
        //                CAST('{2}' AS DATETIME) AS dtStartRange,
        //                CAST('{3}' AS DATETIME) AS dtEndRange
        //            FROM
        //                {0} WITH(NOLOCK)
        //            WHERE
        //                _TIMESTAMP BETWEEN '{2}' AND '{3}'
        //                AND TRY_CAST(ABS(_VALUE) AS NUMERIC(6, 3)) >= {4}

        //            ) d{1} ON i.sTagName = d{1}.sTagName
        //            GROUP BY
        //                i.sTagName, dtStartRange, dtEndRange", tableName, i, reportStart, reportStop, minValue
        //        );
        //        //@pdblMinValue
        //        sb.Append(sql);

        //        if (i < timeGroups - 1)
        //            sb.Append(" UNION ");

        //        reportStart = reportStart.AddHours(duration);
        //        reportStop = reportStop.AddHours(duration);

        //        if (reportStop > reportRequest._stop)
        //            reportStop = reportRequest._stop;
        //    }

        //    sql = ") innerSql ON innerSql.TAG = o.sTagName ";

        //    sb.Append(sql);

        //    sql = string.Format("WHERE o.sTableName = '{0}' ", tableName);

        //    sb.Append(sql);
        //    //sb.Append("ORDER BY TAG, START1");

        //    sql = sb.ToString().Replace("\r\n", "");
        //    //sql = sb.ToString().Replace(@"[SHCA-SQL01].", "");

        //    SqlCommand cmd = new SqlCommand(sql);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandTimeout = 7200;

        //    SqlConnection con = new SqlConnection(_connectionString);

        //    Stopwatch sw = new Stopwatch();

        //    try
        //    {
        //        con.Open();
        //        cmd.Connection = con;

        //        sw.Start();

        //        dt.Load(cmd.ExecuteReader());
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        sw.Stop();
        //    }

        //    long elapsedSeconds = sw.ElapsedMilliseconds / 1000;

        //    con.Dispose();

        //    return dt;
        //}

        //private string[] ParseSelectedDatabases()
        //{
        //    List<string> rtv = new List<string>();

        //    if (SelectedDatabases1 == null)
        //        SelectedDatabases1 = string.Empty;

        //    if (SelectedDatabases2 == null)
        //        SelectedDatabases2 = string.Empty;

        //    if (SelectedDatabases3 == null)
        //        SelectedDatabases3 = string.Empty;

        //    List<string> ls1 = this.SelectedDatabases1.Split(',').ToList();
        //    List<string> ls2 = this.SelectedDatabases2.Split(',').ToList();
        //    List<string> ls3 = this.SelectedDatabases3.Split(',').ToList();

        //    foreach (string lsi in ls1)
        //    {
        //        if (lsi.Trim().Length > 0)
        //            rtv.Add(lsi);
        //    }

        //    foreach (string lsi in ls2)
        //    {
        //        if (lsi.Trim().Length > 0)
        //            rtv.Add(lsi);
        //    }

        //    foreach (string lsi in ls3)
        //    {
        //        if (lsi.Trim().Length > 0)
        //            rtv.Add(lsi);
        //    }

        //    if (rtv.Count == 0)
        //    {
        //        rtv.Add(this.DataBaseOptions1.FirstOrDefault().Value);
        //    }

        //    return rtv.ToArray();
        //}

        //private void PopulateWorksheetTab(string tableName, ref Workbook wb, ref Worksheet ws)
        //{
        //    int dashIndex = this.TimeSpanAsString.IndexOf('-');

        //    if (dashIndex == -1)
        //        dashIndex = (this.TimeSpanAsString.Length - 1);

        //    //Exit early if unable to determine date range
        //    if (dashIndex == -1)
        //        return;

        //    this._start = Conversion.SafeDate(this.TimeSpanAsString.Substring(0, dashIndex));
        //    this._stop = Conversion.SafeDate(this.TimeSpanAsString.Substring(dashIndex + 1));

        //    //The bootstrap calendar does not allow one second prior to end time...so we adjust it here
        //    this._stop = this._stop.AddSeconds(-1);

        //    DataTable dt = this.GetReport(this, tableName);

        //    //DateTime periodStop = reportRequest.Start.AddHours(reportRequest.SelectedDurationOption);
        //    string title = string.Format("AQMD BAGHOUSE STATISTICS, {0}-{1}", this._start, this._stop);

        //    Cell cellCursor = null;

        //    cellCursor = ws.Cells[0, 0];

        //    //Add title
        //    cellCursor.PutValue(title);

        //    ws.Cells.ImportDataTable(dt, true, "A3");

        //    //Beg bold title
        //    wb.Styles.Add();
        //    Aspose.Cells.Style style = wb.CreateStyle();

        //    //style.Pattern = BackgroundType.Solid;
        //    style.Font.IsBold = true;

        //    StyleFlag styleFlag = new StyleFlag();
        //    styleFlag.FontBold = true;

        //    cellCursor.SetStyle(style, styleFlag);
        //    //End bold title

        //    //Add day style to start-date
        //    style.Number = 14;
        //    style.Font.IsBold = false;
        //    styleFlag.NumberFormat = true;
        //    Column column = ws.Cells.Columns[1];
        //    column.ApplyStyle(style, styleFlag);

        //    //Add time style to start-date
        //    style.Number = 21;
        //    style.Font.IsBold = false;
        //    styleFlag.NumberFormat = true;
        //    column = ws.Cells.Columns[2];
        //    column.ApplyStyle(style, styleFlag);

        //    //Add time style to end-date
        //    style.Number = 21;
        //    style.Font.IsBold = false;
        //    styleFlag.NumberFormat = true;
        //    column = ws.Cells.Columns[3];
        //    column.ApplyStyle(style, styleFlag);

        //    //Add number style
        //    style.Number = 4;
        //    style.Font.IsBold = false;
        //    styleFlag.NumberFormat = true;
        //    column = ws.Cells.Columns[4];
        //    column.ApplyStyle(style, styleFlag);

        //    ////Add grey style
        //    //Range range = ws.Cells.CreateRange("A5", "A100");
        //    //style.Font.Color = System.Drawing.Color.LightGray;
        //    //styleFlag.Font = true;
        //    //range.ApplyStyle(style, styleFlag);

        //    //Reset
        //    style.Font.Color = System.Drawing.Color.Black;
        //    styleFlag.Font = false;

        //    //Improve clarity of day/time columns
        //    cellCursor = ws.Cells[2, 1];
        //    cellCursor.PutValue("START DAY");

        //    cellCursor = ws.Cells[2, 2];
        //    cellCursor.PutValue("START TIME");

        //    //Format numbers/averages
        //    style.Number = 4;
        //    style.Font.IsBold = false;
        //    styleFlag.NumberFormat = true;
        //    column = ws.Cells.Columns[4];
        //    column.ApplyStyle(style, styleFlag);

        //    //Bold column headers...do this formatting last, because
        //    // number formatting the averages last wipes out bold on
        //    // column header
        //    style.Font.IsBold = true;
        //    styleFlag.FontBold = true;

        //    Row row = ws.Cells.Rows[2];
        //    row.ApplyStyle(style, styleFlag);

        //    //TAG
        //    ws.Cells.SetColumnWidth(0, 60);
        //    //DAY
        //    ws.Cells.SetColumnWidth(1, 15);
        //    //HOUR
        //    ws.Cells.SetColumnWidth(2, 15);
        //    //STOP
        //    ws.Cells.HideColumn(3);
        //    //AVERAGE
        //    ws.Cells.SetColumnWidth(4, 15);
        //    //NOTES
        //    ws.Cells.SetColumnWidth(5, 15);
        //}
    }
}