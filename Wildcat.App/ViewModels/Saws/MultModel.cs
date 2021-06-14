
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using Wildcat.Entities.CFCA.Saws;
using Wildcat.Utilities;
using System.Security.Principal;

namespace Wildcat.App.ViewModels.Saws
{
    public class MultModel
    {
        #region Properties

        public string LocationCode { get; set; }

        //public int pieceID { get; set; }

        //There is already a ShopOrder object embedded in Piece
        //public SawCalcShopOrders ShopOrder { get; set; }

        public SawCalcPieces Piece { get; set; }

        public SawCalcBillets Billet { get; set; }

        public SawCalcPersons Operator { get; set; }

        public SawCalcBlades Blade { get; set; }

        public SawCalcSaws Saw { get; set; }
        public SawCalcMaterials Material { get; set; }

        public List<SelectListItem> SawMachineOptions { get; set; }

        public string SawMachineSelected { get; set; }

        //Metrics
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double? MetricCrossSectionArea { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public double? MetricDensityCorrection { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? MetricTargetWeight { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? MetricActualVsTarget { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public double? MetricAdjustedTargetLength { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double? MetricTPI { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public double? MetricKerf { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double? MetricCutRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? MetricBladeSpeed { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? MetricBladeLifeDepleted { get; set; }


        //Billet Dimensions
        public string Shape { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public double? Dimension1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public double? Dimension2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public double? Dimension3 { get; set; }


        public List<SelectListItem> CutTypeOptions { get; set; }
        public string CutTypeSelected { get; set; }

        public List<SelectListItem> BladeOptions { get; set; }
        public string BladeSelected { get; set; }

        #endregion Properties

        #region Constructors

        public MultModel()
        {
            //Default
            LocationCode = "CFCA";
        }

        public MultModel(int PieceID)
        {
            //Default
            LocationCode = "CFCA";

            using (SawCalcContext scc = new SawCalcContext())
            {
                Piece = scc.SawCalcPieces.Where(x => x.PieceId.Equals(PieceID)).FirstOrDefault();
                //Piece.ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderId.Equals(Piece.ShopOrderId)).FirstOrDefault();
                Billet = scc.SawCalcBillets.Where(x => x.BilletId.Equals(Piece.BilletId)).FirstOrDefault();
                Operator = scc.SawCalcPersons.Where(x => x.PersonId.Equals(Piece.OperatorId)).FirstOrDefault();
                Blade = scc.SawCalcBlades.Where(x => x.BladeId.Equals(Piece.BladeId)).FirstOrDefault();
                Saw = scc.SawCalcSaws.Where(x => x.SawId.Equals(Piece.SawId)).FirstOrDefault();

                //In production, you encountered pieces with no billet; therefore no lot number
                if(Billet != null)
                    Material = scc.SawCalcMaterials.Where(x => x.MaterialId.Equals(Billet.MaterialId)).FirstOrDefault();

                //Get Shape
                SawCalcShapeMeasurements Measure = scc.SawCalcShapeMeasurements.Where(x => x.ShapeMeasurementId.Equals(Piece.ShapeMeasurementId)).FirstOrDefault();
                Shape = Measure.CrossSectionShape;

                //Get Dimensions
                SawCalcShapeDimensionSets DimensionSet = scc.SawCalcShapeDimensionSets.Where(x => x.ShapeMeasurementId.Equals(Piece.ShapeMeasurementId)).FirstOrDefault();

                Dimension1 = DimensionSet.Dimension1;
                Dimension2 = DimensionSet.Dimension2;
                Dimension3 = DimensionSet.Dimension3;                                
            }

            MetricCrossSectionArea = Piece.AverageCrossSectionArea;
            MetricDensityCorrection = Piece.DensityCorrectionFactor;
            MetricTargetWeight = Piece.TargetWeight;
            MetricAdjustedTargetLength = Piece.AdjustedTargetLength;
            MetricActualVsTarget = ((Piece.ActualWeight / Piece.TargetWeight) - 1d) * 100d;
            MetricTPI = Piece.Tpi;
            MetricKerf = Piece.Kerf;
            MetricCutRate = Piece.CutRate;
            MetricBladeSpeed = Piece.BladeSpeed;

            if (Saw != null && Material != null)
                MetricBladeLifeDepleted = Piece.AverageCrossSectionArea / GetBladeLifeSpan(Piece.CutRate, Saw, Material) * 100;
            else
                MetricBladeLifeDepleted = 0d;

            PopulateDropDownChoices();
        }

        #endregion Constructors  

        private void PopulateDropDownChoices()
        {
            BladeOptions = new List<SelectListItem>();

            using (SawCalcContext scc = new SawCalcContext())
            {
                List<SawCalcBlades> sawBlades = scc.SawCalcBlades.Where(x => x.IsActive == true).ToList();
                sawBlades = sawBlades.OrderBy(x => x.BladeName).ToList();

                foreach (SawCalcBlades sawBlade in sawBlades)
                {
                    BladeOptions.Add(new SelectListItem { Value = sawBlade.BladeId.ToString(), Text = sawBlade.BladeName });
                }
            }

            if (Piece.Blade != null)
                BladeSelected = Piece.Blade.BladeName;
            else
                BladeSelected = BladeOptions.FirstOrDefault().Text;

            CutTypeOptions = new List<SelectListItem>();

            CutTypeOptions.Add(new SelectListItem { Value = "MULT", Text = "Mult" });
            CutTypeOptions.Add(new SelectListItem { Value = "PROLONG", Text = "Prolong" });
            CutTypeOptions.Add(new SelectListItem { Value = "EXCEPTION", Text = "Exception" });
            CutTypeOptions.Add(new SelectListItem { Value = "REMNANT", Text = "Remnant" });

            if (Piece.IsRemnant)
                CutTypeSelected = "Remnant";
            else if (Piece.IsProlong)
                CutTypeSelected = "Prolong";
            else if (Piece.IsException)
                CutTypeSelected = "Exception";
            else
                CutTypeSelected = "Mult";
        }

        private double GetBladeLifeSpan(double cutRate, SawCalcSaws saw, SawCalcMaterials material)
        {
            double lowCutRate = material.LowProductionCutRate * saw.PerformanceFactor;
            double mediumCutRate = material.MediumProductionCutRate * saw.PerformanceFactor;
            double highCutRate = material.HighProductionCutRate * saw.PerformanceFactor;

            double lowBladeLife = material.LowProductionBladeLife * saw.PerformanceFactor;
            double mediumBladeLife = material.MediumProductionBladeLife * saw.PerformanceFactor;
            double highBladeLife = material.HighProductionBladeLife * saw.PerformanceFactor;

            if (cutRate <= lowCutRate)
            {
                return lowBladeLife;
            }
            else if (cutRate >= highCutRate)
            {
                return highBladeLife;
            }
            else if (cutRate == mediumCutRate)
            {
                return mediumBladeLife;
            }
            else if ((cutRate > lowCutRate) && (cutRate < mediumCutRate))
            {
                return
                    mediumBladeLife +
                    (
                        (lowBladeLife - mediumBladeLife) *
                        (
                            (cutRate - lowCutRate) /
                            (mediumCutRate - lowCutRate)
                        )
                    );
            }
            else if ((cutRate > mediumCutRate) && (cutRate < highCutRate))
            {
                return
                    highBladeLife +
                    (
                        (mediumBladeLife - highBladeLife) *
                        (
                            (cutRate - mediumCutRate) /
                            (highCutRate - mediumCutRate)
                        )
                    );
            }
            else
            {
                // This is an error condition meaning that the following is not true:
                //      LowCutRate < MediumCutRate < HighCutRate
                return mediumCutRate;
            }
        }

        //If user clicks on a mult/piece detail and changes anything, we need to capture that
        public bool SavePossibleEdits()
        {
            bool rtv = false;
            bool editDetected = false;

            string user = Piece.LastModifiedBy;
            string type = CutTypeSelected;
            int blade = Conversion.SafeInteger(BladeSelected);

            double weight = Piece.ActualWeight;
            string serial = Piece.MultSerialNumber;
            string notes = Piece.IssueNotes;
            
            string heat = Billet.HeatNumber;
            string billet = Billet.BilletNumber;

            user = StringHelper.ShortUserName(user, 20);

            using (SawCalcContext scc = new SawCalcContext())
            {
                Piece = scc.SawCalcPieces.Where(x => x.PieceId.Equals(Piece.PieceId)).FirstOrDefault();
                Billet = scc.SawCalcBillets.Where(x => x.BilletId.Equals(Billet.BilletId)).FirstOrDefault();

                if(Billet.HeatNumber != heat)
                {
                    editDetected = true;
                    Billet.HeatNumber = heat;
                }

                if(Billet.BilletNumber != billet)
                {
                    editDetected = true;
                    Billet.BilletNumber = billet;
                }

                //This is just for the billet
                if(editDetected)
                {
                    scc.Entry(Billet).State = EntityState.Modified;
                    scc.SaveChanges();

                    //Reset for Pice
                    editDetected = false;
                }

                if (Piece.ActualWeight != weight)
                {
                    editDetected = true;
                    Piece.ActualWeight = weight;
                }

                if(Piece.MultSerialNumber != serial)
                {
                    editDetected = true;
                    Piece.MultSerialNumber = serial;
                }

                if(Piece.IssueNotes != notes)
                {
                    editDetected = true;

                    Piece.IssueNotes = notes;
                    Piece.IssueOwner = user;                    
                }

                if(Piece.BladeId != blade)
                {
                    editDetected = true;
                    Piece.BladeId = blade;
                }

                switch(CutTypeSelected)
                {
                    case "MULT":
                        if(!Piece.IsMult)
                        {
                            editDetected = true;

                            ResetAllCutTypes();
                            Piece.IsMult = true;
                        }
                        break;
                    case "PROLONG":
                        if(!Piece.IsProlong)
                        {
                            editDetected = true;

                            ResetAllCutTypes();
                            Piece.IsProlong = true;
                        }
                        break;
                    case "EXCEPTION":
                        if (!Piece.IsException)
                        {
                            editDetected = true;

                            ResetAllCutTypes();
                            Piece.IsException = true;
                        }
                        break;
                    case "REMNANT":
                        if (!Piece.IsRemnant)
                        {
                            editDetected = true;

                            ResetAllCutTypes();
                            Piece.IsRemnant = true;
                        }
                        break;
                }

                if(editDetected)
                {
                    Piece.LastModifiedBy = user;
                    Piece.LastModifiedDate = DateTime.Now;

                    scc.Entry(Piece).State = EntityState.Modified;
                    scc.SaveChanges();
                }
            }

            return rtv;
        }

        private void ResetAllCutTypes()
        {
            Piece.IsMult = Piece.IsProlong = Piece.IsException = Piece.IsRemnant = false;
        }

        public bool DeletePiece(int PieceID)
        {
            bool rtv = false;

            string user = this.Piece.LastModifiedBy;

            try
            {
                using (SawCalcContext scc = new SawCalcContext())
                {
                    Piece = scc.SawCalcPieces.Where(x => x.PieceId.Equals(PieceID)).FirstOrDefault();

                    if (Piece != null)
                    {
                        Piece.LastModifiedBy = user;
                        Piece.LastModifiedDate = DateTime.Now;

                        // Only Soft Delete
                        Piece.IsDeleted = true;

                        scc.Entry(Piece).State = EntityState.Modified;
                        scc.SaveChanges();

                        rtv = true;
                    }
                }
            }
            catch (Exception e)
            {
                //TODO: Log
                rtv = false;
            }

            return rtv;
        }

        public HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            return HtmlBuilder.Dropdown(id, selectListItems, label, selectedValue, width);
        }

        public HtmlString DropdownTextBox(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            return HtmlBuilder.DropdownTextBox(id, selectListItems, label, selectedValue, width);
        }

        public HtmlString ListBox(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            return HtmlBuilder.ListBox(id, selectListItems, label, selectedValue, width);
        }
    }
}