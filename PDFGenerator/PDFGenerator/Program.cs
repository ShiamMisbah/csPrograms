// See https://aka.ms/new-console-template for more information
using PdfSharp.Drawing;
using PdfSharp.Pdf;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
//generate Random Number
Random random = new Random();

string dir = "C:\\Users\\Administrator\\Desktop\\Shiam\\C#\\csPrograms\\PDFGenerator\\PDF\\";



for (int i = 0; i<5;i++)
{
    string BarNum = Convert.ToString(random.Next(10000000));
    Console.WriteLine(BarNum);
    PDFGenerator.BarcodeGenerator.GenerateBarcode(BarNum, dir);
    PDFGenerator.PDFGenerate.BarcodeImageGenerator(BarNum, dir);


}










