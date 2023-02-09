using Microsoft.AspNetCore.Mvc;
using VkusProject.Data.Models;

namespace VkusProject.Data.interfaces

{
    public interface IBludosCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
