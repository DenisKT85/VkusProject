using Microsoft.AspNetCore.Mvc;
using VkusProject.Data.Models;

namespace VkusProject.Data.interfaces
{
    public interface IAllBludos
    {
        IEnumerable<Bludo> Bludos { get; }
        IEnumerable<Bludo> getFaveBludos { get; set; }
        Bludo getObjectBludo(int bludoId);
    }
}
