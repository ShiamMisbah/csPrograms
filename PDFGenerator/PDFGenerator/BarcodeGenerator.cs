
using IronBarCode;

namespace PDFGenerator
{
    class BarcodeGenerator 
    { 
        public static string GenerateBarcode(string BarNum,string dir)
        {
            var barcode = BarcodeWriter.CreateBarcode(BarNum, BarcodeEncoding.Code128);
            barcode.AddBarcodeValueTextBelowBarcode();
            var newDir = dir + "Barcodes\\" + BarNum + ".png";
            barcode.SaveAsPng(newDir);
            return newDir;
        }
        
    }

}
