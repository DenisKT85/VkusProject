using VkusProject.Data.Models;

namespace VkusProject.ViewModels
{
    public class BludosListViewModel
    {
        public IEnumerable<Bludo> allBludos { get; set; }    
        public string currCategory { get; set; }
    }
}
