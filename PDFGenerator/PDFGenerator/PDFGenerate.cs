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
            XFont FontID = new XFont("Arial", 16);
            XFont FontName = new XFont("Arial", 16);
            XFont Font = new XFont("Arial", 14);
            XFont HeadingFont = new XFont("Arial", 24);

            //Margin Set ups
            int LeftM = 50;
            int RightM = 50;
            int TopM = 160;
            int BottomInfoStart = TopM + 20;
            int VerticalGap = 30;
            int LogoSize = 75;
            int LeftColumnStartX = LeftM;
            int LeftColumnWidth = 125;
            int RightColumnStartX = LeftColumnStartX + LeftColumnWidth;
            int RightColumnWidth = 250;

            //XPen pen = new XPen(XColors.White, 0);

            //Logo
            XImage Logo = XImage.FromFile(@"C:\Users\Admin\Desktop\Shiam\csPrograms\PDFGenerator\PDF\Images\login_logo.jpg");
            gfx.DrawImage(Logo, LeftM, 25, LogoSize, LogoSize);
            //Heading
            gfx.DrawString("PUBLIC WORKS DEPARTMENT", HeadingFont, XBrushes.Black, new XPoint(LeftM+120, 35 + LogoSize/2));
            //Admit Card
            gfx.DrawRectangle(XBrushes.LightGray, 0, 110, page.Width, 35);
            gfx.DrawString("ADMIT CARD", new XFont("Arial", 22), XBrushes.Black, new XPoint(LeftM+190, 135));
            int TableStartY = TopM;
            int TableCellHeight = 30;
            for (int i = 0; i < 10; i++)
            {
                gfx.DrawRectangle(new XPen(XColors.Black, 1), XBrushes.LightGray, LeftColumnStartX, TableStartY + i*TableCellHeight, LeftColumnWidth, TableCellHeight);
                gfx.DrawRectangle(new XPen(XColors.Black, 1), XBrushes.White, RightColumnStartX, TableStartY + i*TableCellHeight, RightColumnWidth, TableCellHeight);

            }
            int LeftColumnM = LeftColumnStartX + 10;
            int RightColumnM = RightColumnStartX + 10;

            //writing text
            gfx.DrawString("ID: ", FontID, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart));
            gfx.DrawString(Convert.ToString(ID), FontID, XBrushes.Black, 
                new XPoint(RightColumnM, BottomInfoStart));
            
            gfx.DrawString("Full Name: ", FontName, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap));
            gfx.DrawString(Convert.ToString(Name), FontName, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap));

            gfx.DrawString("Phone Number: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart+ VerticalGap*2));
            gfx.DrawString(Convert.ToString(Phone), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart+ VerticalGap*2));

            gfx.DrawString("Email Address: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*3));
            gfx.DrawString(Convert.ToString(Email), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*3));

            gfx.DrawString("Father's Name: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*4));
            gfx.DrawString(Convert.ToString(FatherName), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*4));

            gfx.DrawString("Mother's Name: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*5));
            gfx.DrawString(Convert.ToString(MotherName), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*5));

            gfx.DrawString("Date of Birth: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*6));
            gfx.DrawString(Convert.ToString(DateOfBirth), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*6));

            gfx.DrawString("Address: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*7));
            gfx.DrawString(Convert.ToString(Address), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*7));

            gfx.DrawString("Religion: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*8));
            gfx.DrawString(Convert.ToString(Religion), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*8));

            gfx.DrawString("Nationality: ", Font, XBrushes.Black,
                new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*9));
            gfx.DrawString(Convert.ToString(Nationality), Font, XBrushes.Black,
                new XPoint(RightColumnM, BottomInfoStart + VerticalGap*9));


            XImage ImgProfile = XImage.FromFile(@"C:\Users\Admin\Desktop\Shiam\csPrograms\PDFGenerator\PDF\Images\shk_old.png");
            gfx.DrawImage(ImgProfile, page.Width - RightM - 100, TopM, 100, 125);

            int BarCodeWidth = 200;

            string BarNum = Convert.ToString(ID);
            XImage ImgBarcode = XImage.FromFile(BarcodeGenerator.GenerateBarcode(BarNum, SrcDir));
            gfx.DrawImage(ImgBarcode, page.Width/2-BarCodeWidth/2, 490, BarCodeWidth, 50);

            //XPen pen = new XPen(XColors.Black, 1);
            //gfx.DrawRectangle(pen, 10, 0, 100, 60);
            


            document.Save(SrcDir + ID + ".pdf");


        }
    }
}
