using System;
using System.Linq;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using System.Text;


namespace TESTxml
{
    public interface IAnalogProvider
    {
        IEnumerable<T> GetItems<T>(string fileName) where T : Analog;
    }

    public class CsvAnalogProvider : IAnalogProvider
    {
        public IEnumerable<T> GetItems<T>(string fileName) where T : Analog
        {
            var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";", Encoding = Encoding.UTF8 };

            using var reader = new StreamReader(fileName);
            using var csv = new CsvReader(reader, config);

            foreach (var record in csv.GetRecords<T>())
                yield return record;
        }
    }

    public partial class Program
    {
        public static void Main(string[] args)
        {

            var provider = new CsvAnalogProvider();

            foreach (var item in provider.GetItems<House>(@"C:\Users\Izagakhmaevra\Desktop\Excel\Дома.csv"))
            {
                Console.WriteLine(item.Title);
            }

            Console.ReadKey();
        }
    }
}