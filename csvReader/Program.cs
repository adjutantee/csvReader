using System;
using System.Linq;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;


namespace TESTxml
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\Izagakhmaevra\Desktop\Excel\csvExcel.csv"))
            {

                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Launch>().ToList();
                }
            }
        }

        public class Launch
        {
            [Name("ID")]
            public int Id { get; set; }
            [Name("Name")]
            public string Name { get; set; }

        }
    }
}