using Aspose.Cells;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Wildcat.App.ViewModels.Engineering;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.SHCA.Engineering.GasMeters;

namespace Wildcat.App.Controllers.Engineering
{
    [Area("SHCA")]
    public class GasMeterController : Controller
    {
        private Gas _gas = null;
        private License _license = null;
        private static GasMeterManager _gasMeterManager = null;

        //private GasMeterManager _gasMeterManager;

        //[HttpGet]
        //public IActionResult Viewer()
        //{
        //    _gas = new Gas();

        //    return View(_gas);
        //}

        [HttpGet]
        public IActionResult Reader()
        {
            _license = new License();
            _license.SetLicense(Environment.CurrentDirectory + @"\ThirdPartyDLLs\Aspose.Total.lic");

            _gas = new Gas();

            return View(_gas);
        }

        [HttpPost]
        public IActionResult ExecuteLogRequest(Gas gas)
        {
            string feedback = "Success";

            try
            {
                _gas = gas;

                if (_gas.MeterManager == null)
                    _gas.MeterManager = new GasMeterManager();

                _gas.ExecuteLogRequest();

                _gasMeterManager = _gas.MeterManager;
            }
            catch (Exception exc)
            {
                feedback = exc.InnerException.ToString();
            }

            return Json(new { feedback });
        }

        [HttpGet]
        public IActionResult UpdateProgress(Gas gas)
        {
            _gas = gas;

            _gas.MeterManager = _gasMeterManager;

            //Reset
            _gas.MinimumCompleteness = 100f;

            if (_gas.SelectedFurnaceOption != "ALL")
                _gas.GasMeters = _gas.GasMeters.Where(x => x.MeterName.Equals(_gas.SelectedFurnaceOption)).OrderBy(x => x.MeterName).ToList();

            SocketWithName swn = null;

            foreach (GasMeter gmt in _gas.GasMeters)
            {
                swn = _gas.MeterManager.SocketsList.Where(x => x.meterName.Equals(gmt.MeterName)).FirstOrDefault();

                gmt.PercentComplete = swn.meterReadItem.Progress;

                gmt.Message = swn.meterReadItem.Message;

                if (gmt.Message == "message")
                    gmt.Message = "Initializing";

                if (gmt.PercentComplete > 100f)
                    gmt.PercentComplete = 100f;

                gmt.PercentIncomplete = 100 - gmt.PercentComplete;

                if (gmt.PercentComplete < _gas.MinimumCompleteness)
                    _gas.MinimumCompleteness = gmt.PercentComplete;
            }

            if (_gas.MinimumCompleteness >= 100f)
                _gasMeterManager = null;

            return PartialView("ProgressPartial", _gas);
        }

        [HttpGet]
        public IActionResult Download(Gas gas)
        {
            _gas = gas;

            FileStreamResult fsr = _gas.ReadSpreadsheet();

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