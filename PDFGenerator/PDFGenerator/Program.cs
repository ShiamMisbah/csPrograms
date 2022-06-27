// See https://aka.ms/new-console-template for more information
using LINQtoCSV;
using PDFGenerator;
using PdfSharp.Drawing;
using PdfSharp.Pdf;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
//generate Random Number
Random random = new Random();


ReadFile();

//for (int i = 0; i < 5; i++)
//{
//    string BarNum = Convert.ToString(random.Next(10000000));
//    Console.WriteLine(BarNum);
//    PDFGenerator.BarcodeGenerator.GenerateBarcode(BarNum, dir);
//    PDFGenerator.PDFGenerate.BarcodeImageGenerator(BarNum, dir);


//}

static void ReadFile()
{
    string dir = "C:\\Users\\Administrator\\Desktop\\Shiam\\C#\\csPrograms\\PDFGenerator\\PDF\\";

    var csvFileDescription = new CsvFileDescription
    {
        FirstLineHasColumnNames = true,
        IgnoreUnknownColumns = true,
        SeparatorChar = ',',
        UseFieldIndexForReadingData = false
    };

    var csvContext = new CsvContext();
    var student = csvContext.Read<StudentInfo>(@"C:\Users\Administrator\Desktop\Shiam\C#\csPrograms\PDFGenerator\PDF\students.csv", csvFileDescription);

    foreach (var studentInfo in student)
    {
        PDFGenerator.PDFGenerate.BarcodePDFGenerator(dir, studentInfo.ID, studentInfo.Name, studentInfo.Phone, studentInfo.email, studentInfo.IsCandidate);
    };
}








