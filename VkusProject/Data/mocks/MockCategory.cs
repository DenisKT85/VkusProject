using Microsoft.AspNetCore.Mvc;
using VkusProject.Data.interfaces;
using VkusProject.Data.Models;

namespace VkusProject.Data.mocks
{
    public class MockCategory : IBludosCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Горячие блюда", desc = "Вкусные горячие блюда от нашего шеф-повара!"},
                    new Category{categoryName = "Салаты", desc = "Свежайшие салаты!"}
                };
            }
        }
    }
}
