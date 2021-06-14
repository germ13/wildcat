using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Wildcat.Entities.CFCA.Saws;

namespace Wildcat.App.ViewModels.Saws
{
    public class SawSerialNumberModel
    {
        public SawCalcShopOrders ShopOrder { get; set; }

        public int shopOrderId { get; set; }
        public List<SawSerialNumberResult> SawSerialNumberResult { get; set; }

        public string SerialNumberRangeString { get; set; }

        public SawSerialNumberModel(int ShopOrderId)
        {
            shopOrderId = ShopOrderId;

            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderId.Equals(shopOrderId)).FirstOrDefault();
            }
        }

        public SawSerialNumberModel(string loc, string son)
        {
            using (SawCalcContext scc = new SawCalcContext())
            {
                ShopOrder = scc.SawCalcShopOrders.Where(x => x.ShopOrderNumber.Equals(son)).FirstOrDefault();
                shopOrderId = ShopOrder.ShopOrderId;
            }
        }

        public void LoadData(bool MultsOnly)
        {
            SawSerialNumberResult = new List<SawSerialNumberResult>();

            using (SawCalcContext scc = new SawCalcContext())
            {
                SawSerialNumberResult snr;

                string _connectString = @"server=WGFC-DEV-SQL01,1433;Database=SawCalc;user id=sawcalc;password=sawcalc123!!;";

                using (SqlConnection con = new SqlConnection(_connectString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.GetSawSerialNumbers", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ShopOrderID", shopOrderId));

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        snr = new SawSerialNumberResult();

                        snr.ShopOrderID = Convert.ToInt32(sdr["ShopOrderID"]);
                        snr.HeatNumber = Convert.ToString(sdr["HeatNumber"]);
                        snr.PieceID = Convert.ToInt32(sdr["PieceID"]);
                        snr.MultSerialNumber = Convert.ToString(sdr["MultSerialNumber"]);
                        snr.SequenceNumber = Convert.ToInt32(sdr["SequenceNumber"]);
                        snr.PieceIndex = Convert.ToInt32(sdr["SequenceNumber"]); // Convert.ToInt32(sdr["PieceIndex"]);
                        snr.MultLetter = Convert.ToString(sdr["MultLetter"]);

                        SawSerialNumberResult.Add(snr);
                    }
                }
            }
        }

        public void PopulateSerialNumbers()
        {
            StringBuilder sb = new StringBuilder();

            if (SawSerialNumberResult.Count > 0)
            {
                sb.Append(SawSerialNumberResult.First().MultSerialNumber);
                sb.Append(" -> ");
                sb.Append(SawSerialNumberResult.Last().MultSerialNumber);
            }

            SerialNumberRangeString = sb.ToString();
        }
    }

    public class SawSerialNumberResult
    {
        public int ShopOrderID { get; set; }

        public string HeatNumber { get; set; }

        public int PieceID { get; set; }

        public string MultSerialNumber { get; set; }
        public int SequenceNumber { get; set; }

        public int PieceIndex { get; set; }

        public string MultLetter { get; set; }
    }
}