// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.OutputEncoding = System.Text.Encoding.UTF8;
string s = File.ReadAllText(@"..\..\..\..\Document\Dummy.txt");

Console.WriteLine(s);