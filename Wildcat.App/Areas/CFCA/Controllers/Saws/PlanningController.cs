using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using Wildcat.App.ViewModels.Planning;
using Wildcat.Entities.CFCA.Saws;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.Planning
{
    //TODO renamespace
    //TODO uses oracle odbc
    [Area("CFCA")]
    public class PlanningController : Controller
    {
        private PlanningModel _plm = null;

        public PlanningController()
        {
        }

        public ActionResult JobDetailPartial(string loc, string son)
        {
            _plm = new PlanningModel();
            _plm.LocationCode = loc;
            _plm.DiscreteJobNumber = son;
            _plm.PopulatePlanHeader();

            _plm.PopulateSearchCriteria();

            HttpContext.Session.SetString("MaterialCriteria", JsonConvert.SerializeObject(_plm.MaterialCriteria));
            HttpContext.Session.SetString("MultCriteria", JsonConvert.SerializeObject(_plm.MultCriteria));

            return PartialView(MethodBase.GetCurrentMethod().Name, _plm);
        }

        public ActionResult MaterialCodePartial(string loc, string son)
        {
            if (_plm == null)
                _plm = new PlanningModel();

            _plm.LocationCode = loc;
            _plm.DiscreteJobNumber = son;

            string str = HttpContext.Session.GetString("MaterialCriteria");

            if (!string.IsNullOrEmpty(str))
                _plm.MaterialCriteria = JsonConvert.DeserializeObject<List<SearchMaterialCriteria>>(str);

            str = HttpContext.Session.GetString("MultCriteria");

            if (!string.IsNullOrEmpty(str))
                _plm.MultCriteria = JsonConvert.DeserializeObject<List<SearchMultCriteria>>(str);

            _plm.PopulateDropDownChoices();

            return PartialView(MethodBase.GetCurrentMethod().Name, _plm);
        }

        public IActionResult PlanningPrintCuttingTicket(string loc, string son)
        {
            _plm = new PlanningModel(loc, son);
            _plm.PopulatePlanHeader();
            _plm.PopulateCuttingTicketRecords();

            return View(_plm);
        }

        public IActionResult Index()
        {
            _plm = new PlanningModel();

            string loc = "CFCA";

            //TEMP HARDCODE FOR DEV
            string son = "590679116";

            _plm = new PlanningModel(loc, son);
            _plm.PopulatePlanHeader();

            if (_plm.TestCategoryOptions == null)
            {
                _plm.PopulateSearchCriteria();
                _plm.PopulateDropDownChoices();

                HttpContext.Session.SetString("MaterialCriteria", JsonConvert.SerializeObject(_plm.MaterialCriteria));
                HttpContext.Session.SetString("MultCriteria", JsonConvert.SerializeObject(_plm.MultCriteria));
            }

            _plm.PopulateInventoryRecords();

            return View(_plm);
        }

        public IActionResult Inhdex(string id)
        {
            string loc = "CFCA";
            string son = id;

            if (string.IsNullOrEmpty(son))
            {
                //TEMP HARDCODE FOR DEV
                son = "590679116";
            }

            _plm = new PlanningModel(loc, son);
            _plm.PopulatePlanHeader();

            if (_plm.TestCategoryOptions == null)
            {
                _plm.PopulateSearchCriteria();
                _plm.PopulateDropDownChoices();

                HttpContext.Session.SetString("MaterialCriteria", JsonConvert.SerializeObject(_plm.MaterialCriteria));
                HttpContext.Session.SetString("MultCriteria", JsonConvert.SerializeObject(_plm.MultCriteria));
            }

            _plm.PopulateInventoryRecords();

            return View(_plm);
        }

        public IActionResult Inhdex(PlanningModel plm)
        {
            _plm = plm;

            if (string.IsNullOrEmpty(plm.PlanHeader.WipEntityName))
            {
                string loc = "CFCA";
                //TEMP HARDCODE FOR DEV
                string son = "590679116";

                _plm = new PlanningModel(loc, son);
                _plm.PopulatePlanHeader();
            }

            if (_plm.TestCategoryOptions == null)
            {
                _plm.PopulateSearchCriteria();
                _plm.PopulateDropDownChoices();

                HttpContext.Session.SetString("MaterialCriteria", JsonConvert.SerializeObject(_plm.MaterialCriteria));
                HttpContext.Session.SetString("MultCriteria", JsonConvert.SerializeObject(_plm.MultCriteria));
            }

            _plm.PopulateInventoryRecords();

            return View(_plm);
        }

        public JsonResult GetBarDistribution(string loc, string son)
        {
            if (_plm == null)
                _plm = new PlanningModel();

            return Json(_plm.GetBarDistributionData(loc, son));
        }

        public ActionResult Search(PlanningModel plm)
        {
            _plm = plm;

            string str = HttpContext.Session.GetString("MaterialCriteria");

            if (!string.IsNullOrEmpty(str))
                _plm.MaterialCriteria = JsonConvert.DeserializeObject<List<SearchMaterialCriteria>>(str);

            str = HttpContext.Session.GetString("MultCriteria");

            if (!string.IsNullOrEmpty(str))
                _plm.MultCriteria = JsonConvert.DeserializeObject<List<SearchMultCriteria>>(str);

            _plm.PopulateInventoryRecords();

            return PartialView("SearchResultPartial", _plm);
        }

        [HttpPost]
        public JsonResult RemoveTable1Record(string RowID)
        {
            int ID = 0;

            if (string.IsNullOrEmpty(RowID))
                return Json(new { success = false });

            ID = Convert.ToInt32(RowID);

            _plm = new PlanningModel();

            SearchMaterialCriteria smc = null;

            try
            {
                string str = HttpContext.Session.GetString("MaterialCriteria");

                if (string.IsNullOrEmpty(str))
                    return Json(new { success = false });

                _plm.MaterialCriteria = JsonConvert.DeserializeObject<List<SearchMaterialCriteria>>(str);

                smc = _plm.MaterialCriteria.Where(x => x.RawMaterialID.Equals(ID)).FirstOrDefault();

                if (smc != null)
                {
                    _plm.MaterialCriteria.Remove(smc);
                }

                int newRecordCount = _plm.MaterialCriteria.Count;

                for (int i = 1; i <= newRecordCount; i++)
                {
                    _plm.MaterialCriteria[i].RawMaterialID = i;
                }

                HttpContext.Session.SetString("MaterialCriteria", JsonConvert.SerializeObject(_plm.MaterialCriteria));
            }
            catch (Exception exc)
            {
                //TODO Use Logging
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult SaveTable1Record(string SerializedData)
        {
            int ID = 0;

            RowData row = (RowData)JsonConvert.DeserializeObject(SerializedData, typeof(RowData));
            bool isNewRecord = string.IsNullOrEmpty(row.Field00);

            if (row.Field00 == "0")
                isNewRecord = true;

            _plm = new PlanningModel();

            SearchMaterialCriteria smc = null;

            try
            {
                string str = HttpContext.Session.GetString("MaterialCriteria");

                if (string.IsNullOrEmpty(str))
                    return Json(new { success = false });

                _plm.MaterialCriteria = JsonConvert.DeserializeObject<List<SearchMaterialCriteria>>(str);

                if (!isNewRecord)
                {
                    ID = Convert.ToInt32(row.Field00);
                    smc = _plm.MaterialCriteria.Where(x => x.RawMaterialID.Equals(ID)).FirstOrDefault();

                    if (smc == null)
                        smc = new SearchMaterialCriteria();
                }
                else
                {
                    smc = new SearchMaterialCriteria();
                }

                smc.Material = row.Field01;

                smc.Shape = row.Field02;

                smc.Size = Convert.ToInt32(row.Field03);

                smc.Specifications = row.Field04;

                if (isNewRecord)
                    _plm.MaterialCriteria.Add(smc);

                int newRecordCount = _plm.MaterialCriteria.Count;

                for (int i = 1; i <= newRecordCount; i++)
                {
                    _plm.MaterialCriteria[i - 1].RawMaterialID = i;
                }

                ID = newRecordCount;

                HttpContext.Session.SetString("MaterialCriteria", JsonConvert.SerializeObject(_plm.MaterialCriteria));
            }
            catch (Exception exc)
            {
                //TODO Use Logging
            }

            return Json(data: ID);
        }

        [HttpPost]
        public JsonResult RemoveTable2Record(string RowID)
        {
            int ID = 0;

            if (string.IsNullOrEmpty(RowID))
                return Json(new { success = false });

            ID = Convert.ToInt32(RowID);

            _plm = new PlanningModel();

            SearchMultCriteria smc = null;

            try
            {
                string str = HttpContext.Session.GetString("MultCriteria");

                if (string.IsNullOrEmpty(str))
                    return Json(new { success = false });

                _plm.MultCriteria = JsonConvert.DeserializeObject<List<SearchMultCriteria>>(str);

                smc = _plm.MultCriteria.Where(x => x.MultID.Equals(ID)).FirstOrDefault();

                if (smc != null)
                {
                    _plm.MultCriteria.Remove(smc);
                }

                int newRecordCount = _plm.MultCriteria.Count;

                for (int i = 1; i <= newRecordCount; i++)
                {
                    _plm.MultCriteria[i].MultID = i;
                }

                HttpContext.Session.SetString("MultCriteria", JsonConvert.SerializeObject(_plm.MultCriteria));
            }
            catch (Exception exc)
            {
                //TODO Use Logging
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult SaveTable2Record(string SerializedData)
        {
            int ID = 0;

            RowData row = (RowData)JsonConvert.DeserializeObject(SerializedData, typeof(RowData));
            bool isNewRecord = string.IsNullOrEmpty(row.Field00);

            if (row.Field00 == "0")
                isNewRecord = true;

            _plm = new PlanningModel();

            SearchMultCriteria smc = null;

            try
            {
                string str = HttpContext.Session.GetString("MultCriteria");

                if (string.IsNullOrEmpty(str))
                    return Json(new { success = false });

                _plm.MultCriteria = JsonConvert.DeserializeObject<List<SearchMultCriteria>>(str);

                if (!isNewRecord)
                {
                    ID = Convert.ToInt32(row.Field00);
                    smc = _plm.MultCriteria.Where(x => x.MultID.Equals(ID)).FirstOrDefault();

                    if (smc == null)
                        smc = new SearchMultCriteria();
                }
                else
                {
                    smc = new SearchMultCriteria();
                }

                smc.MultCount = Conversion.SafeInteger(row.Field01);
                smc.CutWeight = Conversion.SafeDecimal(row.Field02);
                smc.GrossWeight = Conversion.SafeDecimal(row.Field03);
                smc.OneEquals = Conversion.SafeInteger(row.Field04);

                smc.Test = (row.Field05 == "true");

                if (isNewRecord)
                    _plm.MultCriteria.Add(smc);

                int newRecordCount = _plm.MultCriteria.Count;

                for (int i = 1; i <= newRecordCount; i++)
                {
                    _plm.MultCriteria[i - 1].MultID = i;
                }

                ID = newRecordCount;

                HttpContext.Session.SetString("MultCriteria", JsonConvert.SerializeObject(_plm.MultCriteria));
            }
            catch (Exception exc)
            {
                //TODO Use Logging
            }

            return Json(data: ID);
        }

        [HttpPost]
        public JsonResult SaveTable4Record(string SerializedData)
        {
            int ID = 0;

            RowData row = (RowData)JsonConvert.DeserializeObject(SerializedData, typeof(RowData));
            bool isNewRecord = string.IsNullOrEmpty(row.Field00);

            try
            {
                SawCalcInventoryBillets blt = null;

                using (SawCalcContext scc = new SawCalcContext())
                {
                    if (!isNewRecord)
                    {
                        ID = Convert.ToInt32(row.Field00);
                        blt = scc.SawCalcInventoryBillets.Where(x => x.InventoryBilletId.Equals(ID)).FirstOrDefault();

                        if (blt == null)
                            blt = new SawCalcInventoryBillets();
                    }
                    else
                    {
                        blt = new SawCalcInventoryBillets();
                    }

                    blt.HeatNumber = row.Field01.Split('_')[0];
                    blt.BilletNumber = row.Field01.Split('_')[1];
                    blt.DateReceived = Convert.ToDateTime(row.Field04);

                    blt.OriginalWeight = Convert.ToDouble(row.Field07);

                    if (!isNewRecord)
                    {
                        scc.SawCalcInventoryBillets.Attach(blt);
                        scc.Entry(blt).State = EntityState.Modified;
                    }
                    else
                    {
                        scc.SawCalcInventoryBillets.Add(blt);
                        scc.Entry(blt).State = EntityState.Added;
                    }

                    scc.SaveChanges();

                    ID = blt.InventoryBilletId;
                }
            }
            catch (Exception exc)
            {
                //TODO Logging
            }

            return Json(data: ID);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}