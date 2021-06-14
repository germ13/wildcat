
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Shultz.Util.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
//using Wildcat.ApiCore.Models;
using Wildcat.App.Classes;
using Wildcat.Entities.CFCA.Planning;
using Wildcat.Entities.CFCA.Saws;
using Wildcat.Logic.CFCA.Saws;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.Saws
{
    public class SawModel
    {
        #region Properties
        
        private bool _displayEmptyJobUI = true;
        public string LocationCode { get; set; }
        public List<SelectListItem> DiscreteJobOptions { get; set; }
        public string DiscreteJobSelected { get; set; }
        public string PrintMultChartUrl { get; set; }
        public string PrintCheckListUrl { get; set; }
        public string PrintMarkingSheetUrl { get; set; }
        public List<CfwAccuBarDistro> BarDistroRecords { get; set; }
        public SawCalcShopOrders ShopOrder { get; set; }
        public SawCalcShopOrderSavedStates SavedState { get; set; }
        public List<SawCalcShopOrderHeatAndBilletNumbers> HeatAndBilletNumbers { get; set; }
        public List<SawCalcShopOrderBillets> Billets { get; set; }
        public List<SawCalcPieces> Pieces { get; set; }
        public List<SawPieceResult> PieceSummaryResults { get; set; }
        public List<SelectListItem> LotNumberOptions { get; set; }
        public string LotNumberSelected { get; set; }
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double OriginalWeight { get; set; }
        public LengthParameterModel LengthParameters { get; set; }
        public List<SelectListItem> MaterialOptions { get; set; }
        public SawCalcMaterials Material { get; set; }
        public List<SelectListItem> BilletDirectionOptions { get; set; }
        public string BilletDirectionSelected { get; set; }
        public int PiecesLeftToCut { get; set; }
        public string PieceTypeString { get; set; }
        public List<SelectListItem> SawMachineOptions { get; set; }
        public string SawMachineSelected { get; set; }
        public List<SelectListItem> BladeOptions { get; set; }
        public string BladeSelected { get; set; }
        public double? TargetWeight { get; set; }
        public double? ActualWeight { get; set; }

        //BEG RIGHT PANEL SECTION
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? CalculatedInitialLength { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? RemainingLength { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? RemainingWeight { get; set; }
        public double? LengthConsumedByEachNewCut { get; set; }
        public double? WeightConsumedByEachNewCut { get; set; }
        [DisplayFormat(DataFormatString = "{0:F0}", ApplyFormatInEditMode = true)]
        public int PiecesLeftInBillet { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? RemnantLength { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? RemnantWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? CrookedEndAdjustment { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? AdjustedTargetLength { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? ActualWeightVsTargetWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? ActualWeightVsAverageWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double? SingleKerfWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double? TotalRevertWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double? TotalKerfWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double? TotalKerfWeightCurrentBillet { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? EstimatedTimePerCut { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? ActualTimeLastCut { get; set; }
        [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
        public double? BladeSpeed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? AllowableCutDeviation { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public int? AllMultsCompletedUnits { get; set; }
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? AllMultsCompletedTotalWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? AllMultsCompletedAverageWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? AllMultsCompletedStandDeviation { get; set; }
        [DisplayFormat(DataFormatString = "{0:N1}", ApplyFormatInEditMode = true)]
        public double? AllMultsProjectedWeight { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? DensityCorrection { get; set; }
        //END RIGHT PANEL SECTION

        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double? Kerf { get; set; }
        public List<SelectListItem> TpiRangeOptions { get; set; }
        //WHILE THIS IS A STRING, IT SHOULD CORRESPOND TO AN INTEGER USED FOR A DROP DOWN SELECTION
        public string TpiRangeSelected { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double CutRate { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double CrookedEndAngle { get; set; }
        public List<SelectListItem> UnfinishedSerialNumberOptions { get; set; }
        public string UnfinishedSerialNumberSelected { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public double SawCalibrationOffset { get; set; }
        public SawCalcShapeDimensionSets ShapeDimension { get; set; }

        #endregion

        #region Constructors
        public SawModel()
        {
            LocationCode = "CFCA";
        }

        public SawModel(string loc, string son)
        {   
            LocationCode = loc;

            if(string.IsNullOrEmpty(son))
            {
                _displayEmptyJobUI = true;
            }
            else
            {
                _displayEmptyJobUI = false;
                DiscreteJobSelected = son;
            }
        }

        //public SawModel(string loc, int soi)
        //{
        //    LocationCode = loc;

        //    if (string.IsNullOrEmpty(soi.ToString()))
        //    {
        //        _displayEmptyJobUI = true;
        //    }
        //    else
        //    {
        //        _displayEmptyJobUI = false;
        //        DiscreteJobSelected = soi.ToString();
        //    }
        //}

        public void PopulateEmptyModel()
        {
            PiecesLeftToCut = 10;
            OriginalWeight = 0d;
            Kerf = 0.1d;

            CutRate = 0d;
            DensityCorrection = 1d;
            SawCalibrationOffset = 0d;
        }

        public void GetPopulatedModel(string loc, int soi)
        {
            LocationCode = loc;

            using (SawCalcContext scc = new SawCalcContext())
            {
                SavedState = scc.SawCalcShopOrderSavedStates.Where(x => x.ShopOrderId.Equals(soi)).OrderByDescending(x => x.ShapeMeasurementId).FirstOrDefault();

                LengthParameters = new LengthParameterModel();

                if (SavedState != null)
                {
                    LengthParameters.PopulateDimensions(SavedState);
                }
            }
        }

        public void PopulateModel(string loc, string son)
        {
            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();
                SavedState = scc.SawCalcShopOrderSavedStates.Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId)).OrderByDescending(x => x.ShapeMeasurementId).FirstOrDefault();

                LengthParameters = new LengthParameterModel();

                if (SavedState != null)
                {
                    LengthParameters.PopulateDimensions(SavedState);
                }
            }
        }

        public List<object[]> GetBarDistributionData(string loc, string son)
        {
            List<object[]> rtv = new List<object[]>();

            object[] obj = null;

            if (son == null)
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

        public void RefreshRightPanelStats()
        {
            SawCalcShopOrderHeatAndBilletNumbers hab = null;
            SawCalcBillets blt = null;

            using (SawCalcContext scc = new SawCalcContext())
            {
                string[] lot = new string[0];

                if(LotNumberSelected != null)                
                    lot = LotNumberSelected.Split('.');

                if (lot.Length > 1)
                {
                    hab = scc.SawCalcShopOrderHeatAndBilletNumbers.Where(x => x.ShopOrderId
                        .Equals(ShopOrder.ShopOrderId) && x.HeatNumber
                        .Equals(lot[0]) && x.BilletNumber
                        .Equals(lot[1]))
                        .OrderBy(x => x.SequenceNumber).FirstOrDefault();

                    blt = scc.SawCalcBillets.Where(x => x.HeatNumber
                        .Equals(lot[0]) && x.BilletNumber
                        .Equals(lot[1])).FirstOrDefault();
                }

                SawCalcComputers cpu = scc.SawCalcComputers.Where(x => x.ComputerName.Equals(Environment.MachineName)).FirstOrDefault();

                if (cpu != null)
                {
                    SavedState = scc.SawCalcShopOrderSavedStates.Where(x => x.ShopOrderId
                        .Equals(ShopOrder.ShopOrderId) && x.ComputerId
                        .Equals(cpu.ComputerId)).DefaultIfEmpty().Last();
                }

                if (Pieces.Count() == 0)
                    Pieces = scc.SawCalcPieces.Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId) && x.IsRemnant.Equals(false)).ToList();

            }

            double OriginalBilletWeight = 0d;
            double TotalBilletCutWeight = 0d;

            if (hab != null)
            {
                OriginalBilletWeight = hab.OriginalWeight;
            }

            CalculatedInitialLength = OriginalBilletWeight / LengthParameters.CrossSectionArea / Material.Density;

            double SumOfCompletedMultLength = Pieces.Where(x => x.IsRemnant.Equals(false)).Sum(y => y.AdjustedTargetLength);

            AllMultsCompletedUnits = Pieces.Where(x => x.IsMult.Equals(true)).Count();
            AllMultsCompletedTotalWeight = Pieces.Where(x => x.IsMult.Equals(true)).Sum(y => y.ActualWeight);

            if (Pieces.Count() > 0)
                AllMultsCompletedAverageWeight = Pieces.Where(x => x.IsMult.Equals(true)).Average(y => y.ActualWeight);

            List<double> weights = new List<double>();

            TotalRevertWeight = 0d;
            TotalKerfWeight = 0d;
            TotalKerfWeightCurrentBillet = 0d;

            foreach (SawCalcPieces piece in Pieces.Where(x => x.IsMult.Equals(true)).ToList())
            {
                weights.Add(piece.ActualWeight);

                if (blt != null)
                {
                    if (piece.BilletId.Equals(blt.BilletId))
                    {
                        TotalBilletCutWeight += piece.ActualWeight;
                        TotalKerfWeightCurrentBillet += piece.Kerf * LengthParameters.CrossSectionArea * Material.Density;
                    }
                }

                TotalKerfWeight += piece.Kerf;
            }

            AllMultsCompletedStandDeviation = MathHelper.CalculateStandardDeviation(weights);

            RemainingWeight = OriginalBilletWeight - TotalBilletCutWeight - TotalKerfWeightCurrentBillet;
            RemainingLength = DensityCorrection * (RemainingWeight / LengthParameters.CrossSectionArea / Material.Density);

            /*
            string[] targetWeights = ShopOrder.TargetWeights.Split(',');

            if (targetWeights.Length > 0)
                TargetWeight = Conversion.SafeDouble(targetWeights[0]);
            */

            AllMultsProjectedWeight = AllMultsCompletedTotalWeight + PiecesLeftToCut * TargetWeight;

            CrookedEndAdjustment = Math.Tan(CrookedEndAngle) * LengthParameters.Dimension1;

            SawCalcPieces lastPiece = new SawCalcPieces();

            if (Pieces.Count() > 0)
                lastPiece = Pieces.Where(x => x.IsRemnant.Equals(false)).Last();

            DensityCorrection = lastPiece.DensityCorrectionFactor;

            AdjustedTargetLength = (LengthParameters.CalculatedTargetLength + CrookedEndAdjustment) * DensityCorrection;

            SingleKerfWeight = Kerf * LengthParameters.CrossSectionArea * Material.Density;

            WeightConsumedByEachNewCut = TargetWeight + SingleKerfWeight;

            if (SavedState != null)
                Kerf = SavedState.Kerf;
            else
                Kerf = 0.1d;

            LengthConsumedByEachNewCut = AdjustedTargetLength + Kerf;

            PiecesLeftInBillet = Conversion.SafeInteger(Math.Floor(Conversion.SafeDecimal(RemainingLength / LengthConsumedByEachNewCut)));

            RemnantWeight = RemainingWeight - (WeightConsumedByEachNewCut * PiecesLeftInBillet);
            RemnantLength = RemainingLength - (LengthConsumedByEachNewCut * PiecesLeftInBillet);

            ActualWeightVsTargetWeight = (AllMultsCompletedTotalWeight - TargetWeight) / (TargetWeight * 100);
            ActualWeightVsAverageWeight = (AllMultsCompletedTotalWeight - AllMultsCompletedAverageWeight) / (AllMultsCompletedAverageWeight * 100);

            TotalRevertWeight = TotalKerfWeight * LengthParameters.CrossSectionArea * Material.Density;

            EstimatedTimePerCut = LengthParameters.CrossSectionArea / CutRate;

            ActualTimeLastCut = lastPiece.ActualCutTime;

            if(SavedState != null)
                BladeSpeed = LengthParameters.Dimension1 / (Material.ChipLoad * SavedState.Tpi * 12 * EstimatedTimePerCut);
            else
                BladeSpeed = LengthParameters.Dimension1 / (Material.ChipLoad * lastPiece.Tpi * 12 * EstimatedTimePerCut);

            AllowableCutDeviation = 0.008 * LengthParameters.Dimension1;
        }

        public void AddUnfinishedSerialNumberOptions()
        {
            UnfinishedSerialNumberOptions = new List<SelectListItem>();

            using (SawCalcContext scc = new SawCalcContext())
            {
                List<SawCalcShopOrderSerialNumbers> serialNumbers = scc.SawCalcShopOrderSerialNumbers
                    .Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId))
                    .OrderBy(x => x.MultSerialNumber)
                    .ToList();

                foreach (SawCalcShopOrderSerialNumbers serialNumber in serialNumbers)
                {
                    SawCalcPieces piece = scc.SawCalcPieces.Where(x => x.MultSerialNumber.Equals(serialNumber.MultSerialNumber)).FirstOrDefault();

                    if (piece == null)
                        UnfinishedSerialNumberOptions.Add(new SelectListItem { Value = serialNumber.MultSerialNumber, Text = serialNumber.MultSerialNumber });

                }

                if (UnfinishedSerialNumberOptions.Count > 0)
                    UnfinishedSerialNumberSelected = UnfinishedSerialNumberOptions.FirstOrDefault().Text;
            }

            PiecesLeftToCut = UnfinishedSerialNumberOptions.Count;
        }

        public void AddPieceResults()
        {
            PieceSummaryResults = new List<SawPieceResult>();
            Pieces = new List<SawCalcPieces>();

            SawPieceResult psr;

            string _connectString = @"server=wgfc-dev-sql01,1433;Database=SawCalc;user id=sawcalc;password=sawcalc123!!;";
            using (SqlConnection con = new SqlConnection(_connectString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.GetSawPieces", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ShopOrderID", ShopOrder.ShopOrderId));

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    psr = new SawPieceResult();

                    psr.ShopOrderID = Convert.ToInt32(sdr["ShopOrderID"]);
                    psr.PieceID = Convert.ToInt32(sdr["PieceID"]);
                    psr.CreatedDate = Convert.ToDateTime(sdr["CreatedDate"]);
                    psr.LotNumber = string.Format("{0}.{1}", sdr["HeatNumber"], sdr["BilletNumber"]);

                    if (!string.IsNullOrEmpty(sdr["PieceIndex"].ToString()))
                        psr.PieceIndex = Convert.ToInt32(sdr["PieceIndex"]);

                    if (Convert.ToBoolean(sdr["IsMult"]))
                        psr.PieceType = "Mult";
                    else if (Convert.ToBoolean(sdr["IsProlong"]))
                        psr.PieceType = "Prolong";
                    else if (Convert.ToBoolean(sdr["IsException"]))
                        psr.PieceType = "Exception";
                    else
                        psr.PieceType = "Remnant";

                    psr.SerialNumber = Convert.ToString(sdr["MultSerialNumber"]);
                    psr.ActualWeight = Convert.ToDouble(sdr["ActualWeight"]);

                    PieceSummaryResults.Add(psr);
                }
            }

            PieceSummaryResults = PieceSummaryResults.OrderBy(x => x.CreatedDate).ToList();
        }

        public void PopulateDropDownChoices()
        {
            DiscreteJobOptions = new List<SelectListItem>();
            MaterialOptions = new List<SelectListItem>();
            SawMachineOptions = new List<SelectListItem>();
            BladeOptions = new List<SelectListItem>();

            TpiRangeOptions = new List<SelectListItem>();
            BilletDirectionOptions = new List<SelectListItem>();
            LotNumberOptions = new List<SelectListItem>();

            if (!_displayEmptyJobUI)
            {
                using (ModelContext mod = new ModelContext())
                {
                    WipEntitiesShell wipEntitiesShell = mod.WipEntitiesShell.Where(x => x.WipEntityName.Equals(DiscreteJobSelected) && x.OrganizationId == 182).FirstOrDefault();
                    List<CfwAccuMultCount> MultCountRecords = mod.CfwAccuMultCount.Where(x => x.WipEntityId.Equals(wipEntitiesShell.WipEntityId)).ToList();

                    foreach (CfwAccuMultCount mct in MultCountRecords)
                    {
                        if(TargetWeight == null)
                            TargetWeight = Conversion.SafeDouble(mct.CutWeight);

                        LengthParameters.TargetWeightOptions.Add(new SelectListItem { Value = mct.CutWeight.ToString(), Text = mct.CutWeight.ToString() });
                    }

                    if (LengthParameters.TargetWeightOptions.Count > 0)
                    {
                        LengthParameters.TargetWeightSelected = LengthParameters.TargetWeightOptions[0].Value;
                    }
                }
            }
            else
            {
                LengthParameters = new LengthParameterModel();
                LengthParameters.TargetWeightOptions.Add(new SelectListItem { Value = "0.0", Text = "0.0" });
                LengthParameters.TargetWeightSelected = "0.0";
            }

            using (SawCalcContext scc = new SawCalcContext())
            {
                List<SawCalcShopOrders> shopOrders = scc.SawCalcShopOrders                    
                    .OrderByDescending(x => x.LastCutDate)
                    .ThenByDescending(x => x.CreatedDate)
                    .Take(20)
                    .ToList();

                foreach (SawCalcShopOrders shopOrder in shopOrders)
                {
                    DiscreteJobOptions.Add(new SelectListItem { Value = shopOrder.ShopOrderNumber, Text = shopOrder.ShopOrderNumber });
                }

                if(!_displayEmptyJobUI)
                    ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(DiscreteJobSelected)).FirstOrDefault();

                if (ShopOrder == null)
                {
                    //Insert default order since we didn't find requested order
                    ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderId.Equals(1)).FirstOrDefault();
                }

                if (!_displayEmptyJobUI)
                {
                    SavedState = scc.SawCalcShopOrderSavedStates.Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId)).OrderBy(x => x.NumberOfPiecesLeft).FirstOrDefault();


                    HeatAndBilletNumbers = scc.SawCalcShopOrderHeatAndBilletNumbers.Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId)).OrderBy(x => x.SequenceNumber).ToList();

                    foreach (SawCalcShopOrderHeatAndBilletNumbers HeatAndBilletNumber in HeatAndBilletNumbers)
                    {
                        string text = string.Format("{0}.{1}", HeatAndBilletNumber.HeatNumber, HeatAndBilletNumber.BilletNumber);
                        string value = string.Format("{0}_{1}", HeatAndBilletNumber.SequenceNumber, HeatAndBilletNumber.OriginalWeight);

                        LotNumberOptions.Add(new SelectListItem { Value = value, Text = text });
                    }

                    if (LotNumberOptions.Count > 0)
                    {
                        LotNumberSelected = LotNumberOptions.FirstOrDefault().Text;

                        OriginalWeight = Conversion.SafeDouble(LotNumberOptions.FirstOrDefault().Value.Split('_')[1]);
                    }


                    AddUnfinishedSerialNumberOptions();

                    //This could be null if we're populating an empty model
                    if (UnfinishedSerialNumberOptions != null)
                        PiecesLeftToCut = UnfinishedSerialNumberOptions.Count;
                }

                BilletDirectionOptions.Add(new SelectListItem { Value = "Top to Bottom", Text = "Top to Bottom" });
                BilletDirectionOptions.Add(new SelectListItem { Value = "Bottom to Top", Text = "Bottom to Top" });

                if (SavedState != null && SavedState.BilletDirectionBottomToTop == false)
                    BilletDirectionSelected = "Top to Bottom";
                else
                    BilletDirectionSelected = "Bottom to Top";

                List<SawCalcMaterials> metals = scc.SawCalcMaterials.OrderBy(x => x.MaterialName).ToList();

                foreach (SawCalcMaterials metal in metals)
                {
                    metal.MaterialName = metal.MaterialName.Replace(" -", "-");
                    metal.MaterialName = metal.MaterialName.Replace("- ", "-");

                    MaterialOptions.Add(new SelectListItem { Value = metal.MaterialId.ToString(), Text = metal.MaterialName });

                    if (metal.MaterialId == ShopOrder.MaterialId)
                        Material = metal;
                }

                if (Material == null)
                    Material = metals.FirstOrDefault();

                LengthParameters.LocationCode = LocationCode;
                LengthParameters.ShopOrderNumber = DiscreteJobSelected;
                LengthParameters.Density = Material.Density;

                if (SavedState != null)
                {
                    string savedValue = Conversion.SafeDouble(SavedState.TargetWeight).ToString("0.0");

                    if (LengthParameters.TargetWeightSelected != savedValue)
                    {
                        LengthParameters.TargetWeightOptions.Add(new SelectListItem { Value = savedValue, Text = savedValue });
                        LengthParameters.TargetWeightSelected = savedValue;
                    }
                }

                LengthParameters.PopulateBarShapeChoices(ShopOrder);
                LengthParameters.UpdateCalculatedTargetLength();

                AdjustedTargetLength = (LengthParameters.CalculatedTargetLength + CrookedEndAdjustment) * DensityCorrection;

                //Now calculate All Mults info box
                Pieces = scc.SawCalcPieces.Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId) && x.MultSerialNumber != null).ToList();

                AllMultsCompletedUnits = Pieces.Count;
                AllMultsCompletedTotalWeight = Pieces.Sum(x => x.ActualWeight);

                AllMultsProjectedWeight = AllMultsCompletedTotalWeight + Conversion.SafeDouble(LengthParameters.TargetWeightSelected) * (ShopOrder.NumberOfTotalPieces - AllMultsCompletedUnits);

                if (Pieces.Count > 0)
                    AllMultsCompletedAverageWeight = Pieces.Average(x => x.ActualWeight);

                List<double> weightValues = new List<double>();

                foreach (SawCalcPieces piece in Pieces)
                {
                    weightValues.Add(piece.ActualWeight);
                }

                AllMultsCompletedStandDeviation = MathHelper.CalculateStandardDeviation(weightValues);

                List<SawCalcSaws> sawMachines = scc.SawCalcSaws.Where(x => x.IsActive == true).ToList();
                sawMachines = sawMachines.OrderBy(x => x.SawName).ToList();

                foreach (SawCalcSaws sawMachine in sawMachines)
                {
                    SawMachineOptions.Add(new SelectListItem { Value = sawMachine.SawId.ToString(), Text = sawMachine.SawName });
                }

                List<SawCalcBlades> sawBlades = scc.SawCalcBlades.Where(x => x.IsActive == true).ToList();
                sawBlades = sawBlades.OrderBy(x => x.BladeName).ToList();

                foreach (SawCalcBlades sawBlade in sawBlades)
                {
                    BladeOptions.Add(new SelectListItem { Value = sawBlade.BladeId.ToString(), Text = sawBlade.BladeName });
                }

                List<SawCalcAvailableTpis> availableTpis = scc.SawCalcAvailableTpis.ToList();

                foreach (SawCalcAvailableTpis availableTpi in availableTpis)
                {
                    TpiRangeOptions.Add(new SelectListItem { Value = availableTpi.TpiId.ToString(), Text = availableTpi.TpiDescription });

                    if (SavedState != null && SavedState.Tpi != null)
                    {
                        if (SavedState.Tpi == availableTpi.TpiId)
                            TpiRangeSelected = availableTpi.TpiDescription;
                    }
                }

                if (string.IsNullOrEmpty(TpiRangeSelected))
                    TpiRangeSelected = TpiRangeOptions.FirstOrDefault().Text;
            }

            //Even if we have an empty job UI, this object should still be initialized with nothing in the collection
            PieceSummaryResults = new List<SawPieceResult>();

            if (_displayEmptyJobUI)
                return;

            if (SavedState == null)
            {
                BladeSelected = BladeOptions.FirstOrDefault().Text;
                SawMachineSelected = SawMachineOptions.FirstOrDefault().Text;
                Kerf = 0.1d;
                CrookedEndAngle = 0d;
                CutRate = 2d;
                DensityCorrection = 1f;
                SawCalibrationOffset = 0d;
            }
            else
            {
                SawMachineSelected = SavedState.SawName;
                Kerf = Convert.ToDouble(SavedState.Kerf);
                CrookedEndAngle = Convert.ToDouble(SavedState.CrookedEndAngle);
                CutRate = Convert.ToDouble(SavedState.CutRate);
                DensityCorrection = 1f;
                SawCalibrationOffset = Convert.ToDouble(SavedState.SawCalibrationOffset);
                BladeSelected = SavedState.BladeName;
            }

            AddPieceResults();

            PrintMultChartUrl = string.Format(@"/Saws/SawPrintMultChart/?loc={0}&son={1}", "CFCA", ShopOrder.ShopOrderNumber);
            PrintCheckListUrl = string.Format(@"/Saws/SawPrintSerialChecklist/?loc={0}&son={1}", "CFCA", ShopOrder.ShopOrderNumber);
            PrintMarkingSheetUrl = string.Format(@"/Saws/SawPrintSerialMarking/?loc={0}&son={1}", "CFCA", ShopOrder.ShopOrderNumber);
        }

        private void RemoveBandCurl(ref ScatterDataStructure sds)
        {
            sds.pct05 = -501;
            sds.pct25 = -301;

            sds.pct75 = 301;
            sds.pct95 = 501;
        }

        //This builds the x-axis scale which is dynamic
        public List<ScatterDataStructure> GetScatterData(string loc, string son)
        {
            string rtv = string.Empty;

            List<ScatterDataStructure> scatterDataList = new List<ScatterDataStructure>();

            ScatterDataStructure scatterData = new ScatterDataStructure();
            DateTime chartDate = Convert.ToDateTime(scatterData.date);

            RemoveBandCurl(ref scatterData);

            scatterDataList.Add(scatterData);

            using (SawCalcContext scc = new SawCalcContext())
            {
                SawCalcShopOrders so = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault(); //Location = loc

                if (so == null)
                    so = scc.SawCalcShopOrders.Where(x => x.ShopOrderId.Equals(1)).FirstOrDefault(); //Location = loc

                int pieceCount = scc.SawCalcPieces.Where(x => x.ShopOrderId.Equals(so.ShopOrderId) && x.MultSerialNumber != null).Count();

                int i = 1;

                for (; i <= pieceCount; i++)
                {
                    scatterData = new ScatterDataStructure();
                    scatterData.date = chartDate.AddDays(i).ToString("yyyy-MM-dd");

                    scatterDataList.Add(scatterData);
                }

                scatterData = new ScatterDataStructure();

                //Add one date beyond the piece loop above
                scatterData.date = chartDate.AddDays(i).ToString("yyyy-MM-dd");

                RemoveBandCurl(ref scatterData);

                scatterDataList.Add(scatterData);
            }

            return scatterDataList;
        }

        public List<ScatterMarkerStructure> GetScatterMarkers(string loc, string son)
        {
            List<ScatterMarkerStructure> sms = new List<ScatterMarkerStructure>();

            ScatterMarkerStructure scatterMarker = new ScatterMarkerStructure();
            DateTime chartDate = Convert.ToDateTime(scatterMarker.date);

            using (SawCalcContext scc = new SawCalcContext())
            {
                SawCalcShopOrders so = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();

                if (so == null)
                    return sms;

                List<SawCalcPieces> pieces = scc.SawCalcPieces.Where(x => x.ShopOrderId.Equals(so.ShopOrderId) && x.MultSerialNumber != null).ToList();

                int dayIterator = 0;

                foreach (SawCalcPieces piece in pieces)
                {
                    scatterMarker = new ScatterMarkerStructure();

                    scatterMarker.date = chartDate.AddDays(++dayIterator).ToString("yyyy-MM-dd");

                    if (piece.TargetWeight == 0d)
                        scatterMarker.altitude = -2d;
                    else
                        scatterMarker.altitude = 100d * ((piece.ActualWeight / piece.TargetWeight) - 1);

                    sms.Add(scatterMarker);
                }
            }

            return sms;
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

        #endregion

        #region Public Methods

        public string SubmitMultChart(string loc, string son, string userName)
        {
            string rtv = string.Empty;

            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();

                MultChartExporter mce = new MultChartExporter();

                rtv = mce.UpdateOracleData(ShopOrder);
            }

            if (rtv.Length == 0)
                rtv = string.Format("Data saved at {0}", DateTime.Now);
            else if (rtv.Length > 250)
                rtv = rtv.Substring(0, 249);

            return rtv;
        }

        public string ExecuteMaintenanceRequest(string loc, string son, string userName, string pcName, string bladeName, string message)
        {
            string rtv = string.Empty;
            
            SawCalcMaintenanceRequests smr = new SawCalcMaintenanceRequests();
            List<SawCalcPersons> recipients = new List<SawCalcPersons>();
            SawCalcComputers com = new SawCalcComputers();

            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();

                if (ShopOrder != null)
                    smr.ShopOrderId = ShopOrder.ShopOrderId;

                recipients = scc.SawCalcPersons.Where(x => x.SendMaintenanceAlert).ToList();

                com = scc.SawCalcComputers.Where(x => x.ComputerName.Equals(pcName)).FirstOrDefault();

                if (com != null)
                    smr.ComputerId = com.ComputerId;

                StringBuilder body = new StringBuilder();

                body.Append("MAINTENANCE REQUEST");
                body.Append(Environment.NewLine);
                body.Append("Machine: ");
                body.Append(pcName);
                body.Append(Environment.NewLine);
                body.Append("Blade: ");
                body.Append(bladeName);
                body.Append(Environment.NewLine);
                body.Append("Job Number: ");
                body.Append(son);
                body.Append(Environment.NewLine);
                body.Append("Requester: ");
                body.Append(userName);
                body.Append(Environment.NewLine);
                body.Append("Message: ");
                body.Append(message);

                smr.Message = body.ToString();
                smr.CreatedDate = DateTime.Now;

                scc.SawCalcMaintenanceRequests.Add(smr);
                scc.SaveChanges();

                EmailRequest eml = new EmailRequest();

                //if(Environment.MachineName.ToUpper() == "SHCA-CDJXZ12")
                    eml.To.Add("steve.owens@shultzsteel.com");
                //else
                //{
                //    foreach (var recipient in recipients)
                //    {
                //        eml.To.Add(recipient.Email);
                //    }
                //}

                eml.Subject = "Saw Maintenance Request";
                eml.IsBodyHtml = false;
                eml.From = "steve.owens@shultzsteel.com";
                eml.Body = body.ToString();
                eml.Priority = 0;

                //string serviceUri = @"http://wgfc-dev-iis01:11011/api/email/";

                //HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri(serviceUri);

                string issueDescription = string.Empty;
                EmailResponse hrm = null;

                //HttpResponseMessage hrm = null;

                try
                {
                    //var emailTask = client.PostAsJsonAsync<EmailRequest>("send", eml);

                    //emailTask.Wait();

                    //hrm = emailTask.Result;

                    hrm = Emailer.Send(eml);
                }
                catch(Exception exc)
                {
                    issueDescription = exc.InnerException.Message;
                }

                if (issueDescription.Length == 0 && hrm.IsSuccess)
                    rtv = "Maintenance request sent";
                else
                    rtv = "Issue: " + issueDescription;
            }

            if (rtv.Length > 250)
                rtv = rtv.Substring(0, 249);
            
            return rtv;
        }

        public bool SaveState(string pcName)
        {
            bool success = false;

            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(DiscreteJobSelected)).FirstOrDefault();

                if (ShopOrder != null)
                {
                    SavedState = new SawCalcShopOrderSavedStates();
                    SavedState.ShopOrderId = ShopOrder.ShopOrderId;

                    SawCalcComputers com = scc.SawCalcComputers.Where(x => x.ComputerName.Equals(pcName)).FirstOrDefault();

                    if (com != null)
                        SavedState.ComputerId = com.ComputerId;

                    if (LengthParameters != null)
                    {
                        SavedState.CrossSectionShape = LengthParameters.BarShapeSelected;
                    }

                    SavedState.MaterialId = Conversion.SafeInteger(ShopOrder.MaterialId);
                    SavedState.NumberOfPiecesLeft = Conversion.SafeShort(PiecesLeftToCut);

                    if (LotNumberSelected != null)
                    {
                        //THE FOLLOWING SECTION IS ABSURD...LATER, RE FACTOR RAJEEV'S DB SCHEMA SO BILLET DATA IS ALL STORED IN ONE TABLE.
                        // THAT DING DONG HAS AT LEAST 4 TABLES JUST FOR BILLETS AND THAT DOESN'T INCLUDE WHATEVER IS IN ORACLE
                        string[] splitValue = LotNumberSelected.Split('_');

                        if (splitValue.Length > 0)
                        {
                            //ORIG BILLET WEIGHT IS IN SPLITVALUE[1] IF YOU NEED IT
                            int seq = Conversion.SafeShort(splitValue[0]);

                            SawCalcShopOrderHeatAndBilletNumbers htb = null;

                            htb = scc.SawCalcShopOrderHeatAndBilletNumbers.Where(x => x.ShopOrderId.Equals(ShopOrder.ShopOrderId) && x.SequenceNumber.Equals(seq)).FirstOrDefault();

                            SawCalcBillets blt = null;

                            if (htb != null)
                                blt = scc.SawCalcBillets.Where(x => x.HeatNumber.Equals(splitValue[0]) && x.BilletNumber.Equals(splitValue[1])).FirstOrDefault();

                            int billetID = -1;

                            if (blt != null)
                                billetID = Conversion.SafeInteger(blt.BilletId);

                            SawCalcShopOrderBillets sob = null;

                            sob = scc.SawCalcShopOrderBillets.Where(x => x.BilletId.Equals(billetID)).FirstOrDefault();

                            if (sob != null)
                                SavedState.NewBilletWeight = sob.NewBilletWeight;

                        }
                    }

                    SavedState.TargetWeight = Conversion.SafeDouble(LengthParameters.TargetWeightSelected);
                    SavedState.MultSerialNumber = UnfinishedSerialNumberSelected;
                    SavedState.SawName = SawMachineSelected;
                    SavedState.BladeName = BladeSelected;
                    SavedState.Kerf = Conversion.SafeDouble(Kerf);
                    SavedState.Tpi = Conversion.SafeDouble(TpiRangeSelected);
                    SavedState.CutRate = CutRate;
                    SavedState.CrookedEndAngle = Conversion.SafeDouble(CrookedEndAngle);
                    SavedState.CrookedEndProtrusionAngle = null;
                    SavedState.CrookedEndViceContactAngle = null;
                    SavedState.DensityCorrectionFactor = Conversion.SafeDouble(DensityCorrection);
                    SavedState.SawCalibrationOffset = SawCalibrationOffset;

                    if (ShapeDimension != null)
                        SavedState.ShapeMeasurementId = ShapeDimension.ShapeMeasurementId;

                    SavedState.BilletDirectionBottomToTop = (BilletDirectionSelected == "Bottom To Top");

                    scc.SawCalcShopOrderSavedStates.Add(SavedState);
                    scc.SaveChanges();
                }
            }

            return success;
        }

        public bool SaveNewWeight(string userName, string pcName)
        {
            bool success = false;

            SawCalcBillets scb = new SawCalcBillets();
            SawCalcPieces scp = new SawCalcPieces();
            SawCalcPersons per = new SawCalcPersons();
            SawCalcComputers com = new SawCalcComputers();
            SawCalcBlades bld = new SawCalcBlades();
            SawCalcSaws saw = new SawCalcSaws();

            using (SawCalcContext scc = new SawCalcContext())
            {
                if (ShopOrder.ShopOrderId == 0)
                    ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(DiscreteJobSelected)).FirstOrDefault();

                if (ShopOrder != null)
                {
                    scp.ShopOrderId = ShopOrder.ShopOrderId;
                    scp.CreatedDate = DateTime.Now;

                    per = scc.SawCalcPersons.Where(x => x.UserId.Equals(userName)).FirstOrDefault();

                    if (per != null)
                    {
                        scp.OperatorId = per.PersonId;
                        scp.LastModifiedBy = per.Name;
                        scp.LastModifiedDate = DateTime.Now;
                    }

                    com = scc.SawCalcComputers.Where(x => x.ComputerName.Equals(pcName)).FirstOrDefault();

                    if (com != null)
                        scp.ComputerId = com.ComputerId;

                    scp.MultSerialNumber = UnfinishedSerialNumberSelected;

                    //Assign default in case subsequent lines yield nothing; Rajeev set up a screwey db schema
                    // that you are obligated to follow
                    scp.BilletId = 1;

                    if (LotNumberSelected != null)
                    {
                        string[] splitValue = LotNumberSelected.Split('.');

                        if (splitValue.Length > 1)
                        {
                            string heatNumber = splitValue[0];
                            string billetNumber = splitValue[1];

                            scb = scc.SawCalcBillets.Where(x => x.HeatNumber.Equals(heatNumber) && x.BilletNumber.Equals(billetNumber)).FirstOrDefault();

                            if (scb != null)
                                scp.BilletId = Conversion.SafeInteger(scb.BilletId);
                        }
                    }

                    bld = scc.SawCalcBlades.Where(x => x.BladeName.Equals(BladeSelected)).FirstOrDefault();

                    if (bld == null)
                        scp.BladeId = 1;
                    else
                        scp.BladeId = Conversion.SafeInteger(bld.BladeId);

                    saw = scc.SawCalcSaws.Where(x => x.SawName.Equals(SawMachineSelected)).FirstOrDefault();

                    if (saw == null)
                        scp.SawId = 1;
                    else
                        scp.SawId = saw.SawId;

                    scp.IsMult = (PieceTypeString == "MULT");
                    scp.IsProlong = (PieceTypeString == "PROLONG");
                    scp.IsRemnant = (PieceTypeString == "REMNANT");
                    scp.IsException = (PieceTypeString == "EXCEPTION");

                    scp.ActualWeight = Conversion.SafeDouble(ActualWeight);
                    scp.TargetWeight = Conversion.SafeDouble(TargetWeight);

                    scp.Tpi = Conversion.SafeDouble(TpiRangeSelected.Substring(0, 3));
                    scp.Kerf = Conversion.SafeDouble(Kerf);
                    scp.IdealTargetLength = Conversion.SafeDouble(LengthParameters.CalculatedTargetLength);
                    scp.AdjustedTargetLength = Conversion.SafeDouble((LengthParameters.CalculatedTargetLength + CrookedEndAdjustment) * DensityCorrection);
                    scp.CutRate = Conversion.SafeDouble(CutRate);
                    scp.SawCalibrationOffset = Conversion.SafeDouble(SawCalibrationOffset);
                    scp.ActualCutTime = ActualTimeLastCut;
                    scp.BladeSpeed = Conversion.SafeDouble(BladeSpeed);
                    scp.IssueNotes = null;

                    if (LengthParameters != null)
                        scp.AverageCrossSectionArea = LengthParameters.CrossSectionArea;

                    scp.CrookedEndAngle = Conversion.SafeDouble(CrookedEndAngle);

                    if (ShapeDimension != null)
                        scp.ShapeMeasurementId = ShapeDimension.ShapeMeasurementId;

                    scp.DensityCorrectionFactor = Conversion.SafeDouble(DensityCorrection);

                    scp.IsDeleted = false;

                    //Add it to the present instance collection, then...
                    Pieces.Add(scp);
                    // add it to the database
                    scc.Add(scp);
                    scc.SaveChanges();
                }
            }

            return success;
        }

        #endregion
    }

    public enum PieceType
    {
        NotSpecified
        , Mult
        , Prolong
        , Remnant
        , Exception
    }
}
