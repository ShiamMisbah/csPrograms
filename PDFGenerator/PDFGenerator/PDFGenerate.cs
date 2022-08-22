using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SelectPdf;
using PdfSharp.Pdf.IO;
using System.Globalization;

namespace PDFGenerator
{
    class PDFGenerate
    {

        public static void PDFGenerator(string SrcDir, string applicationCode, string Name, string FatherName, string MotherName, string District, string Post_name)
        {
            //string BarNum = Convert.ToString(applicationCode);




            string PdfDest = SrcDir + "PDF_Result\\" + applicationCode + ".pdf";
            //string HtmlDes = SrcDir + ID + ".html";
            //File.WriteAllText(HtmlDes, htmlText);
            var htmltopdf = new HtmlToPdf();

            string strVar = "";
            strVar += "<div class=\"container\" style=\"width: 700px; margin: 30px auto;\">";
            strVar += "        <header style=\"height:80px; display: flex; padding: 20px 30px; border-bottom: 1px solid black;\">";
            strVar += "            <img style=\"width: 80px; margin-right: 50px;\" src=\"../../../PDF/Images/login_logo.jpg\" alt=\"\" srcset=\"\">";
            strVar += "            <div class=\"heading-container\" style=\"display: flex ;flex-direction:column; justify-content: space-evenly;\">";
            strVar += "                <h4 style=\"margin: 0; font-size: 16px ; font-weight: 300;\">গণপ্রজাতন্ত্রী বাংলাদেশ সরকার</h4>";
            strVar += "                <h3 style=\"margin: 0; font-size: 18px ;\">গণপূর্ত অধিদপ্তর</h3>";
            strVar += "                <h4 style=\"margin: 0; font-size: 16px ; font-weight: 400;\">নিয়োগ পরিক্ষা</h4>";
            strVar += "            </div>";
            strVar += "        </header>";
            strVar += "        <h3 style=\"text-align: center;margin: 10px 10px;\">প্রবেশ পত্র</h3>";
            strVar += "        <div class=\"bodyCard\" style=\"height: 420px; border: 1px solid black; display: grid;grid-template-columns: repeat(3, 1fr);grid-template-rows: repeat(3, 1fr);grid-column-gap: 0px;grid-row-gap: 0px;\">";
            strVar += "            <div class=\"ApplicantData\" style=\"grid-area: 1 / 1 / 3 / 3;\">";
            strVar += "                <style>";
            strVar += "                    .DataContainer{";
            strVar += "                        box-sizing: border-box;";
            strVar += "                        width: 70%;";
            strVar += "                        display: flex;";
            strVar += "                        justify-content: flex-start;";
            strVar += "                        padding: 20px 30px;";
            strVar += "                    }";
            strVar += "                    .DataContainer div{" +
                "                               margin:0}" +
                "                          .DataLabel{" +
                "                               width:150px}";                           
            strVar += "                </style>";
            strVar += "                <div class=\"ApplicationDataContainer\" style=\"margin-top: 15px;\">";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <div class=\"DataLabel\"style = \"font-size: 20px; font-weight: 800\">পদঃ</div> <div class=\"dataText\"style = \"font-size: 18px; font-weight: 800\">" + Post_name + "</div>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <div class=\"DataLabel\" style = \"font-size: 16px; font-weight: 700\">ক্রমিক নংঃ</div> <div class=\"dataText\"style = \"font-size: 16px; font-weight: 700\">" + applicationCode + "</div>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <div class=\"DataLabel\">নামঃ </div> <div class=\"dataText\">" + Name + "</div>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <div class=\"DataLabel\">পিতার নামঃ</div> <div class=\"dataText\">" + FatherName + "</div>";
            strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <div class=\"DataLabel\">মাতার নামঃ </div> <div class=\"dataText\"> " + MotherName + "</div>";
            strVar += "                    </div>";
            //strVar += "                    <div class=\"DataContainer\">";
            //strVar += "                        <p class=\"DataLabel\">পরিক্ষা কেন্দ্রঃ</p> <p>habahaba</p>";
            //strVar += "                    </div>";
            strVar += "                    <div class=\"DataContainer\">";
            strVar += "                        <div class=\"DataLabel\">জেলাঃ </div> <div class=\"dataText\"> " + District + "</div>";
            strVar += "                    </div>";
            strVar += "                </div>";
            strVar += "            </div>";
            strVar += "            <div class=\"ApplicantImg\" style=\" height: 60%; grid-area: 1 / 3 / 4 / 4; padding: 20px 10px; display: flex; flex-direction: column; justify-content: space-between;\">";
            strVar += "                <img class=\"AppImg\"style=\"height: 0px; width: 0px; margin-left: 50px; \"  src=\"\" alt=\"\" srcset=\"\">";
            strVar += "                <img class= \"BarCodeImg\" style=\"height: 00px; width: 0px\" src=\"\" alt=\"\" srcset=\"\">";
            strVar += "            </div>";
            strVar += "            <div class=\"SignatureImg\" style=\"grid-area: 3 / 1 / 4 / 3; padding: 00px 0px; display: flex; flex-direction: column; justify-content: center; align-items:flex-start;\">";
            strVar += "                <img class= \"SignatureContainerImg\" style=\"height: 00px; width: 0px\" src=\"PDF/Barcodes/973259.png\" alt=\"\" srcset=\"\">";
            strVar += "                <h3 class=\"applicantSignature\" style=\"border-top:1px solid black; margin: -620px 0 0 510px; font-size:12px; width: 150px\">Applicant Signature</h3> ";
            strVar += "            </div>";
            strVar += "        </div>";
            strVar += "        <h5 style=\"text-align: center;margin: 20px 0px;\">নিয়মাবলী </h5>";
            strVar += "        <div class=\"rules \" style=\"font-size: 16px;\">";
            strVar += "          <style>";
            strVar += "             .rules li{" +
                "                       margin-bottom:10px  " +
                "                   }" +
                "                  </style>";
            strVar += "            <li>প্রিলিমিনারি পরীক্ষা, লিখিত পরীক্ষা এবং ভাইভা বসার জন্য প্রবেশপত্র প্রযোজ্য হবে।</li>";
            strVar += "            <li>প্রতিটি পরীক্ষার সময় আবেদনকারীকে অবশ্যই এই প্রবেশপত্র বহন করতে হবে।</li>";
            strVar += "            <li>আবেদনকারীকে প্রাথমিক পরীক্ষার কমপক্ষে 30 মিনিট এবং লিখিত পরীক্ষার 15 মিনিট আগে পরীক্ষার হলে বসতে হবে। প্রিলিমিনারি পরীক্ষার দিন, পরীক্ষা শেষ হওয়ার আগে হল ত্যাগ করা নিষেধ।</li>";
            strVar += "            <li>আবেদনকারীকে বই, ব্যাগ, মোবাইল ফোন, হাতঘড়ি, ইলেকট্রনিক ঘড়ি ক্যালকুলেটর বা অন্য যেকোন ধরনের যোগাযোগ যন্ত্র আনতে নিষেধ করা হয়েছে। পরীক্ষার হলে উল্লিখিত নিষিদ্ধ জিনিসপত্র আনা শাস্তিযোগ্য অপরাধ।</li>";
            strVar += "            <li>আবেদনকারীকে আবেদনের উপস্থিতি পত্র এবং উত্তর স্ক্রিপ্টের জন্য একই স্বাক্ষর ব্যবহার করতে হবে।</li>";
            strVar += "            <li>আবেদনকারীকে প্রিলিমিনারি পরীক্ষার উত্তরপত্র এবং লিখিত উত্তর স্ক্রিপ্টের শীর্ষ পত্রকের অংশ ও বৃত্তগুলিতে ফিট করার জন্য প্রতি কালো কালি বল পয়েন্ট ব্যবহার করতে হবে।</li>";
            strVar += "            <li>তার শিক্ষাগত যোগ্যতা এবং অভিজ্ঞতা ছাড়াও, একজন আবেদনকারীকে অবশ্যই ভাইভা বোর্ডের সামনে সমস্ত প্রয়োজনীয় নথির অনজিনাল কপি উপস্থাপন করতে হবে।</li>";
            strVar += "            <li>পরীক্ষার হলে পরিদর্শকরা আবেদনকারীর স্বাক্ষর নেওয়ার আগে উপস্থিতি পত্রের সাথে প্রবেশপত্রের ছবি মিলবে। কোনো অনিয়ম ধরা পড়লে আবেদনকারীর বিরুদ্ধে আইনগত ব্যবস্থা নেওয়া হবে।</li>";
            strVar += "            <li>সাধারণ নির্দেশাবলী অনুসরণ না করলে বা অসদাচরণ, অসদাচরণ বা অন্যায্য উপায় অবলম্বনের জন্য দোষী সাব্যস্ত হলে আবেদনকারীকে বহিষ্কার করা হবে। অনুলিপি করার জন্য দোষী সাব্যস্ত আবেদনকারী, কোনো ধরনের অন্যায্য উপায় অবলম্বন বা অসদাচরণ, নিষিদ্ধ নিবন্ধ বহনকারীকে কমিশন কর্তৃক পরিচালিত ভবিষ্যতের কোনো পরীক্ষায় আবেদন করতে বাধা দেওয়া হবে এবং কমিশনের পরামর্শের জন্য অন্য কোনো পদের জন্য আবেদন করার অনুমতি দেওয়া হবে না। অধিকন্তু, তার বিরুদ্ধে আইনানুগ ব্যবস্থা গ্রহণের জন্য তাকে আইন প্রয়োগকারী সংস্থার কাছে হস্তান্তর করা হতে পারে।</li>";
            strVar += "        </div>";
            strVar += "        <h4 style=\"margin-top:30px; padding: 30px 20px; font-size: 12px; font-weight: 300; text-align:right; text-decoration: overline; \">তত্ত্বাবধায়ক</h4>";
            strVar += "        <div style=\"border: 1px solid rgba(0, 0, 0, 0.089); padding: 7px 20px;\" class=\"copyright\">";
            strVar += "            <p style=\"font-size: 8px; margin: 0;\">2022, Bangladesh Public Service Commission, All Rights Reserved.</p>";
            strVar += "        </div>";
            strVar += "    </div>";

            //var url = "../../../../admitCard.html";
            //var testPath = Path.GetFullPath(url);
            //htmltopdf.ConvertUrl(testPath).Save(PdfDest);
            htmltopdf.ConvertHtmlString(strVar).Save(PdfDest);
            //pdfDoc;


            //Add Dynamic images to the generated PDF

            PdfSharp.Pdf.PdfDocument pdfDoc2 = PdfReader.Open(PdfDest, PdfDocumentOpenMode.Modify);
            PdfSharp.Pdf.PdfPage page = pdfDoc2.Pages[0];


            ////PdfDocument document = PdfGenerator.GeneratePdf(htmlText, PdfSharp.PageSize.A4);

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
            int LeftM = 92;
            int RightM = 50;
            int TopM = 160;
            int BottomInfoStart = TopM + 20;
            int VerticalGap = 30;
            int LogoSize = 58;
            int LeftColumnStartX = LeftM;
            int LeftColumnWidth = 125;
            int RightColumnStartX = LeftColumnStartX + LeftColumnWidth;
            int RightColumnWidth = 250;

            ////XPen pen = new XPen(XColors.White, 0);
            //int height = 20;
            //XPen pen2 = new XPen(XColors.White, 100);
            //gfx.DrawRectangle(pen2, 0, page.Height-height, page.Width, height);

            //Logo
            XImage Logo = XImage.FromFile(@"..\..\..\..\PDF\Images\login_logo.jpg");
            gfx.DrawImage(Logo, LeftM + 15, 19, LogoSize, LogoSize);


            string applicantImageDir = "applicant_image\\" + applicationCode + ".jpg";
            XImage ImgProfile = XImage.FromFile(@"..\..\..\..\PDF\"+applicantImageDir);
            int ProfileImgSize = 80;
            gfx.DrawImage(ImgProfile, page.Width - RightM - 152, TopM-35, ProfileImgSize, ProfileImgSize + 20);



            int BarCodeWidth = 100;

            XImage ImgBarcode = XImage.FromFile(BarcodeGenerator.GenerateBarcode(applicationCode, SrcDir));
            gfx.DrawImage(ImgBarcode, page.Width - RightM - 162, TopM + 84, BarCodeWidth, 30);

            string applicantSignatureDir = "applicant_signature\\" + applicationCode + ".jpg";
            XImage ImgSignature = XImage.FromFile(@"..\..\..\..\PDF\"+ applicantSignatureDir);
            int SignatureImgSize = 30;
            gfx.DrawImage(ImgSignature, page.Width - RightM-160, TopM + 125, SignatureImgSize + 65, SignatureImgSize);
            //page.Width - RightM - 152
            ////XPen pen = new XPen(XColors.Black, 1);
            ////gfx.DrawRectangle(pen, 10, 0, 100, 60);
            ///
            pdfDoc2.Save(PdfDest);

            PdfSharp.Pdf.PdfDocument inputDocument = PdfReader.Open(PdfDest, PdfDocumentOpenMode.Import);
            //new Document

            PdfSharp.Pdf.PdfDocument outputDocument = new PdfSharp.Pdf.PdfDocument();
            outputDocument.AddPage(inputDocument.Pages[0]);

            outputDocument.Save(PdfDest);
            Console.WriteLine("Done {0}", applicationCode);


        }
    }
}
