// See https://aka.ms/new-console-template for more information
using PdfSharp.Drawing;
using PdfSharp.Pdf;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
//generate Random Number
Random random = new Random();
////New Document
//PdfDocument document = new PdfDocument();
//Console.WriteLine("Done1");
////New page
//PdfPage page = document.AddPage();
//Console.WriteLine("Done2");
////graphics and stuffs
//XGraphics gfx = XGraphics.FromPdfPage(page);
//Console.WriteLine("Done3");
////font
//XFont font = new XFont("Arial", 20);
//Console.WriteLine("Done4");
////writing text
//gfx.DrawString("My name is Tusdgagrjo", font, XBrushes.Blue,
//    new XRect(50, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

//gfx.DrawString("My name is Not Haba Haba Turjo", font, XBrushes.Red,
//    new XPoint(50, 150));
//Console.WriteLine("Done5");

string dir = "C:\\Users\\Administrator\\Desktop\\Shiam\\C#\\csPrograms\\PDFGenerator\\PDF\\";

//Image Draw


Console.WriteLine("Enter Barcode Number: \n");

for (int i = 0; i<5;i++)
{
    string BarNum = Convert.ToString(random.Next(1000));
    Console.WriteLine(BarNum);
    PDFGenerator.BarcodeGenerator.GenerateBarcode(BarNum, dir);
    PDFGenerator.BarcodeGenerator.BarcodeImageGenerator(BarNum, dir);


}










