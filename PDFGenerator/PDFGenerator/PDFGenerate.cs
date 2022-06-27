using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PDFGenerator
{
    class PDFGenerate
    {
        
        public static void BarcodePDFGenerator(string SrcDir, int ID, string Name, int Phone, string Email, bool IsCandidate)
        {
            Random random = new Random();
            string BarNum = Convert.ToString(random.Next(10000000));
            PdfDocument document = new PdfDocument();
            //New page
            PdfPage page = document.AddPage();
            //graphics and stuffs
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //font
            XFont fontID = new XFont("Arial", 24);
            XFont fontName = new XFont("Arial", 18);
            XFont fontPhone = new XFont("Arial", 12);
            XFont fontEmail = new XFont("Arial", 12);
            //writing text
            if (IsCandidate)
            {
                gfx.DrawString(Convert.ToString(ID), fontID, XBrushes.Green,
                    new XPoint(50, 50));
                gfx.DrawString(Convert.ToString(Name), fontName, XBrushes.Green,
                    new XPoint(150, 50));
            }
            else
            {
                gfx.DrawString(Convert.ToString(ID), fontID, XBrushes.Red,
                    new XPoint(50, 50));
                gfx.DrawString(Convert.ToString(Name), fontName, XBrushes.Red,
                    new XPoint(150, 50));
            }


            
            gfx.DrawString(Convert.ToString(Phone), fontPhone, XBrushes.Black,
                new XPoint(50, 100));
            gfx.DrawString(Convert.ToString(Email), fontEmail, XBrushes.Black,
                new XPoint(150, 100));

            

            XImage img = XImage.FromFile(BarcodeGenerator.GenerateBarcode(BarNum, SrcDir));
            gfx.DrawImage(img, 400, 650, 200, 125);
            document.Save(SrcDir + BarNum + ".pdf");

        }
    }
}
