using System;
using System.Linq;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Text;


namespace csvReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\Izagakhmaevra\Desktop\Excel\csvExcel.csv"))
            {
                var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";", Encoding = Encoding.UTF8 };
                using var csv = new CsvReader(reader, config);
                {
                    var records = csv.GetRecords<Launch>();
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