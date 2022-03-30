using System;
using System.Globalization;
using CsvHelper;

public class Program
{
    public static void Main(string[] args)
    {
        using (var reader = new StreamReader(@"C:\Users\Izagakhmaevra\Desktop\Excel\TestExelCSV.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Foo>();
        }
    }

    public class Foo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    //public static void Print()
    //{
    //    Console.WriteLine();
    //}
}