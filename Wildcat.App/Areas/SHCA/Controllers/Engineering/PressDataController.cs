
using Aspose.Cells;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading;
using Wildcat.App.ViewModels.Engineering;

namespace Wildcat.App.Controllers.Engineering
{
    public class PressDataController : Controller
    {
        private License _license = new License();
        private PressData _pressData = new PressData();

        public PressDataController()
        {

        }

        [HttpGet]
        public ActionResult Index()
        {
            _license.SetLicense(Environment.CurrentDirectory + @"\ThirdPartyDLLs\Aspose.Total.lic");

            return View(_pressData);
        }

        [HttpGet]
        public IActionResult Download(PressData pressData)
        {
            _pressData = pressData;

            string exportFileName = _pressData.MakeExportFile();

            while (_pressData.ProcessingDownload)
            {
                Thread.Sleep(1000);
            }

            string exportFilePath = @"C:\temp\";

            FileStream str = System.IO.File.OpenRead(Path.Combine(exportFilePath, exportFileName));
            FileStreamResult fsr = new FileStreamResult(str, "application/vnd.ms-excel");
            fsr.FileDownloadName = exportFileName;

            long length = fsr.FileStream.Length;

            var res = Response;

            System.Net.Mime.ContentDisposition ctd = new System.Net.Mime.ContentDisposition
            {
                FileName = fsr.FileDownloadName,
                Inline = false
            };

            res.Headers.Add("Content-Disposition", ctd.ToString());
            res.Headers.Add("Content-Length", length.ToString());

            return fsr;
        }
    }
}