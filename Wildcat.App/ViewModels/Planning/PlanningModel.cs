using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using Wildcat.Entities.CFCA.Planning;
using Wildcat.Entities.CFCA.Saws;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.Planning
{
    public class PlanningModel
    {
        #region Properties

        public string LocationCode { get; set; }

        public string DiscreteJobNumber { get; set; }

        public CfwAccuPlanHeader PlanHeader { get; set; }
        public List<CfwAccuSn> SerialNumbers { get; set; }

        public List<CfwAccuBarDistro> BarDistroRecords { get; set; }

        public List<CfwAccuCutTicket> CuttingTicketRecords { get; set; }
        public List<CfwAccuInventory> InventoryRecords { get; set; }

        public SawCalcMaterials Material { get; set; }

        public List<BarShape> Shapes { get; }

        public string ShapeSelected { get; set; }

        public bool SearchUnusableBillets { get; set; }

        public List<SelectListItem> TestCategoryOptions { get; set; }
        public string TestCategorySelected { get; set; }

        public List<SelectListItem> UnitTypeOptions { get; set; }
        public string UnitTypeSelected { get; set; }

        public List<SelectListItem> BarShapeOptions { get; set; }
        public string BarShapeSelected { get; set; }

        public List<SelectListItem> MetalOptions { get; set; }
        public string MetalSelected { get; set; }

        //public List<SelectListItem> SortOptions { get; set; }
        //public string SortSelected { get; set; }

        public string SerialNumberString { get; set; }
        public string WeightString { get; set; }

        public string OtherString { get; set; }

        public List<SearchMaterialCriteria> MaterialCriteria { get; set; }

        public List<SearchMultCriteria> MultCriteria { get; set; }

        public double? MinimumSize { get; set; }
        public double? MaximumSize { get; set; }
        public string Specification { get; set; }
        //public string CuttingTicketUrl { get; set; }

        #endregion Properties

        public PlanningModel(string loc, string son)
        {
            LocationCode = loc;
            DiscreteJobNumber = son;
        }

        public void PopulateLeanPlanHeader()
        {
            using (ModelContext mct = new ModelContext())
            {
                PlanHeader = mct.CfwAccuPlanHeader.Where(x => x.WipEntityName.Equals(DiscreteJobNumber)).FirstOrDefault();
            }
        }

        public void PopulatePlanHeader()
        {
            using (ModelContext mct = new ModelContext())
            {
                int entityID = mct.WipEntitiesShell.Where(x => x.WipEntityName.Equals(DiscreteJobNumber) && x.OrganizationId == 182).FirstOrDefault().WipEntityId;
                PlanHeader = mct.CfwAccuPlanHeader.Where(x => x.WipEntityId.Equals(entityID)).FirstOrDefault();
                SerialNumbers = mct.CfwAccuSn.Where(x => x.WipEntityId.Equals(entityID)).ToList().OrderBy(x => x.CustomerSerialNumber).ToList();
            }

            if (PlanHeader.EngineProgram != null)
                PlanHeader.EngineProgram = string.Format("Engine Program: {0}", PlanHeader.EngineProgram);

            StringBuilder sb = new StringBuilder();

            foreach (CfwAccuSn sn in SerialNumbers)
            {
                if (sb.Length > 0)
                    sb.Append(", ");

                sb.Append(sn.CustomerSerialNumber);
            }

            SerialNumberString = sb.ToString();

            PopulateWeightString();
            PopulateOtherString();

            InventoryRecords = new List<CfwAccuInventory>();
        }

        public void PopulateInventoryRecords()
        {
            InventoryRecords = new List<CfwAccuInventory>();

            if (MaterialCriteria == null || MaterialCriteria.Count == 0)
                PopulateSearchCriteria();

            string rmPartNumber = MaterialCriteria[0].RawMaterialCode;

            using (ModelContext mct = new ModelContext())
            {
                InventoryRecords = mct.CfwAccuInventory.Where(x => x.RmItemNumber.Equals(rmPartNumber)).ToList();
            }

            //Table has built in sort
            //switch(SortSelected)
            //{
            //    case "Total Wt":
            //        InventoryRecords = InventoryRecords.OrderBy(x => x.TransactionQuantity).ToList();
            //        break;
            //    case "Rem Wt":
            //        InventoryRecords = InventoryRecords.OrderBy(x => x.TransactionQuantity).ToList();
            //        break;
            //    case "Mult Wt":
            //        InventoryRecords = InventoryRecords.OrderBy(x => x.TransactionQuantity).ToList();
            //        break;
            //    case "Received":
            //        InventoryRecords = InventoryRecords.OrderBy(x => x.DateReceived).ToList();
            //        break;
            //    case "Description":
            //        InventoryRecords = InventoryRecords.OrderBy(x => x.DateReceived).ToList();
            //        break;
            //    case "Lot":
            //    default:
            //        InventoryRecords = InventoryRecords.OrderBy(x=>x.LotNumber).ToList();
            //        break;
            //}
        }

        public void PopulateCuttingTicketRecords()
        {
            if (PlanHeader == null)
                return;

            using (ModelContext mct = new ModelContext())
            {
                CuttingTicketRecords = mct.CfwAccuCutTicket.Where(x => x.WipEntityId.Equals(PlanHeader.WipEntityId)).ToList();
            }
        }

        public List<object[]> GetBarDistributionData(string loc, string son)
        {
            List<object[]> rtv = new List<object[]>();

            object[] obj = null;

            if (PlanHeader == null)
                return rtv;

            using (ModelContext mct = new ModelContext())
            {
                var wipEntitiesShell = mct.WipEntitiesShell.Where(x => x.WipEntityName.Equals(son) && x.OrganizationId == 182).FirstOrDefault();
                BarDistroRecords = mct.CfwAccuBarDistro.Where(x => x.WipEntityId.Equals(wipEntitiesShell.WipEntityId)).ToList();
            }

            int multCounter = 0;

            foreach (CfwAccuBarDistro bdr in BarDistroRecords)
            {
                if (Conversion.SafeInteger(bdr.MultCount) <= multCounter)
                    break;

                obj = new object[4];

                if (bdr.BarIngotNumber == null)
                    bdr.BarIngotNumber = "NA";

                obj[0] = bdr.BarIngotNumber.Replace('-', '_').Replace('.', '_');

                string multNumberWithLeadingZero = (multCounter + 1).ToString();
                multNumberWithLeadingZero = "MULT" + multNumberWithLeadingZero.PadLeft(2, '0');
                obj[1] = multNumberWithLeadingZero; // bdr.TableKey.ToString(); // bdr.JobNumber;

                obj[2] = Conversion.SafeDecimal(bdr.GrossWeight);
                obj[3] = Conversion.SafeDecimal(bdr.GrossWeight);

                rtv.Add(obj);

                multCounter++;
            }

            return rtv;
        }

        #region Constructors

        public PlanningModel()
        {
            //TEMP HARDCODE
            LocationCode = "CFCA";
            DiscreteJobNumber = string.Empty;

            PlanHeader = new CfwAccuPlanHeader();

            Material = new SawCalcMaterials();
            MultCriteria = new List<SearchMultCriteria>();
            MaterialCriteria = new List<SearchMaterialCriteria>();
            InventoryRecords = new List<CfwAccuInventory>();
        }

        public void PopulateSearchCriteria()
        {
            if (PlanHeader == null)
                return;

            //By default, the app currently does not propose any starter records for
            // this grid, however
            MaterialCriteria = new List<SearchMaterialCriteria>();
            SearchMaterialCriteria smt = new SearchMaterialCriteria();

            smt.RawMaterialID = 1;
            smt.RawMaterialCode = PlanHeader.MaterialCode;
            smt.Material = PlanHeader.Material1;
            smt.Shape = PlanHeader.Stockshape;
            smt.Size = Conversion.SafeDecimal(PlanHeader.Stocksize1);

            CfwAccuInventory cai = null;
            List<CfwAccuMultCount> mults = null;

            using (ModelContext mct = new ModelContext())
            {
                if (InventoryRecords == null || InventoryRecords.Count == 0)
                {
                    cai = mct.CfwAccuInventory.Where(x => x.RmItemNumber.Equals(PlanHeader.MaterialCode)).FirstOrDefault();
                    mults = mct.CfwAccuMultCount.Where(x => x.WipEntityId.Equals(PlanHeader.WipEntityId)).ToList();
                }
                else
                {
                    cai = InventoryRecords.FirstOrDefault();
                }
            }
            //Curb the length because UI (table) has limited space
            if (cai != null)
            {
                smt.Specifications = string.Format("{0} {1}", cai.MetalSpec1, cai.MetalSpec2);

                if (smt.Specifications.Length > 50)
                    smt.Specifications = smt.Specifications.Substring(0, 50);
            }

            MaterialCriteria.Add(smt);

            MultCriteria = new List<SearchMultCriteria>();
            SearchMultCriteria smc = null;

            int recordCounter = 0;

            foreach (CfwAccuMultCount mult in mults)
            {
                recordCounter++;

                smc = new SearchMultCriteria();

                smc.MultID = recordCounter;
                smc.MultCount = Conversion.SafeInteger(mult.MultCount);
                smc.CutWeight = Conversion.SafeDecimal(mult.CutWeight);
                smc.GrossWeight = Conversion.SafeDecimal(mult.GrossWeight);
                smc.OneEquals = Conversion.SafeInteger(mult.OneEquals);
                smc.Test = false;

                MultCriteria.Add(smc);
            }
        }

        //public void PopulateShopOrder(string son)
        //{
        //    if (son == null || son.Length == 0)
        //        return;

        // this.DiscreteJobNumber = son;

        //    using (SawCalcContext scc = new SawCalcContext())
        //    {
        //        ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();
        //    }
        //}

        public void PopulateOtherString()
        {
            if (PlanHeader == null)
                PopulateLeanPlanHeader();

            StringBuilder sb = new StringBuilder();

            sb.Append("Total Wt: ");
            sb.Append(PlanHeader.Totalweight);
            sb.Append(", ");
            sb.Append("Status: ");
            sb.Append(PlanHeader.JobStatus);
            sb.Append(", ");
            sb.Append("Cut  Quantity: ");
            sb.Append(PlanHeader.Primarymultcount);
            sb.Append(", ");
            sb.Append("Ship Quantity: ");
            sb.Append(PlanHeader.LotSize);
            sb.Append(", ");
            sb.Append("Gross Wt: ");
            sb.Append(PlanHeader.Primarygrossweight);

            OtherString = sb.ToString();
        }

        public void PopulateWeightString()
        {
            if (PlanHeader == null)
                PopulateLeanPlanHeader();

            StringBuilder sb = new StringBuilder();

            if (PlanHeader.LotSize != null)
            {
                sb.Append(PlanHeader.LotSize);
                sb.Append(", ");
            }

            if (PlanHeader.RmSize != null)
            {
                sb.Append(PlanHeader.RmSize);
                sb.Append("\" ");
                sb.Append(" ");
            }

            if (PlanHeader.Stockshape != null)
            {
                sb.Append(PlanHeader.Stockshape);
                sb.Append(" ");
            }

            sb.Append(PlanHeader.Primarymultweight);
            sb.Append(" lbs");

            WeightString = sb.ToString();
        }

        public void PopulateDropDownChoices()
        {
            TestCategoryOptions = new List<SelectListItem>();
            UnitTypeOptions = new List<SelectListItem>();
            MetalOptions = new List<SelectListItem>();
            BarShapeOptions = new List<SelectListItem>();
            //SortOptions = new List<SelectListItem>();

            TestCategoryOptions.Add(new SelectListItem { Value = "Non-Destructive", Text = "Non-Destructive" });
            TestCategoryOptions.Add(new SelectListItem { Value = "Prolong", Text = "Prolong" });
            TestCategoryOptions.Add(new SelectListItem { Value = "Destructive Single", Text = "Destructive Single" });
            TestCategoryOptions.Add(new SelectListItem { Value = "Destructive Forging", Text = "Destructive Forging" });

            UnitTypeOptions.Add(new SelectListItem { Value = "Per Job", Text = "Per Job" });
            UnitTypeOptions.Add(new SelectListItem { Value = "Per Heat", Text = "Per Heat" });
            UnitTypeOptions.Add(new SelectListItem { Value = "Per Remelt Ingot", Text = "Per Remelt Ingot" });

            //Table has built in sort
            //SortOptions.Add(new SelectListItem { Value = "Lot", Text = "Lot" });
            //SortOptions.Add(new SelectListItem { Value = "Description", Text = "Description" });
            //SortOptions.Add(new SelectListItem { Value = "Received", Text = "Received" });
            //SortOptions.Add(new SelectListItem { Value = "Total Wt", Text = "Total Wt" });
            //SortOptions.Add(new SelectListItem { Value = "Mult Wt", Text = "Mult Wt" });
            //SortOptions.Add(new SelectListItem { Value = "Rem Wt", Text = "Rem Wt" });

            using (SawCalcContext scc = new SawCalcContext())
            {
                List<SawCalcMaterials> metals = scc.SawCalcMaterials.OrderBy(x => x.MaterialName).ToList();

                foreach (SawCalcMaterials metal in metals)
                {
                    metal.MaterialName = metal.MaterialName.Replace(" -", "-");
                    metal.MaterialName = metal.MaterialName.Replace("- ", "-");

                    MetalOptions.Add(new SelectListItem { Value = metal.MaterialId.ToString(), Text = metal.MaterialName });
                }
            }

            using (WildcatContext wcc = new WildcatContext())
            {
                List<BarShape> barShapes = wcc.BarShape.ToList();

                foreach (BarShape barShape in barShapes)
                {
                    BarShapeOptions.Add(new SelectListItem { Value = barShape.ShapeCode, Text = barShape.ShapeDescription });
                }
            }

            TestCategorySelected = TestCategoryOptions.FirstOrDefault().Value;
            UnitTypeSelected = UnitTypeOptions.FirstOrDefault().Value;
            //MetalSelected = MetalOptions.FirstOrDefault().Value;
            BarShapeSelected = BarShapeOptions.FirstOrDefault().Value;
        }

        public string GetTotalWeight(double Weight1, double Weight2)
        {
            string rtv = string.Empty;

            double sum = Weight1 + Weight2;

            rtv = string.Format("{0:F1}", sum);

            return rtv;
        }

        public string FormatLotNumber(string HeatNumber, string BilletNumber)
        {
            string rtv = string.Empty;

            rtv = string.Format("{0}_{1}", HeatNumber, BilletNumber);

            return rtv;
        }

        public string GetPortionBarHTML(string ControlID, double FilledPortion, double UnfilledPortion, bool IsPercent)
        {
            string rtv = string.Empty;

            int filledPortion = Conversion.SafeInteger(Math.Round(FilledPortion, 0));
            int unfilledPortion = Conversion.SafeInteger(Math.Round(UnfilledPortion, 0));

            rtv = HtmlBuilder.GetPortionBarHTML(ControlID, filledPortion, unfilledPortion, IsPercent);

            return rtv;
        }

        //BEG GENERIC DDL HELPER
        public HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            TagBuilder button = null;

            string styleOverrideString = string.Empty;

            if (width != null)
            {
                styleOverrideString = string.Format("width: {0}px; text-align: left !important;", width);

                button = new TagBuilder("button")
                {
                    Attributes =
                    {
                            {"style", styleOverrideString },

                        {"id", id},
                        {"type", "button"},
                        {"data-toggle", "dropdown"}
                    }
                };
            }
            else
            {
                styleOverrideString = string.Format("width: 100%; text-align: left !important;", width);

                button = new TagBuilder("button")
                {
                    Attributes =
                    {
                                {"style", styleOverrideString },

                        {"id", id},
                        {"type", "button"},
                        {"data-toggle", "dropdown"}
                    }
                };
            }

            button.AddCssClass("btn");
            button.AddCssClass("btn-default");
            button.AddCssClass("dropdown-toggle");

            if (selectedValue == null)
                button.InnerHtml.AppendHtml(label);
            else
                button.InnerHtml.AppendHtml(selectedValue);

            button.InnerHtml.AppendHtml(" ");
            button.InnerHtml.AppendHtml(BuildCaret());

            var wrapper = new TagBuilder("div");
            wrapper.AddCssClass("dropdown");

            wrapper.InnerHtml.AppendHtml(ConvertTagToString(button));
            wrapper.InnerHtml.AppendHtml(BuildDropdown(id, selectListItems));

            return new HtmlString(ConvertTagToString(wrapper));
        }

        private static string BuildCaret()
        {
            var caret = new TagBuilder("span");
            caret.AddCssClass("caret");

            return ConvertTagToString(caret);
        }

        private static string BuildDropdown(string id, IEnumerable<SelectListItem> items)
        {
            var list = new TagBuilder("ul")
            {
                Attributes =
                {
                    {"class", "dropdown-menu"},
                    {"role", "menu"},
                    {"aria-labelledby", id}
                }
            };

            //var listItem = new TagBuilder("li");
            //listItem.Attributes.Add("role", "presentation");

            foreach (var x in items)
            {
                list.InnerHtml.AppendHtml("<li>");
                list.InnerHtml.AppendHtml(BuildListRow(x));
                list.InnerHtml.AppendHtml("</li>");
            }

            return ConvertTagToString(list);
        }

        private static string BuildListRow(SelectListItem item)
        {
            var anchor = new TagBuilder("a")
            {
                Attributes =
                {
                    {"class", "dropdown-item"},
                    {"id", item.Value},
                    {"href", "javascript:void(0);"}
                }
            };

            anchor.InnerHtml.AppendHtml(item.Text);

            return ConvertTagToString(anchor);
        }

        private static string ConvertTagToString(IHtmlContent tag)
        {
            StringWriter writer = new StringWriter();
            tag.WriteTo(writer, HtmlEncoder.Default);

            return writer.ToString();
        }

        //END GENERIC DDL HELPER

        #endregion Constructors
    }

    [Serializable]
    public class SearchMaterialCriteria
    {
        public int RawMaterialID { get; set; }
        public string RawMaterialCode { get; set; }
        public string Material { get; set; }
        public string Shape { get; set; }
        public decimal Size { get; set; }
        public string Specifications { get; set; }
    }

    [Serializable]
    public class SearchMultCriteria
    {
        public int MultID { get; set; }
        public int MultCount { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}")]
        public decimal CutWeight { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}")]
        public decimal GrossWeight { get; set; }

        public int OneEquals { get; set; }
        public bool Test { get; set; }
    }
}