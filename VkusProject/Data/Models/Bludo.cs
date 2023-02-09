namespace VkusProject.Data.Models
{
    public class Bludo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; } //краткое описание
        public string longDesc { get; set; } //полное описание
        public string img { get; set; }  // url - адрес картинки
        public ushort price { get; set; }
        public bool isFavourite { get; set; }  // отображается на главной странице или нет
        public int available { get; set; } // кол-во товара
        public int idCategory { get; set; }
        public virtual Category Category { get; set; }



    }
}
