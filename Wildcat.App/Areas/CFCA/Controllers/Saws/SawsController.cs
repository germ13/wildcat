
using System;
using Newtonsoft.Json;
using System.Reflection;
using Wildcat.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Wildcat.App.ViewModels.Saws;
//using Microsoft.AspNetCore.HttpOverrides;

namespace Wildcat.App.Controllers.Saws
{
    //TODO renamespace
    [Area("CFCA")]
    public class SawsController : Controller
    {
        private SawModel _saw = null;
        private MultModel _mult = null;

        public SawsController()
        {

        }

        public IActionResult Index(string id)
        {
            string loc = "CFCA";

            if (id == null)
            {
                _saw = GetPopulatedModel(loc, id);
                _saw.PopulateDropDownChoices();

                return View(_saw);
            }

            if (_saw == null)
            {
                _saw = GetPopulatedModel(loc, id);
                _saw.PopulateDropDownChoices();
            }

            _saw.RefreshRightPanelStats();

            HttpContext.Session.SetString("saw",
                JsonConvert.SerializeObject(
                    _saw,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    })
            );

            HttpContext.Session.SetString("lpm",
                JsonConvert.SerializeObject(
                    _saw.LengthParameters,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    })
            );

            return View(_saw);
        }

        //This fetches the normal center2 view after user leaves piece details
        [HttpGet]
        public ActionResult SawPanelCenter2Partial(string loc, string son)
        {
            _saw = GetPopulatedModel(loc, son);
            _saw.AddPieceResults();

            string str = HttpContext.Session.GetString("saw");

            if (str != null && str != "null")
                _saw = JsonConvert.DeserializeObject<SawModel>(str);

            return PartialView(MethodBase.GetCurrentMethod().Name, _saw);
        }

        //Hit this after user edits piece and clicks Save
        public ActionResult SawPanelPostEditCenterPartial(MultModel mult)
        {
            _mult = mult;

            _mult.Piece.LastModifiedBy = HttpContext.User.Identity.Name;
            _mult.SavePossibleEdits();

            _saw.GetPopulatedModel(_mult.LocationCode, _mult.Piece.ShopOrderId);
            _saw.AddPieceResults();

            return PartialView("SawPanelCenter2Partial", _saw);
        }

        //Send user to confirm-delete; model is populated because some details are shown to them
        public ActionResult SawPanelDeleteMultPartial(string pid)
        {
            _mult = new MultModel(Convert.ToInt32(pid));

            return PartialView(MethodBase.GetCurrentMethod().Name, _mult);
        }

        //Hit this GET when they confirmed they want to (soft) delete a Piece
        public ActionResult SawPanelConfirmedDeleteMultPartial(string pid)
        {
            if (_mult == null)
                _mult = new MultModel(Convert.ToInt32(pid));

            _mult.Piece.LastModifiedBy = HttpContext.User.Identity.Name;
            _mult.DeletePiece(Conversion.SafeInteger(pid));

            return PartialView("SawPanelCenter2Partial", _saw);
        }

        //Main GET when piece detail is requested
        public ActionResult SawPanelEditMultPartial(string pid)
        {
            _mult = new MultModel(Convert.ToInt32(pid));

            return PartialView(MethodBase.GetCurrentMethod().Name, _mult);
        }        

        //public ActionResult SawPanelCenter2Partial(SawModel saw)
        //{
        //    return PartialView(MethodBase.GetCurrentMethod().Name, saw);
        //}

        public ActionResult SawPanelCenter1Partial(SawModel saw)
        {
            string son = saw.DiscreteJobSelected;

            LengthParameterModel lpm = null;

            string str = HttpContext.Session.GetString("lpm");

            if (str != null && str != "null")
            {
                lpm = JsonConvert.DeserializeObject<LengthParameterModel>(str);
            }
            else
            {
                lpm = new LengthParameterModel();
                lpm.LocationCode = saw.LocationCode;
                lpm.ShopOrderNumber = saw.DiscreteJobSelected;
                //Fetching values here might wipe out recent inputs the user made.
                //saw.LengthParameters.PopulateDimensions(saw.ShopOrder.ShopOrderId);
            }

            saw.LengthParameters.Density = lpm.Density;
            saw.LengthParameters.TargetWeightSelected = lpm.TargetWeightSelected.Trim();
            saw.LengthParameters.UpdateCalculatedTargetLength();

            if (saw.CrookedEndAdjustment == null)
                saw.CrookedEndAdjustment = 0;

            saw.AdjustedTargetLength = (saw.LengthParameters.CalculatedTargetLength + saw.CrookedEndAdjustment) * saw.DensityCorrection;

            HttpContext.Session.SetString("lpm",
                JsonConvert.SerializeObject(
                    saw.LengthParameters,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    })
            );

            saw.AddUnfinishedSerialNumberOptions();
            saw.AddPieceResults();

            if (!string.IsNullOrEmpty(saw.PieceTypeString))
            {
                //THIS RE POPULATION IS NECESSARY BECAUSE RAJEEV RE-SAVES A
                // TON OF REDUNDANT DATA ABOVE AND BEYOND THE PIECE WEIGHT;
                // AFTER THE INITIAL TEST PHASE, RE-DO HIS SCHEMA SO IT
                // MAKES MORE SENSE
                saw.SaveNewWeight(Environment.UserName, Environment.MachineName);

                //RESET THIS BECAUSE AFTER USING IT TO SAVE, WE DONT
                // WANT TO PERSIST THE WEIGHT TYPE.  WEIGHT TYPE RECORDED IS DYNAMIC
                // AND DEPENDS ON THE BUTTON BEING CLICKED AT THE MOMENT
                saw.PieceTypeString = string.Empty;
            }

            return PartialView(MethodBase.GetCurrentMethod().Name, saw);
        }

        public ActionResult SawPanelRightPartial(string loc, string son)
        {
            string str = HttpContext.Session.GetString("saw");

            if(str != null && str != "null")
                _saw = JsonConvert.DeserializeObject<SawModel>(str);

            str = HttpContext.Session.GetString("lpm");

            if (str != null && str != "null")
            {
                _saw.LengthParameters = JsonConvert.DeserializeObject<LengthParameterModel>(str);
            }

            _saw.RefreshRightPanelStats();

            return PartialView(MethodBase.GetCurrentMethod().Name, _saw);
        }

        public IActionResult SawPrintMultChart(string loc, string son)
        {
            if (loc == null)
                loc = "CFCA";

            SawPieceModel spm = new SawPieceModel(loc, son);

            spm.LoadData(false);

            return View(spm);
        }

        public IActionResult SawPrintSerialChecklist(string loc, string son)
        {
            if (loc == null)
                loc = "CFCA";

            SawPieceModel spm = new SawPieceModel(loc, son);

            spm.LoadData(true);

            spm.PopulateSerialNumbers();

            return View(spm);
        }

        public IActionResult SawPrintSerialMarking(string loc, string son)
        {
            if (loc == null)
                loc = "CFCA";

            SawSerialNumberModel ssn = new SawSerialNumberModel(loc, son);

            ssn.LoadData(false);

            ssn.PopulateSerialNumbers();

            return View(ssn);
        }

        //We may come here if the person clicked save, but also if he entered
        // a job number and simply clicked return on the keyboard.  In the later
        // case, a default button named Load is associated with the post even
        // though it's not visible or clicked.
        [HttpPost]
        public ActionResult SawPanelLeftPartial(SawModel saw, string command)
        {
            if (command == "Save")
            {
                _saw = saw;

                string pcName = Environment.MachineName;

                _saw.SaveState(pcName);
            }

            return Json(new { success = true });
        }

        private SawModel GetPopulatedModel(string loc, string son)
        {
            if (loc == null)
                loc = "CFCA";

            _saw = new SawModel(loc, son);

            if (son == null)
                _saw.PopulateEmptyModel();
            else
                _saw.PopulateModel(loc, son);

            return _saw;
        }

        public JsonResult GetScatterData(string loc, string son)
        {
            if (_saw == null)
                _saw = new SawModel(loc, son);

            return Json(_saw.GetScatterData(loc, son));
        }

        public JsonResult GetScatterMarkers(string loc, string son)
        {
            if (_saw == null)
                _saw = new SawModel(loc, son);

            return Json(_saw.GetScatterMarkers(loc, son));
        }        

        public JsonResult GetBarDistribution(string loc, string son)
        {
            return Json(_saw.GetBarDistributionData(loc, son));
        }

        [HttpPost]
        public ActionResult CallMaintenance(string loc, string son, string bld, string msg)
        {
            string rtv = string.Empty;

            SawModel saw = new SawModel();

            string machineIp = HttpContext.Connection.RemoteIpAddress.ToString();

            rtv = saw.ExecuteMaintenanceRequest(loc, son, HttpContext.User.Identity.Name, machineIp, bld, msg);

            return Json(new { retval = rtv });
        }

        [HttpPost]
        public ActionResult SubmitMultChart(string loc, string son)
        {
            string rtv = string.Empty;

            SawModel saw = new SawModel();
            
            rtv = saw.SubmitMultChart(loc, son, HttpContext.User.Identity.Name);

            return Json(new { retval = rtv });
        }
    }
}