
using Aspose.Cells;
//using Aspose.Imaging;
//using Aspose.Imaging.Brushes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading;
using Wildcat.App.SHCA.ViewModels.Engineering;

namespace Wildcat.App.Controllers.Engineering
{
    [Area("SHCA")]
    public class BaghouseController : Controller
    {
        private License _license = new License();
        private BaghouseReport _baghouseReport = new BaghouseReport();

        public BaghouseController()
        {
        }

        [HttpGet]
        public ActionResult Index()
        {
            _license.SetLicense(Environment.CurrentDirectory + @"\ThirdPartyDLLs\Aspose.Total.lic");

            return View(_baghouseReport);
        }

        [HttpGet]
        public IActionResult Download(BaghouseReport baghouseReport)
        {
            //TODO commented out due to issues with Baghouse
            string exportFileName = ""; // baghouseReport.MakeSpreadsheet();

            //while (baghouseReport.ProcessingDownload)
            //{
            //    Thread.Sleep(1000);
            //}

            string exportFilePath = @"C:\TEMP\";

            FileStream str = System.IO.File.OpenRead(Path.Combine(exportFilePath, exportFileName));
            FileStreamResult fsr = new FileStreamResult(str, "application/vnd.ms-excel");
            fsr.FileDownloadName = exportFileName;

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

    //    public class MyDynamicClass
    //    {
    //        string imagePath = @"C:\Users\steve.owens\source\repos\MyWatermarkTestSolution\MyWatermarkTest\preview.jpg";
    //        string rootPath = @"C:\Users\steve.owens\source\repos\MyWatermarkTestSolution\MyWatermarkTest\";
    //        static readonly string _licensePath = @"C:\Users\steve.owens\source\repos\MyWatermarkTestSolution\MyWatermarkTest\ThirdPartyDLLs\";

    //        License _license = new License();

    //        public MyDynamicClass()
    //        {
    //            _license.SetLicense(Path.Combine(_licensePath, "Aspose.Total.lic"));
    //        }

    //        public void MakeWaterMark()
    //        {
    //            using (Image image = Image.Load(imagePath))
    //            {
    //                Declare a String object with Watermark Text
    //                string theString = "45 Degree Rotated Text";

    //                Create and initialize an instance of Graphics class and Initialize an object of SizeF to store image Size
    //               Graphics graphics = new Graphics(image);
    //        SizeF sz = graphics.Image.Size;

    //        Creates an instance of Font, initialize it with Font Face, Size and Style
    //       Font font = new Font("Times New Roman", 20, FontStyle.Bold);

    //        Create an instance of SolidBrush and set its various properties
    //                SolidBrush brush = new SolidBrush();
    //        brush.Color = Color.Red;
    //                brush.Opacity = 0;

    //                 Initialize an object of StringFormat class and set its various properties
    //                StringFormat format = new StringFormat();
    //        format.Alignment = StringAlignment.Center;
    //                format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;

    //                 Create an object of Matrix class for transformation
    //                Matrix matrix = new Matrix();

    //        First a translation then a rotation
    //                matrix.Translate(sz.Width / 2, sz.Height / 2);
    //                matrix.Rotate(-45.0f);

    //                 Set the Transformation through Matrix
    //                graphics.Transform = matrix;

    //        Draw the string on Image Save output to disk
    //       graphics.DrawString(theString, font, brush, 0, 0, format);
    //        image.Save(rootPath + "AddDiagonalWatermarkToImage_out.jpg");
    //            }
    //}
    //    }
}