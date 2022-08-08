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
using System.Globalization;

namespace PDFGenerator
{
    class PDFGenerate
    {
        
        public static void PDFGenerator(string SrcDir, int ID, string Name, /* int Phone, string Email, string DateOfBirth, string DocumentName, string Title*/ string FatherName, string MotherName, string ExamCenter, string District)
        {
            string BarNum = Convert.ToString(ID);
            //CultureInfo info = new CultureInfo("es-ES");
            //DateTime conDate = DateTime.Parse(DateOfBirth,info);
            //DateOfBirth = conDate.ToString("dd/MM/yyyy");

            //string Logodir = @"PDF/Images/login_logo.jpg";
            //string htmlText = "<div class=\"container\" style=\"width: 700PX; height: 800px; padding: 30px 0px;display: flex; flex-direction: column; box-sizing: border-box; margin: 0 auto; border: 1px solid black; font-family: Arial, Helvetica, sans-serif;\">        <div class=\"header\" style=\"width: 100%;height: 120PX; display: flex;justify-content:left;align-items: center;padding: 0px 30px;\">            <div  style=\"width: 100px; height: 100px; margin: 20px 50px 20px 0px;\"></div>            <h1 style=\"font-size: 24px; font-weight: 300; margin: 0 0px;\">PUBLIC WORKS DEPARTMENT</h1>        </div>        <div class=\"admitHeader\" style=\"width: 100%; text-align: center; background-color:lightgray;\">            <h2 style=\"font-size: 22px; font-weight: 300\">ADMIT CARD</h2>        </div>        <div class=\"bodyContainer\" style=\" width:100%; box-sizing: border-box; display: flex;padding: 20px 30px;flex-wrap: nowrap;\">            <table style=\"width: 100%; font-size: 14px;\" cellspacing = 0>                              <tr style=\"height: 30px; font-size: 16px; \">                    <th style=\"border: 1px solid black;border-bottom: 0px; background-color: lightgray; text-align: left; padding-left: 20px;\">ID:</th>                    <td style=\"border: 1px solid black; border-bottom: 0px; padding-left: 10px;\" >" + ID + "</td>                                    </tr>                <tr style=\"height: 30px; font-size: 16px;\">                    <th style=\"border: 1px solid black;border-bottom: 0px; background-color: lightgray; text-align: left; padding-left: 20px;\">Full Name:</th>                    <td style=\"border: 1px solid black; border-bottom: 0px; padding-left: 10px;\" >" + Name + "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black;border-bottom: 0px; background-color: lightgray; text-align: left; padding-left: 20px;\">Mobile Number:</th>                    <td style=\"border: 1px solid black; border-bottom: 0px; padding-left: 10px;\" >" + Phone + "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black; background-color: lightgray; text-align: left; padding-left: 20px;\">Email Address:</th>                    <td style=\"border: 1px solid black; padding-left: 10px;\" >" + Email + "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black; background-color: lightgray; text-align: left; padding-left: 20px;\">Date Of birth:</th>                    <td style=\"border: 1px solid black; padding-left: 10px;\" >" + DateOfBirth + "</td>                                    </tr>                <tr style=\"height: 30px;\">                    <th style=\"border: 1px solid black; background-color: lightgray; text-align: left; padding-left: 20px;\">Title:</th>                    <td style=\"border: 1px solid black; padding-left: 10px;\" > " + Title + "</td>                </tr>                            </table>                        <img style=\"margin: 20px; margin-top: 0; width: 100px; height: 125px;\" src=\"Images/shk_old.PNG\" alt=\"\" srcset=\"\">        </div>        <div class=\"barcodeimage\" style=\"width: 100%;display:flex;justify-content:center; margin-top: 100px \">            <img src=\"barcodes/407426.png\" style=\"width: 200px; height:50px;\" alt=\"\" srcset=\"\">        </div>    </div>";
            string strVar = "";
            strVar += "<div class=\"container\" style=\"width: 700px; margin: 30px auto;\">";
            strVar += "        <header style=\"height:80px; display: flex; padding: 20px 30px; border-bottom: 1px solid black;\">";
            strVar += "            <img style=\"width: 80px; margin-right: 30px;\" src=\"PDF/Images/login_logo.jpg\" alt=\"\" srcset=\"\">";
            strVar += "            <div class=\"heading-container\" style=\"display: flex ;flex-direction:column; justify-content: space-evenly;\">";
            strVar += "                <h4 style=\"margin: 0; font-size: 14px ; font-weight: 300;\">গণপ্রজাতন্ত্রী বাংলাদেশ সরকার</h4>";
            strVar += "                <h3 style=\"margin: 0; font-size: 16px ;\">গণপূর্ত অধিদপ্তর</h3>";
            strVar += "                <h4 style=\"margin: 0; font-size: 14px ; font-weight: 400;\">নিয়োগ পরিক্ষা</h4>";
            strVar += "            </div>";
            strVar += "        </header>";
            strVar += "        <h3 style=\"text-align: center;margin: 10px 10px;\">প্রবেশ পত্র</h3>";
            strVar += "        <h5 style=\"text-align: center;margin: 10px 0px;\">পদ এর নাম</h5>";
            strVar += "        <div class=\"bodyCard\" style=\"height: 450px; border: 1px solid black; display: grid;grid-template-columns: repeat(3, 1fr);grid-template-rows: repeat(3, 1fr);grid-column-gap: 0px;grid-row-gap: 0px;\">";
            strVar += "            <div class=\"ApplicantData\" style=\"grid-area: 1 / 1 / 3 / 3;\">";
            strVar += "                <style>";
            strVar += "                    .DataContainer{";
            strVar += "                        box-sizing: border-box;";
            strVar += "                        width: 70%;";
            strVar += "                        display: flex;";
            strVar += "                        justify-content: space-between;";
            strVar += "                        padding: 10px 30px;";
            strVar += "                    }";
            strVar += "                    .DataContainer p{";
            strVar += "                        margin: 0;";
            strVar += "                        font-size: 12px;";
            strVar += "                    }";
            strVar += "                </style>";
            strVar += "                <div class=\"ApplicationDataContainer\" style=\"margin-top: 15px;\">";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <p style = \"font-size: 14px; font-weight: 600\" class=\"DataLabel\">ক্রমিক নংঃ </p> <p style = \"font-size: 14px; font-weight: 600\">" + ID +"</p>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <p class=\"DataLabel\">নামঃ </p> <p>"+ Name +"</p>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <p class=\"DataLabel\">পিতার নামঃ</p> <p>"+FatherName+"</p>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <p class=\"DataLabel\">মাতার নামঃ </p> <p> "+MotherName+"</p>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <p class=\"DataLabel\">পরিক্ষা কেন্দ্রঃ</p> <p>"+ExamCenter+"</p>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <p class=\"DataLabel\">জেলাঃ </p> <p> "+District+"</p>";
            strVar += "                    </div>";
            strVar += "                </div>";
            strVar += "            </div>";
            strVar += "            <div class=\"ApplicantImg\" style=\" height: 60%; grid-area: 1 / 3 / 4 / 4; padding: 20px 10px; display: flex; flex-direction: column; justify-content: space-between;\">";
            strVar += "                <img class=\"AppImg\"style=\"height: 150px; width: 110px; margin-left: 18px; \"  src=\"\" alt=\"\" srcset=\"\">";
            strVar += "                <img class= \"BarCodeImg\" style=\"height: 00px; width: 0px\" src=\"\" alt=\"\" srcset=\"\">";
            strVar += "            </div>";
            strVar += "            <div class=\"SignatureImg\" style=\"grid-area: 3 / 1 / 4 / 3; padding: 30px 0px; display: flex; flex-direction: column; justify-content: center; align-items:flex-start;\">";
            strVar += "                <img class= \"SignatureContainerImg\" style=\"height: 100px; width: 300px\" src=\"PDF/Barcodes/973259.png\" alt=\"\" srcset=\"\">";
            strVar += "                <p style=\"margin: 10px 25px; font-size: 12px;\">Applicants's Signature</p>";
            strVar += "            </div>";
            strVar += "        </div>";
            strVar += "        <h5 style=\"text-align: center;margin: 20px 0px;\">নিয়মাবলী </h5>";
            strVar += "        <ol style=\"font-size: 10px;\">";
            strVar += "            <li>Lorem ipsumoelit in dignissimos dicta perferendis, dolores vitae!</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi, tempore qui excepturi hic similique omnis veritatis provident, in at voluptates natus culpa porro, impedit dolor? Eius praesentium pariatur animi possimus.</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam distinctio eligendi saepe amet?</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet.</li>";
            strVar += "            <li>Lorem ipsumoelit in dignissimos dicta perferendis, dolores vitae!</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi, tempore qui excepturi hic similique omnis veritatis provident, in at voluptates natus culpa porro, impedit dolor? Eius praesentium pariatur animi possimus.</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam distinctio eligendi saepe amet?</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet.</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Dicta voluptates aperiam vitae soluta molestiae necessitatibus ipsum alias ducimus eius modi asperiores, facilis veniam.</li>";
            strVar += "            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit. Dicta voluptates aperiam vitae soluta molestiae necessitatibus ipsum alias ducimus eius modi asperiores, facilis veniam.</li>";
            strVar += "        </ol>";
            strVar += "        <h4 style=\"margin-top:60px; padding: 0px 20px; font-size: 12px; font-weight: 300; text-align:right; text-decoration: overline; \">তত্ত্বাবধায়ক</h4>";
            strVar += "        <div style=\"border: 1px solid rgba(0, 0, 0, 0.089); padding: 7px 20px;\" class=\"copyright\">";
            strVar += "            <p style=\"font-size: 8px; margin: 0;\">2022, Bangladesh Public Service Commission, All Rights Reserved.</p>";
            strVar += "        </div>";
            strVar += "    </div>";


            string PdfDest = SrcDir + ID +".pdf";
            //string HtmlDes = SrcDir + ID + ".html";
            //File.WriteAllText(HtmlDes, htmlText);
            var htmltopdf = new HtmlToPdf();
            var pdfDoc = htmltopdf.RenderHtmlAsPdf(strVar);
            pdfDoc.SaveAs(PdfDest);

            //Add Dynamic images to the generated PDF

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
            int LogoSize = 57;
            int LeftColumnStartX = LeftM;
            int LeftColumnWidth = 125;
            int RightColumnStartX = LeftColumnStartX + LeftColumnWidth;
            int RightColumnWidth = 250;

            ////XPen pen = new XPen(XColors.White, 0);
            int height = 70;
            XPen pen2 = new XPen(XColors.White, 100);
            gfx.DrawRectangle(pen2, 0, page.Height-height, page.Width, height);

            //Logo
            XImage Logo = XImage.FromFile(@"..\..\..\..\PDF\Images\login_logo.jpg");
            gfx.DrawImage(Logo, LeftM - 26 , 100, LogoSize, LogoSize);
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
            int ProfileImgSize = 80;
            gfx.DrawImage(ImgProfile, page.Width - RightM - 152, TopM+68, ProfileImgSize, ProfileImgSize+20);

            int BarCodeWidth = 140;

            XImage ImgBarcode = XImage.FromFile(BarcodeGenerator.GenerateBarcode(BarNum, SrcDir));
            gfx.DrawImage(ImgBarcode, page.Width - RightM - 168 , TopM + 230, BarCodeWidth, 52);

            ////XPen pen = new XPen(XColors.Black, 1);
            ////gfx.DrawRectangle(pen, 10, 0, 100, 60);



            pdfDoc2.Save(PdfDest);
            Console.WriteLine("Done {0}", ID);


        }
    }
}
