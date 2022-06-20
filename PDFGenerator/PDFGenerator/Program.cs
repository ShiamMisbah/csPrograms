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
        gfx.DrawString("My name is Tusdgagrjo", font, XBrushes.Blue,
            new XRect(100, 300, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

        gfx.DrawString("My name is Not Turjo", font, XBrushes.Red,
            new XPoint(100, 500));
        Console.WriteLine("Done5");
        document.Save("C:\\Users\\Administrator\\Desktop\\Shiam\\C#\\csPrograms\\PDFGenerator\\PDF\\testPdf.pdf");
        Console.WriteLine("Done6");
    }

}



