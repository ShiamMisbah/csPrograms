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
            XFont FontID = new XFont("Arial", 20);
            XFont FontName = new XFont("Arial", 18);
            XFont Font = new XFont("Arial", 15);
            XFont BanglaFont = new XFont("SolaimanLipi", 12);
            XFont HeadingFont = new XFont("Arial", 28);

            //Margin Set ups
            int LeftM = 50;
            int RightM = 50;
            int TopM = 300;
            int BottomM = 150;
            int BottomInfoStart = 320;
            int VerticalGap = 30;
            int LeftColumnStartX = LeftM;
            int LeftColumnWidth = 125;
            int RightColumnStartX = LeftColumnStartX + LeftColumnWidth;
            int RightColumnWidth = 250;

            //XPen pen = new XPen(XColors.White, 0);

            //Logo
            XImage Logo = XImage.FromFile(@"C:\Users\Admin\Desktop\Shiam\csPrograms\PDFGenerator\PDF\Images\login_logo.jpg");
            gfx.DrawImage(Logo, page.Width/2 - 50, 25, 100, 100);
            //Heading
            gfx.DrawRectangle(XBrushes.LightGray, 0, 200, page.Width, 35);
            gfx.DrawString("PUBLIC WORKS DEPARTMENT", HeadingFont, XBrushes.Black, new XPoint(LeftM+50, 175));
            //Admit Card
            gfx.DrawString("ADMIT CARD", new XFont("Arial", 22), XBrushes.Black, new XPoint(LeftM+190, 225));
            int TableStartY = 300;
            int TableCellHeight = 30;
            for (int i = 0; i < 10; i++)
            {
                gfx.DrawRectangle(new XPen(XColors.Black, 1), XBrushes.LightGray, LeftColumnStartX, TableStartY + i*TableCellHeight, LeftColumnWidth, TableCellHeight);
                gfx.DrawRectangle(new XPen(XColors.Black, 1), XBrushes.White, RightColumnStartX, TableStartY + i*TableCellHeight, RightColumnWidth, TableCellHeight);

            }
            int LeftColumnM = LeftColumnStartX + 10;
            int RightColumnM = RightColumnStartX + 10;

            //writing text
            //gfx.DrawString("ID: "+ Convert.ToString(ID), FontID, XBrushes.Black,
            //    new XPoint(LeftM, TopM));
            //gfx.DrawString("Full Name: " + Convert.ToString(Name), FontName, XBrushes.Black,
            //    new XPoint(LeftM, TopM+30));

            gfx.DrawString("Phone Number: "+Convert.ToString(Phone), Font, XBrushes.Black,
                new XPoint(LeftM+10, BottomInfoStart));
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
                new XPoint(LeftM, BottomInfoStart + VerticalGap*6));
            gfx.DrawString("Nationality: "+ Convert.ToString(Nationality), Font, XBrushes.Black,
                new XPoint(LeftM, BottomInfoStart + VerticalGap*7));

            

            XImage ImgProfile = XImage.FromFile(@"C:\Users\Admin\Desktop\Shiam\csPrograms\PDFGenerator\PDF\Images\shk_old.png");
            gfx.DrawImage(ImgProfile, page.Width - RightM - 100, TopM, 100, 125);

            string BarNum = Convert.ToString(ID);
            XImage ImgBarcode = XImage.FromFile(BarcodeGenerator.GenerateBarcode(BarNum, SrcDir));
            gfx.DrawImage(ImgBarcode, page.Width - RightM - 110, 450, 120, 50);

            //XPen pen = new XPen(XColors.Black, 1);
            //gfx.DrawRectangle(pen, 10, 0, 100, 60);
            


            document.Save(SrcDir + ID + ".pdf");


        }
    }
}
