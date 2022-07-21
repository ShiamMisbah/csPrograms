using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using IronPdf;
using PdfSharp.Pdf.IO;

namespace PDFGenerator
{
    class PDFGenerate
    {
        
        public static void BarcodePDFGenerator(string SrcDir, int ID, string Name, int Phone, string Email, string DateOfBirth, string DocumentName, string Title)
        {
            string BarNum = Convert.ToString(ID);

            string Logodir = @"PDF/Images/login_logo.jpg";
            string htmlText = "<div class=\"container\" style=\"width: 700PX; height: 800px; padding: 30px 0px;display: flex; flex-direction: column; box-sizing: border-box; margin: 0 auto; border: 1px solid black; font-family: Arial, Helvetica, sans-serif;\">        <div class=\"header\" style=\"width: 100%;height: 120PX; display: flex;justify-content:left;align-items: center;padding: 0px 30px;\">            <div  style=\"width: 100px; height: 100px; margin: 20px 50px 20px 0px;\"></div>            <h1 style=\"font-size: 24px; font-weight: 300; margin: 0 0px;\">PUBLIC WORKS DEPARTMENT</h1>        </div>        <div class=\"admitHeader\" style=\"width: 100%; text-align: center; background-color:lightgray;\">            <h2 style=\"font-size: 22px; font-weight: 300\">ADMIT CARD</h2>        </div>        <div class=\"bodyContainer\" style=\" width:100%; box-sizing: border-box; display: flex;padding: 20px 30px;flex-wrap: nowrap;\">            <table style=\"width: 100%; font-size: 14px;\" cellspacing = 0>                              <tr style=\"height: 30px; font-size: 16px; \">                    <th style=\"border: 1px solid black;border-bottom: 0px; background-color: lightgray; text-align: left; padding-left: 20px;\">ID:</th>                    <td style=\"border: 1px solid black; border-bottom: 0px; padding-left: 10px;\" >" + ID + "</td>                                    </tr>                <tr style=\"height: 30px; font-size: 16px;\">                    <th style=\"border: 1px solid black;border-bottom: 0px; background-color: lightgray; text-align: left; padding-left: 20px;\">Full Name:</th>                    <td style=\"border: 1px solid black; border-bottom: 0px; padding-left: 10px;\" >"+ Name+ "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black;border-bottom: 0px; background-color: lightgray; text-align: left; padding-left: 20px;\">Mobile Number:</th>                    <td style=\"border: 1px solid black; border-bottom: 0px; padding-left: 10px;\" >" + Phone+ "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black; background-color: lightgray; text-align: left; padding-left: 20px;\">Email Address:</th>                    <td style=\"border: 1px solid black; padding-left: 10px;\" >"+ Email+ "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black; background-color: lightgray; text-align: left; padding-left: 20px;\">Date Of birth:</th>                    <td style=\"border: 1px solid black; padding-left: 10px;\" >"+DateOfBirth+"</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black; background-color: lightgray; text-align: left; padding-left: 20px;\">Title:</th>                    <td style=\"border: 1px solid black; padding-left: 10px;\" > "+Title+"</td>                </tr>                            </table>                        <img style=\"margin: 20px; margin-top: 0; width: 100px; height: 125px;\" src=\"Images/shk_old.PNG\" alt=\"\" srcset=\"\">        </div>        <div class=\"barcodeimage\" style=\"width: 100%;display:flex;justify-content:center; margin-top: 100px \">            <img src=\"barcodes/407426.png\" style=\"width: 200px; height:50px;\" alt=\"\" srcset=\"\">        </div>    </div>";
            string PdfDest = SrcDir + ID +".pdf";
            //string HtmlDes = SrcDir + ID + ".html";
            //File.WriteAllText(HtmlDes, htmlText);
            var htmltopdf = new HtmlToPdf();
            var pdfDoc = htmltopdf.RenderHtmlAsPdf(htmlText);
            pdfDoc.SaveAs(PdfDest);

            PdfSharp.Pdf.PdfDocument pdfDoc2 = PdfReader.Open(PdfDest, PdfDocumentOpenMode.Modify);
            PdfSharp.Pdf.PdfPage page = pdfDoc2.Pages[0];
            //PdfDocument document = PdfGenerator.GeneratePdf(htmlText, PdfSharp.PageSize.A4);

            //document.Save(SrcDir + ID +".pdf");
            //New page

            ////graphics and stuffs
            XGraphics gfx = XGraphics.FromPdfPage(page);
            ////font
            //XFont FontID = new XFont("Arial", 16);
            //XFont FontName = new XFont("Arial", 16);
            //XFont Font = new XFont("Arial", 14);
            //XFont HeadingFont = new XFont("Arial", 24);

            //Margin Set ups
            int LeftM = 115;
            int RightM = 50;
            int TopM = 160;
            int BottomInfoStart = TopM + 20;
            int VerticalGap = 30;
            int LogoSize = 55;
            int LeftColumnStartX = LeftM;
            int LeftColumnWidth = 125;
            int RightColumnStartX = LeftColumnStartX + LeftColumnWidth;
            int RightColumnWidth = 250;

            ////XPen pen = new XPen(XColors.White, 0);

            //Logo
            XImage Logo = XImage.FromFile(@"..\..\..\..\PDF\Images\login_logo.jpg");
            gfx.DrawImage(Logo, LeftM, 100, LogoSize, LogoSize);
            ////Heading
            //gfx.DrawString("PUBLIC WORKS DEPARTMENT", HeadingFont, XBrushes.Black, new XPoint(LeftM+120, 35 + LogoSize/2));
            ////Admit Card
            //gfx.DrawRectangle(XBrushes.LightGray, 0, 110, page.Width, 35);
            //gfx.DrawString("ADMIT CARD", new XFont("Arial", 22), XBrushes.Black, new XPoint(LeftM+190, 135));
            //int TableStartY = TopM;
            //int TableCellHeight = 30;
            //for (int i = 0; i < 5; i++)
            //{
            //    gfx.DrawRectangle(new XPen(XColors.Black, 1), XBrushes.LightGray, LeftColumnStartX, TableStartY + i*TableCellHeight, LeftColumnWidth, TableCellHeight);
            //    gfx.DrawRectangle(new XPen(XColors.Black, 1), XBrushes.White, RightColumnStartX, TableStartY + i*TableCellHeight, RightColumnWidth, TableCellHeight);

            //}
            //int LeftColumnM = LeftColumnStartX + 10;
            //int RightColumnM = RightColumnStartX + 10;

            ////writing text
            //gfx.DrawString("ID: ", FontID, XBrushes.Black,
            //    new XPoint(LeftColumnM, BottomInfoStart));
            //gfx.DrawString(Convert.ToString(ID), FontID, XBrushes.Black, 
            //    new XPoint(RightColumnM, BottomInfoStart));

            //gfx.DrawString("Full Name: ", FontName, XBrushes.Black,
            //    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap));
            //gfx.DrawString(Convert.ToString(Name), FontName, XBrushes.Black,
            //    new XPoint(RightColumnM, BottomInfoStart + VerticalGap));

            //gfx.DrawString("Mobile Number: ", Font, XBrushes.Black,
            //    new XPoint(LeftColumnM, BottomInfoStart+ VerticalGap*2));
            //gfx.DrawString(Convert.ToString(Phone), Font, XBrushes.Black,
            //    new XPoint(RightColumnM, BottomInfoStart+ VerticalGap*2));

            //gfx.DrawString("Email Address: ", Font, XBrushes.Black,
            //    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*3));
            //gfx.DrawString(Convert.ToString(Email), Font, XBrushes.Black,
            //    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*3));

            ////gfx.DrawString("Father's Name: ", Font, XBrushes.Black,
            ////    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*4));
            ////gfx.DrawString(Convert.ToString(FatherName), Font, XBrushes.Black,
            ////    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*4));

            ////gfx.DrawString("Mother's Name: ", Font, XBrushes.Black,
            ////    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*5));
            ////gfx.DrawString(Convert.ToString(MotherName), Font, XBrushes.Black,
            ////    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*5));

            //gfx.DrawString("Date of Birth: ", Font, XBrushes.Black,
            //    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*4));
            //gfx.DrawString(Convert.ToString(DateOfBirth), Font, XBrushes.Black,
            //    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*4));

            //gfx.DrawString("Title: ", Font, XBrushes.Black,
            //    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*5));
            //gfx.DrawString(Convert.ToString(Title), Font, XBrushes.Black,
            //    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*5));

            ////gfx.DrawString("Address: ", Font, XBrushes.Black,
            ////    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*7));
            ////gfx.DrawString(Convert.ToString(Address), Font, XBrushes.Black,
            ////    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*7));

            ////gfx.DrawString("Religion: ", Font, XBrushes.Black,
            ////    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*8));
            ////gfx.DrawString(Convert.ToString(Religion), Font, XBrushes.Black,
            ////    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*8));

            ////gfx.DrawString("Nationality: ", Font, XBrushes.Black,
            ////    new XPoint(LeftColumnM, BottomInfoStart + VerticalGap*9));
            ////gfx.DrawString(Convert.ToString(Nationality), Font, XBrushes.Black,
            ////    new XPoint(RightColumnM, BottomInfoStart + VerticalGap*9));


            XImage ImgProfile = XImage.FromFile(@"..\..\..\..\PDF\Images\shk_old.png");
            int ProfileImgSize = 70;
            gfx.DrawImage(ImgProfile, page.Width - RightM - 130, TopM+54, ProfileImgSize, ProfileImgSize+20);

            int BarCodeWidth = 120;

            XImage ImgBarcode = XImage.FromFile(BarcodeGenerator.GenerateBarcode(BarNum, SrcDir));
            gfx.DrawImage(ImgBarcode, page.Width/2-BarCodeWidth/2, 390, BarCodeWidth, 35);

            ////XPen pen = new XPen(XColors.Black, 1);
            ////gfx.DrawRectangle(pen, 10, 0, 100, 60);



            pdfDoc2.Save(PdfDest);
            Console.WriteLine("Done");


        }
    }
}
