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
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "\t"
            };

            using (var streamReader = new StreamReader(@"C:\Users\Izagakhmaevra\Desktop\Excel\csvExcel.csv"))
            {
                //using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                using (var csvReader = new CsvReader(streamReader, config))
                {
                    csvReader.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.Add("NULL");
                    var records = csvReader.GetRecord<Launch>();

                    //var records = csvReader.GetRecords<Launch>().ToList();
                }
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