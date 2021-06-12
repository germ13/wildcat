
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wildcat.Entities.CFCA.Planning;
using Wildcat.Entities.CFCA.Saws;
using Wildcat.Utilities;

namespace Wildcat.Logic.CFCA.Saws
{
    public class MultChartExporter
    {
        private string _jobNumber { get; set; }

        //private string _oracleFtpServer = "apollo.wyman.com";
        //TEMP FOR TESTING!!!!!!!!!!!!!!
        private string _oracleFtpServer = "sutton.precastcorp.com";
        private string _oracleFtpPassword = "a510nonprd";
        private string _oracleFtpFolder = string.Empty;
        private string _oracleFtpUser = "appdevcf";

        private List<CfwAccuInventory> _inventoryRows = null;
        private CfwAccuPlanHeader _planHeader = null;
        private string _serialNumbersFilePath;
        private string _cutBilletsFilePath;

        private List<CutBillet> GetCutBillets(int ShopOrderID, ref string feedback)
        {
            List<CutBillet> cutBillets = new List<CutBillet>();

            using (SawCalcContext scc = new SawCalcContext())
            {
                List<IGrouping<int, SawCalcPieces>> billetsWithMults =
                (
                    from SawCalcPieces mult in scc.SawCalcPieces.Where(x => x.ShopOrderId.Equals(ShopOrderID))
                    orderby mult.PieceId
                    group mult by mult.BilletId into billetMults
                    orderby billetMults.Min(mult => mult.PieceId)
                    select billetMults
                ).ToList();

                List<string> allMultSerialNumbers =
                    (
                    from SawCalcShopOrderSerialNumbers soSerialNumber in scc.SawCalcShopOrderSerialNumbers.Where(x => x.ShopOrder.Equals(ShopOrderID))
                    select soSerialNumber.MultSerialNumber
                    )
                    .ToList();

                foreach (IEnumerable<SawCalcPieces> piecesInBillet in billetsWithMults)
                {
                    List<SawCalcPieces> piecesInBilletList = piecesInBillet.ToList();
                    SawCalcPieces firstPiece = piecesInBilletList[0];

                    SawCalcShopOrderBillets shopOrderBillet =
                        scc.SawCalcShopOrderBillets.Where(x => x.ShopOrderId.Equals(ShopOrderID) && x.BilletId.Equals(firstPiece.BilletId)).FirstOrDefault();

                    if (shopOrderBillet == null)
                    {
                        continue;
                    }

                    SawCalcPieces remnantPiece = GetRemnantPiece(piecesInBilletList, shopOrderBillet, ref feedback);
                    double remnantWeight = (remnantPiece == null) ? 0 : remnantPiece.ActualWeight;

                    //NOT IN RAJEEV CODE
                    SawCalcBillets billet = scc.SawCalcBillets.Where(x => x.BilletId.Equals(firstPiece.BilletId)).FirstOrDefault();
                    firstPiece.Billet = billet;
                    SawCalcMaterials material = scc.SawCalcMaterials.Where(x => x.MaterialId.Equals(billet.MaterialId)).FirstOrDefault();

                    CutBillet cutBillet = new CutBillet()
                    {
                        BilletNumber = firstPiece.Billet.BilletNumber,
                        HeatNumber = firstPiece.Billet.HeatNumber,
                        TotalWeightConsumed = shopOrderBillet.NewBilletWeight - remnantWeight,
                        CutPieces = new List<CutPiece>()
                    };

                    cutBillets.Add(cutBillet);

                    foreach (SawCalcPieces piece in piecesInBillet)
                    {
                        if (piece.MultSerialNumber != null)
                        {
                            CutPiece cutPiece = new CutPiece();

                            cutPiece.ActualWeight = piece.ActualWeight;

                            if (piece.IsMult)
                                cutPiece.CutPieceType = CutPieceType.Mult;
                            else if (piece.IsException)
                                cutPiece.CutPieceType = CutPieceType.Exception;
                            else if (piece.IsProlong)
                                cutPiece.CutPieceType = CutPieceType.Prolong;
                            else
                                cutPiece.CutPieceType = CutPieceType.Remnant;

                            cutPiece.KerfWeight = piece.Kerf * piece.AverageCrossSectionArea * material.Density;
                            cutPiece.SerialNumbers = this.GetSerialNumbers(scc, allMultSerialNumbers, piece, ref feedback);

                            cutBillet.CutPieces.Add(cutPiece);
                        }
                    }
                }
            }

            return cutBillets;
        }

        private List<string> GetSerialNumbers
            (
            SawCalcContext scc,
            List<string> allMultSerialNumbers,
            SawCalcPieces piece,
            ref string feedback
            )
        {
            List<string> pieceSerialNumbers = new List<string>();

            int? indexOfFirstSerialNumber = this.IndexOf(allMultSerialNumbers, piece.MultSerialNumber);
            if (!indexOfFirstSerialNumber.HasValue)
            {
                feedback = String.Format("Could not submit mult chart, because serial number \"{0}\" was not found in the database.", piece.MultSerialNumber);
            }

            string lastMultSerialNumber = piece.LastMultSerialNumber ?? piece.MultSerialNumber;
            int? indexOfLastSerialNumber = this.IndexOf(allMultSerialNumbers, lastMultSerialNumber);
            if (!indexOfLastSerialNumber.HasValue)
            {
                feedback = String.Format("Could not submit mult chart, because serial number \"{0}\" was not found in the database.", lastMultSerialNumber);
            }

            for (int i = indexOfFirstSerialNumber.Value; ; i = (i + 1) % allMultSerialNumbers.Count)
            {
                pieceSerialNumbers.Add(allMultSerialNumbers[i]);

                if (i == indexOfLastSerialNumber.Value)
                {
                    break;
                }
            }

            return pieceSerialNumbers;
        }

        private int? IndexOf
            (
            List<string> all,
            string find
            )
        {
            for (int i = 0; i < all.Count; i++)
            {
                if (StringHelper.IsRoughlyEqual(all[i], find))
                {
                    return i;
                }
            }

            return null;
        }

        private SawCalcPieces GetRemnantPiece
            (
            List<SawCalcPieces> piecesInBilletList,
            SawCalcShopOrderBillets shopOrderBillet,
            ref string feedback
            )
        {
            SawCalcPieces remnantPiece = piecesInBilletList.SingleOrDefault(piece => piece.IsRemnant);
            if (remnantPiece == null)
            {
                double weightsOfAllPieces = piecesInBilletList.Sum(piece => piece.ActualWeight);
                double weightsOfAllKerfs = piecesInBilletList.Sum(piece =>
                    (piece.Kerf * piece.AverageCrossSectionArea * shopOrderBillet.Billet.Material.Density));
                double expectedWeightOfRemnant = shopOrderBillet.NewBilletWeight - weightsOfAllKerfs - weightsOfAllPieces;
                if (expectedWeightOfRemnant > piecesInBilletList.Count)
                {
                    feedback = "Before submitting the mult chart, you must record the actual weight of the remnant " +
                        "for each of the billets that you cut.";
                }
            }

            return remnantPiece;
        }

        private CutPieceType GetPieceType(SawCalcPieces Piece)
        {
            CutPieceType rtv;

            if (Piece.IsMult)
                rtv = CutPieceType.Mult;
            else if (Piece.IsProlong)
                rtv = CutPieceType.Prolong;
            else if (Piece.IsRemnant)
                rtv = CutPieceType.Remnant;
            else
                rtv = CutPieceType.Exception;

            return rtv;
        }

        public string UpdateOracleData(SawCalcShopOrders ShopOrder)
        {
            string feedback = string.Empty;

            _jobNumber = ShopOrder.ShopOrderNumber;

            List<CutBillet> cutBillets = GetCutBillets(ShopOrder.ShopOrderId, ref feedback);

            if (feedback.Length > 0)
                return feedback;

            if (cutBillets.Count == 0)
            {
                feedback = "Could not publish mult chart because piece data could not be found";

                return feedback;
            }

            List<string> weightLines = new List<string>();
            List<string> snHeatLines = new List<string>();

            weightLines.Add("WIP_ENTITY_ID,WIP_ENTITY_NAME,RAW_MATERIAL_PART_NUMBER,RAW_MATERIAL_ID,LOT_NUMBER,Cut Weight,UOM,CutFlag");
            snHeatLines.Add("SN_ASSIGNMENT_ID,WIP_ENTITY_ID,WIP_ENTITY_NAME,SERIAL_NUMBER,RAW_MATERIAL_PART_NUMBER,RAW_MATERIAL_ID,LOT_NUMBER,MULT_WT");

            using (ModelContext mct = new ModelContext())
            {
                _planHeader = mct.CfwAccuPlanHeader.Where(x => x.WipEntityName.Equals(ShopOrder.ShopOrderNumber)).FirstOrDefault();

                string lotNumber = string.Empty;

                foreach (CutBillet cutBillet in cutBillets)
                {
                    lotNumber = string.Format("{0}.{1}", cutBillet.HeatNumber, cutBillet.BilletNumber);

                    CfwAccuInventory inventoryRow = mct.CfwAccuInventory.Where(x => x.LotNumber.Equals(lotNumber)).FirstOrDefault();

                    if (inventoryRow == null)
                        continue;

                    weightLines.Add
                    (
                        GetLine
                        (
                            Conversion.SafeString(_planHeader.WipEntityId),
                            ShopOrder.ShopOrderNumber,
                            inventoryRow.RmItemNumber,
                            Conversion.SafeString(inventoryRow.InventoryItemId),
                            inventoryRow.LotNumber,
                            Conversion.SafeDouble(cutBillet.TotalWeightConsumed).ToString("F1"),
                            "LB",
                            "Y"
                        )
                    );

                    List<CfwAccuSn> serialNumberRows = mct.CfwAccuSn.Where(x => x.WipEntityName.Equals(ShopOrder.ShopOrderNumber)).ToList();

                    foreach (CutPiece cutPiece in cutBillet.CutPieces)
                    {
                        bool firstSerialNumberInMult = true;

                        foreach (string serialNumber in cutPiece.SerialNumbers)
                        {
                            CfwAccuSn serialNumberRow = serialNumberRows.Where(x => x.CustomerSerialNumber.ToUpper().Trim().Equals(serialNumber.ToUpper().Trim())).FirstOrDefault();

                            if (serialNumberRow == null)
                            {
                                continue;
                            }

                            snHeatLines.Add
                            (
                                GetLine
                                (
                                    Conversion.SafeString(serialNumberRow.SnAssignmentId),
                                    Conversion.SafeString(serialNumberRow.WipEntityId),
                                    ShopOrder.ShopOrderNumber,
                                    serialNumberRow.SerialNumber,
                                    inventoryRow.RmItemNumber,
                                    Conversion.SafeString(inventoryRow.InventoryItemId),
                                    lotNumber,
                                    firstSerialNumberInMult ? cutPiece.ActualWeight.ToString("F1") : "0"
                                )
                            );

                            firstSerialNumberInMult = false;
                        }
                    }
                }
            }

            string tempFolder = @"C:\TEMP\";

            _cutBilletsFilePath = Path.Combine(tempFolder, String.Format("AccuJobCutWeight_{0}_{1}.csv", _jobNumber, DateTime.Now.ToString("yyyyMMdd_HHmmss")));
            _serialNumbersFilePath = Path.Combine(tempFolder, String.Format("AccuSerialHeatAssign_{0}_{1}.csv", _jobNumber, DateTime.Now.ToString("yyyyMMdd_HHmmss")));

            File.WriteAllLines(_cutBilletsFilePath, weightLines.ToArray());
            File.WriteAllLines(_serialNumbersFilePath, snHeatLines.ToArray());

            List<string> fullPathsToFtp = new List<string>();

            fullPathsToFtp.Add(_cutBilletsFilePath);
            fullPathsToFtp.Add(_serialNumbersFilePath);

            feedback = FtpFilesToOracle(fullPathsToFtp);

            return feedback;
        }

        private string GetLine(params string[] fields)
        {
            return String.Join(",", fields);
        }

        private string FtpFilesToOracle(List<string> localFileFullPaths)
        {
            string feedback = string.Empty;

            FileTransferProtocol ftp = new FileTransferProtocol();

            try
            {
                ftp.Put(_oracleFtpServer, _oracleFtpUser, _oracleFtpPassword, "", localFileFullPaths);
            }
            catch (Exception exc)
            {
                feedback = "Issue: " + exc.Message;
            }

            return feedback;
        }
    }
}
