using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PDFGenerator
{
    class BarcodeGenerator 
    { 
        public static void GenerateBarcode(string BarNum,string dir)
        {
            var barcode = BarcodeWriter.CreateBarcode(BarNum, BarcodeEncoding.Code128);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SaveAsPng(dir + BarNum + ".png");
        }
        
    }

}
