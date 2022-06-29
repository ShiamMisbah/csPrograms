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
        
        public static void BarcodePDFGenerator(string SrcDir, int ID, string Name, int Phone, string Email, string FatherName, string MotherName, string DateOfBirth, string Address, string Religion, string Nationality)
        {
            
            PdfDocument document = new PdfDocument();
            //New page
            PdfPage page = document.AddPage();
            //graphics and stuffs
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //font
            XFont FontID = new XFont("Arial", 24);
            XFont FontName = new XFont("Arial", 18);
            XFont Font = new XFont("Arial", 15);
            XFont BanglaFont = new XFont("SolaimanLipi", 12);
            // Margin Set ups
            int LeftM = 50;
            int RightM = 50;
            int TopM = 150;
            int BottomM = 150;
            int BottomInfoStart = 325;
            int VerticalGap = 30;

            //writing text


            gfx.DrawString("ID: "+ Convert.ToString(ID), FontID, XBrushes.Black,
                new XPoint(LeftM, 150));
            gfx.DrawString("Full Name: " + Convert.ToString(Name), FontName, XBrushes.Black,
                new XPoint(LeftM, 200));

            gfx.DrawString("Phone Number: "+Convert.ToString(Phone), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart));
            gfx.DrawString("Email Address: "+Convert.ToString(Email), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap));
            gfx.DrawString("Father's Name: "+ Convert.ToString(FatherName), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*2));
            gfx.DrawString("Mother's Name: "+ Convert.ToString(MotherName), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*3));
            gfx.DrawString("Date of Birth: "+ Convert.ToString(DateOfBirth), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*4));
            gfx.DrawString("Address: "+ Convert.ToString(Address), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*5));
            gfx.DrawString("Religion: "+ Convert.ToString(Religion), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*7));           
            gfx.DrawString("Nationality: "+ Convert.ToString(Nationality), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*8));

            XImage ImgProfile = XImage.FromFile(@"C:\Users\Administrator\Desktop\Shiam\C#\csPrograms\PDFGenerator\PDF\Images\shk_old.png");
            gfx.DrawImage(ImgProfile, 400, TopM-20,150,175);

            string BarNum = Convert.ToString(ID);
            XImage ImgBarcode = XImage.FromFile(BarcodeGenerator.GenerateBarcode(BarNum, SrcDir));
            gfx.DrawImage(ImgBarcode, 400, 700,150,50);
            document.Save(SrcDir + ID + ".pdf");

        }
    }
}
