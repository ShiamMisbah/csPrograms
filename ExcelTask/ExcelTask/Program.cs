// See https://aka.ms/new-console-template for more information
using IronXL;
using System.Data;
var watch = new System.Diagnostics.Stopwatch();
watch.Start();

WorkBook WB = WorkBook.Load(@"C:\Users\Admin\Desktop\Shiam\csPrograms\ExcelTask\DataSet\Recruit_Applicants_Test.xlsx");
WorkSheet WS = WB.GetWorkSheet("Sheet1");
WorkBook WNew = WorkBook.Create(ExcelFileFormat.XLSX);
WorkSheet WN = WNew.CreateWorkSheet("UniqueID");

//DataTable Datatb = WS.ToDataTable(true);

//foreach (DataRow row in Datatb.Rows)
//{
//    for (int i = 0; i < Datatb.Columns.Count; i++)
//    {
//        Console.Write(row[i]+"\t");
//    }
//    Console.WriteLine();
//}

//DataTable dt = new DataTable();
//dt.Columns.Add("Name", typeof(string));
//dt.Columns.Add("Mobile", typeof(string));
//dt.Columns.Add("DateOfBirth", typeof (string));
//dt.Columns.Add("Email", typeof(string));
//dt.Columns.Add("ApplicationCode", typeof(int));
//dt.Columns.Add("Title", typeof(string));


Console.WriteLine("Worksheet Read: {0}", watch.ElapsedMilliseconds);
string Initial = "F2";
Console.WriteLine("Enter Final value: ");
string Final = "F"+Console.ReadLine();
string CellRange = Initial+":"+Final;
Console.WriteLine(CellRange);
var Range = WS.GetRange(CellRange);

HashSet<string> list = new HashSet<string>();
//List<IronXL.Cell> li2 = new List<IronXL.Cell>();
int DuplicateCount = 0;
int i = 2;
foreach (var cell in Range)
{
    if (!list.Add(cell.ToString()))
    {
        Console.WriteLine("The Duplicate are: {0}", cell.ToString());
        DuplicateCount++;
    }
    else
    {
        //dt.Rows.Add(WS["A"+i].Value, WS["H"+i].Value, WS["C"+i].Value, WS["D"+i].Value, WS["F"+i].Value, WS["G"+i].Value);
        WN["A"+i].Value = WS["A"+i].Value;
        WN["B"+i].Value = WS["I"+i].Value;
        WN["C"+i].Value = WS["C"+i].Value;
        WN["D"+i].Value = WS["D"+i].Value;
        WN["F"+i].Value = WS["F"+i].Value;
        WN["G"+i].Value = WS["G"+i].Value;
    }
    i++;
}
//foreach (DataRow row in dt.Rows)
//{
//    for (int j = 0; j < dt.Columns.Count; j++)
//    {
//        Console.Write(row[j]+"\t");
//    }
//    Console.WriteLine();
//}
Console.WriteLine("Total Duplicates: {0}", DuplicateCount);
Console.WriteLine("Total Uniques: {0}", list.Count);

WNew.SaveAs(@"C:\Users\Admin\Desktop\Shiam\csPrograms\ExcelTask\DataSet\Recruit_Applicants2.xlsx");
watch.Stop();

Console.WriteLine("Final Execution Time: {0}", watch.ElapsedMilliseconds);


