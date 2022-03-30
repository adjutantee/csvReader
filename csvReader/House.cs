using CsvHelper.Configuration.Attributes;

namespace TESTxml
{
    public class House : Analog
    {
        [Name("ID объявления")]
        public string ObjectsId { get; set; }
        [Name("Муниципальное образование")]
        public string Subject { get; set; }
        [Name("Заголовок")]
        public string Title { get; set; }
        public string Url { get; set; }
        [Name("Стоимость")]
        public decimal Price { get; set; }
        [Name("Площадь")]
        public decimal Square { get; set; }
        [Name("Площадь участка")]
        public decimal ParcelSquare { get; set; }
        [Name("Расстояние до города")]
        public string DistanceToCity { get; set; }
        [Name("Материал стен")]
        public string WallMaterial { get; set; }
        [Name("Вид объекта")]
        public string KindOfObject { get; set; }
        [Name("Этаж")]
        public int Floors { get; set; }
        [Name("Снимок экрана")]
        public string ScreenName { get; set; }
        [Name("Населенный пункт")]
        public string City { get; set; }
        [Name("Адрес")]
        public string Address { get; set; }
        [Name("Описание")]
        public string Description { get; set; }
        [Name("Дата публикации")]
        public DateTime PublishDate { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        [Name("Дата сбора")]
        public DateTime CrawlDate { get; set; }

        public int SessionId { get; set; }
    }
}