// See https://aka.ms/new-console-template for more information
using IronXL;
using System.Linq;
var watch = new System.Diagnostics.Stopwatch();
watch.Start();

WorkBook WB = WorkBook.Load(@"C:\Users\Admin\Desktop\Shiam\csPrograms\ExcelTask\DataSet\Recruit_Applicants.xlsx");
WorkSheet WS = WB.GetWorkSheet("Sheet1");
Console.WriteLine("Worksheet Read: {0}", watch.ElapsedMilliseconds);
Console.WriteLine("Enter initial value: ");
string Initial = "F"+Console.ReadLine();
Console.WriteLine("Enter Final value: ");
string Final = "F"+Console.ReadLine();
string CellRange = Initial+":"+Final;
Console.WriteLine(CellRange);
var Range = WS.GetRange(CellRange);

HashSet<int> list = new HashSet<int>();
List<int> li2 = new List<int>();

foreach (var cell in Range)
{
    if (!list.Add(cell.Int32Value))
    {
        Console.WriteLine("The Duplicate are: {0}", cell.Int32Value);
    }
}



watch.Stop();

Console.WriteLine("Final Execution Time: {0}", watch.ElapsedMilliseconds);


