using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Wildcat.Entities.CFCA.Saws;

namespace Wildcat.App.ViewModels.Saws
{
    public class SawPieceModel
    {
        #region Properties

        public SawCalcShopOrders ShopOrder { get; set; }

        public int shopOrderId { get; set; }
        public List<SawPieceResult> SawPieceResult { get; set; }

        public List<SawCalcShopOrderSerialNumbers> SerialNumbers { get; set; }

        public string SerialNumberRangeString { get; set; }

        #endregion Properties

        #region Constructors

        public SawPieceModel(int ShopOrderId)
        {
            shopOrderId = ShopOrderId;

            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderId.Equals(shopOrderId)).FirstOrDefault();
            }
        }

        public SawPieceModel(string loc, string son)
        {
            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();
                shopOrderId = ShopOrder.ShopOrderId;
            }
        }

        public void LoadData(bool MultsOnly)
        {
            SawPieceResult = new List<SawPieceResult>();

            using (SawCalcContext scc = new SawCalcContext())
            {
                SawPieceResult spr;

                string _connectString = @"server=WGFC-DEV-SQL01,1433;Database=SawCalc;user id=sawcalc;password=sawcalc123!!;";
                using (SqlConnection con = new SqlConnection(_connectString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.GetSawPieces", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ShopOrderID", shopOrderId));

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        spr = new SawPieceResult();

                        spr.ShopOrderID = Convert.ToInt32(sdr["ShopOrderID"]);
                        spr.ShopOrderNumber = sdr["ShopOrderNumber"].ToString();

                        spr.Customer = sdr["Customer"].ToString();
                        spr.PartNumber = sdr["PartNumber"].ToString();
                        spr.MaterialName = sdr["MaterialName"].ToString();
                        spr.PreparedBy = sdr["PreparedBy"].ToString();
                        spr.Specification = sdr["Specification"].ToString();
                        spr.BilletShape = sdr["BilletShape"].ToString();
                        spr.Mill = sdr["Mill"].ToString();

                        spr.PieceID = Convert.ToInt32(sdr["PieceID"]);
                        spr.CreatedDate = Convert.ToDateTime(sdr["CreatedDate"]);

                        spr.LotNumber = string.Format("{0}.{1}", sdr["HeatNumber"], sdr["BilletNumber"]);

                        if (!string.IsNullOrEmpty(sdr["PieceIndex"].ToString()))
                            spr.PieceIndex = Convert.ToInt32(sdr["PieceIndex"]);

                        if (Convert.ToBoolean(sdr["IsMult"]))
                            spr.PieceType = "Mult";
                        else if (Convert.ToBoolean(sdr["IsProlong"]))
                            spr.PieceType = "Prolong";
                        else if (Convert.ToBoolean(sdr["IsException"]))
                            spr.PieceType = "Exception";
                        else
                            spr.PieceType = "Remnant";

                        spr.HeatNumber = Convert.ToString(sdr["HeatNumber"]);
                        spr.BilletNumber = Convert.ToString(sdr["BilletNumber"]);

                        spr.NewBilletWeight = Convert.ToDouble(sdr["NewBilletWeight"]);

                        spr.MultID = Convert.ToString(sdr["MultID"]);
                        spr.SerialNumber = Convert.ToString(sdr["MultSerialNumber"]);

                        spr.TargetWeight = Convert.ToDouble(sdr["TargetWeight"]);
                        spr.ActualWeight = Convert.ToDouble(sdr["ActualWeight"]);
                        spr.AdjustedTargetLength = Convert.ToDouble(sdr["AdjustedTargetLength"]);
                        spr.AverageCrossSectionArea = Convert.ToDouble(sdr["AverageCrossSectionArea"]);
                        spr.DensityCorrectionFactor = Convert.ToDouble(sdr["DensityCorrectionFactor"]);
                        spr.Kerf = Convert.ToDouble(sdr["Kerf"]);

                        spr.Location = Convert.ToString(sdr["Location"]);

                        if (MultsOnly && spr.PieceType != "Mult")
                        {
                            //Do nothing
                        }
                        else
                        {
                            SawPieceResult.Add(spr);
                        }
                    }
                }

                SawPieceResult = SawPieceResult.OrderBy(x => x.CreatedDate).ToList();
            }

            #endregion Constructors
        }

        public void PopulateSerialNumbers()
        {
            StringBuilder sb = new StringBuilder();

            using (SawCalcContext scc = new SawCalcContext())
            {
                SerialNumbers = scc.SawCalcShopOrderSerialNumbers.Where(x => x.ShopOrderId.Equals(shopOrderId)).OrderBy(x => x.MultSerialNumber).ToList();
            }

            if (SerialNumbers.Count > 0)
            {
                sb.Append(SerialNumbers.First().MultSerialNumber);
                sb.Append(" -> ");
                sb.Append(SerialNumbers.Last().MultSerialNumber);
            }

            SerialNumberRangeString = sb.ToString();
        }
    }

    public class SawPieceResult
    {
        public int ShopOrderID { get; set; }

        public string ShopOrderNumber { get; set; }

        public string Customer { get; set; }
        public string PartNumber { get; set; }

        public string MaterialName { get; set; }

        public string PreparedBy { get; set; }

        public string Specification { get; set; }

        public string BilletShape { get; set; }

        public string Mill { get; set; }

        //public DateTime LastModifiedDate { get; set; }

        public int PieceID { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd H:mm}")]
        public DateTime CreatedDate { get; set; }

        public bool IsMult { get; set; }
        public bool IsProlong { get; set; }
        public bool IsRemnant { get; set; }
        public bool IsException { get; set; }
        public string HeatNumber { get; set; }

        public string BilletNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        public double NewBilletWeight { get; set; }

        public string MultID { get; set; }

        //public string MultSerialNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        public double TargetWeight { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        public double ActualWeight { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}")]
        public double AdjustedTargetLength { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}")]
        public double AverageCrossSectionArea { get; set; }

        [DisplayFormat(DataFormatString = "{0:N3}")]
        public double DensityCorrectionFactor { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        public double Kerf { get; set; }

        public string LotNumber { get; set; }
        public int? PieceIndex { get; set; }
        public string PieceType { get; set; }
        public string SerialNumber { get; set; }

        public string Location { get; set; }
    }
}