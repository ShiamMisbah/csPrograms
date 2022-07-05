// See https://aka.ms/new-console-template for more information
using IronXL;
using System.Linq;
var watch = new System.Diagnostics.Stopwatch();
watch.Start();

WorkBook WB = WorkBook.Load(@"C:\Users\Admin\Desktop\Shiam\csPrograms\ExcelTask\DataSet\Recruit_Applicants.xlsx");
WorkSheet WS = WB.GetWorkSheet("Sheet1");
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
foreach (var cell in Range)
{
    if (!list.Add(cell.ToString()))
    {
        Console.WriteLine("The Duplicate are: {0}", cell.ToString());
        DuplicateCount++;
    }
}

Console.WriteLine("Total Duplicates: {0}", DuplicateCount);
Console.WriteLine("Total Uniques: {0}", list.Count);
watch.Stop();

Console.WriteLine("Final Execution Time: {0}", watch.ElapsedMilliseconds);


