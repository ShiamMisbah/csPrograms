// See https://aka.ms/new-console-template for more information
using IronXL;
using System.Linq;

WorkBook WB = WorkBook.Load(@"C:\Users\Admin\Desktop\Shiam\csPrograms\ExcelTask\DataSet\TestCase1.xlsx");
WorkSheet WS = WB.GetWorkSheet("Sheet1");

HashSet<int> list = new HashSet<int>();
List<int> li2 = new List<int>();

var watch = new System.Diagnostics.Stopwatch();
watch.Start();
int CellValue;

for (int i = 1; i < 200; i++)
{
    CellValue = WS.Columns[5].Rows[i].Int32Value;
    if (!list.Add(CellValue))
    {
        li2.Add(CellValue);
    }

}


for (int i = 0; i < li2.Count; i++)
{
    Console.WriteLine("{0} is Duplicate", li2[i]);
}

watch.Stop();

Console.WriteLine("Execution Time: {0}", watch.ElapsedMilliseconds);


