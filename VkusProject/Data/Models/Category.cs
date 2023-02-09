namespace VkusProject.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desk { get; set; }   // описание категории
        public List<Bludo> bludos { get; set; }

    }
}
