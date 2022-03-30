using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace TESTxml
{
    public class Commercial : Analog
    {
        [Name("ID объявления")]
        public string ObjectsId { get; set; }
        [Name("Муниципальное образование")]
        public string Subject { get; set; }
        [Name("Заголовок")]
        public string Title { get; set; }
        [Name("Стоимость")]
        public decimal Price { get; set; }
        [Name("Площадь")]
        public decimal Square { get; set; }
        [Name("Снимок экрана")]
        public string ScreenName { get; set; }
        public string Url { get; set; }
        [Name("Населенный пункт")]
        public string City { get; set; }
        [Name("Адрес")]
        public string Address { get; set; }
        [Name("Описание")]
        public string Description { get; set; }
        [Name("Дата публикации")]
        public DateTime PublishDate { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal Latitude { get; set; }
        [Column(TypeName = "decimal(15, 5)")]
        public decimal Longitude { get; set; }
        [Name("Дата сбора")]
        public DateTime CrawlDate { get; set; }
        public int SessionId { get; set; }
    }
}
