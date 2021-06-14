using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Wildcat.Entities.CFCA.Saws;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.Saws
{
    public class LengthParameterModel
    {
        private bool _displayEmptyJobUI = true;

        public string LocationCode { get; set; }
        public string ShopOrderNumber { get; set; }
        public double Density { get; set; }
        public List<SelectListItem> TargetWeightOptions { get; set; }
        public string TargetWeightSelected { get; set; }
        public List<SelectListItem> BarShapeOptions { get; set; }
        public string BarShapeSelected { get; set; }

        [DisplayFormat(DataFormatString = "{0:F3}")]
        public double CalculatedTargetLength { get; set; }

        public int ShapeMeasurementId { get; set; }

        public double? Dimension1 { get; set; }
        public double? Dimension2 { get; set; }
        public double? Dimension3 { get; set; }
        public double? Dimension4 { get; set; }
        public double? Dimension5 { get; set; }
        public double? Dimension6 { get; set; }
        public double? Dimension7 { get; set; }
        public double? Dimension8 { get; set; }
        public double? Dimension9 { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public double CrossSectionArea { get; set; }

        public LengthParameterModel()
        {
            TargetWeightOptions = new List<SelectListItem>();
            BarShapeOptions = new List<SelectListItem>();
        }

        public void UpdateCalculatedTargetLength()
        {
            CrossSectionArea = GetCrossSectionArea();

            CalculatedTargetLength = (Conversion.SafeDouble(TargetWeightSelected) / Density) / CrossSectionArea;
        }

        public void PopulateDimensions(SawCalcShopOrderSavedStates state)
        {
            using (SawCalcContext scc = new SawCalcContext())
            {
                switch (state.CrossSectionShape)
                {
                    case "Round":
                        BarShapeSelected = "RND";
                        break;

                    case "Rectangle":
                        BarShapeSelected = "REC";
                        break;

                    case "Rounded rect":
                        BarShapeSelected = "RCS";
                        break;

                    case "Conicol":
                        BarShapeSelected = "CON";
                        break;

                    default:
                        BarShapeSelected = "RND";
                        break;
                }

                //Not wired up yet
                /*
                SawCalcShapeDimensionSets dimension = scc.SawCalcShapeDimensionSets.Where(x => x.ShapeMeasurementId.Equals(state.ShapeMeasurementId)).FirstOrDefault();
                ShapeMeasurementId = dimension.ShapeMeasurementId;

                switch (BarShapeSelected)
                {
                    case "RND":
                        Dimension1 = dimension.Dimension1;
                        break;

                    case "REC":
                        Dimension2 = dimension.Dimension1;
                        Dimension3 = dimension.Dimension2;
                        break;

                    case "RCS":
                        Dimension4 = dimension.Dimension1;
                        Dimension5 = dimension.Dimension2;
                        Dimension6 = dimension.Dimension3;
                        break;

                    case "CON":
                        Dimension7 = dimension.Dimension1;
                        Dimension8 = dimension.Dimension2;
                        Dimension9 = dimension.Dimension3;
                        break;

                    default:
                        Dimension1 = dimension.Dimension1;
                        break;
                }
                */

            }
        }

        //TODO: MOVE TO UTILITIES
        private string GetValueFromText(string Text, List<SelectListItem> Items)
        {
            string rtv = string.Empty;

            SelectListItem item = Items.Where(x => x.Text.Equals(Text)).FirstOrDefault();

            if (item != null)
                rtv = item.Value;

            return rtv;
        }

        private double GetCrossSectionArea()
        {
            double rtv = 0d;
            double radius = 0d;

            switch (BarShapeSelected)
            {
                case "RND":
                    radius = Convert.ToDouble(Dimension1) / 2d;
                    rtv = Math.Pow(radius, 2) * Math.PI;
                    break;

                case "REC":
                    rtv = Convert.ToDouble(Dimension2) * Convert.ToDouble(Dimension3);
                    break;

                case "RCS":
                    //Find simple square area
                    rtv = Convert.ToDouble(Dimension4) * Convert.ToDouble(Dimension5);
                    //Extract corner radius
                    radius = Convert.ToDouble(Dimension6);
                    //Remove corner blocks entirely, but add one circle area which represents the four corners
                    rtv = rtv - 4 * Math.Pow(radius, 2) + Math.Pow(radius, 2) * Math.PI;
                    break;

                case "CON":
                    radius = (Convert.ToDouble(Dimension8) + Convert.ToDouble(Dimension9)) / 4d;
                    rtv = Math.Pow(radius, 2) * Math.PI;
                    break;
                //case "BEV":
                //    break;
                //case "BUL":
                //    break;
                //case "TUB":
                //    //Get outer/overall area
                //    radius = Convert.ToDouble(Dimension1) / 2d;
                //    rtv = Math.Pow(radius, 2) * Math.PI;
                //    // and subtract inner area
                //    radius = Convert.ToDouble(Dimension2) / 2d;
                //    rtv -= Math.Pow(radius, 2) * Math.PI;
                //    break;
                default:
                    //Use round if no shape specified
                    radius = Convert.ToDouble(Dimension1) / 2d;
                    rtv = Math.Pow(radius, 2) * Math.PI;
                    break;
            }

            return rtv;
        }

        public void PopulateBarShapeChoices(SawCalcShopOrders ShopOrder)
        {
            ShopOrderNumber = ShopOrder.ShopOrderNumber;
            LocationCode = "CFCA";

            BarShapeOptions = new List<SelectListItem>();

            using (WildcatContext wcc = new WildcatContext())
            {
                List<BarShape> barShapes = wcc.BarShape.Where(x => x.Active.Equals(true)).ToList();

                foreach (BarShape barShape in barShapes)
                {
                    BarShapeOptions.Add(new SelectListItem { Value = barShape.ShapeCode, Text = barShape.ShapeDescription });
                }
            }

            if (ShopOrder.BilletShape == null)
                ShopOrder.BilletShape = "";

            //This section is for dealing with all the hokey abbreviations that Jareev and CF workers have
            // been using for shapes; they've been using RCS, CS, RD, RND, and SHT(?)
            if (ShopOrder.BilletShape.IndexOf("RD") > -1)
                BarShapeSelected = "RND";
            else if (ShopOrder.BilletShape.IndexOf("RND") > -1)
                BarShapeSelected = "RND";
            else if (ShopOrder.BilletShape.IndexOf("ROUND") > -1)
                BarShapeSelected = "RND";
            else if (ShopOrder.BilletShape.IndexOf("TUB") > -1)
                BarShapeSelected = "RND";
            else if (ShopOrder.BilletShape.IndexOf("SHT") > -1)
                BarShapeSelected = "RND";
            else if (ShopOrder.BilletShape.IndexOf("BEV") > -1)
                BarShapeSelected = "RCS";
            else if (ShopOrder.BilletShape.IndexOf("CON") > -1)
                BarShapeSelected = "CON";
            else if (ShopOrder.BilletShape.IndexOf("REC") > -1)
                BarShapeSelected = "REC";
            else if (ShopOrder.BilletShape.IndexOf("RRC") > -1)
                BarShapeSelected = "RCS";
            else if (ShopOrder.BilletShape.IndexOf("RCS") > -1)
                BarShapeSelected = "RCS";
            else if (ShopOrder.BilletShape.IndexOf("CS") > -1)
                BarShapeSelected = "RCS";
            else
                BarShapeSelected = "RND";
        }
    }
}