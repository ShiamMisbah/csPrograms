// See https://aka.ms/new-console-template for more information

using PdfSharp.Drawing;
using PdfSharp.Pdf;

class Program
{
    static void Main(string[] args)
    {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        //New Document
        PdfDocument document = new PdfDocument();
        Console.WriteLine("Done1");
        //New page
        PdfPage page = document.AddPage();
        Console.WriteLine("Done2");
        //graphics and stuffs
        XGraphics gfx = XGraphics.FromPdfPage(page);
        Console.WriteLine("Done3");
        //font
        XFont font = new XFont("Arial", 20);
        Console.WriteLine("Done4");
        //writing text
        gfx.DrawString("My name is Turjo", font, XBrushes.Blue,
            new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
        Console.WriteLine("Done5");
        document.Save("C:\\Users\\Administrator\\Desktop\\Shiam\\C#\\PDFGenerator\\PDF\\testPdf.pdf");
        Console.WriteLine("Done6");
    }

}



