using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PDFGenerator
{
    class BarcodeGenerator 
    { 
        public static void GenerateBarcode(string BarNum,string dir)
        {
            var barcode = BarcodeWriter.CreateBarcode(BarNum, BarcodeEncoding.Code128);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SaveAsPng(dir + BarNum + ".png");
        }
        public static void BarcodeImageGenerator(string BarNum, string SrcDir)
        {
            PdfDocument document = new PdfDocument();
            //New page
            PdfPage page = document.AddPage();
            //graphics and stuffs
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //font
            XFont font = new XFont("Arial", 20);
            //writing text
            gfx.DrawString("My name is Tusdgagrjo", font, XBrushes.Blue,
                new XRect(50, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString("My name is Not Haba Haba Turjo", font, XBrushes.Red,
                new XPoint(50, 150));
            XImage img = XImage.FromFile(SrcDir + BarNum + ".png");
            gfx.DrawImage(img, 400, 650,200,125);
            document.Save(SrcDir + BarNum +".pdf");

        }
    }

}
