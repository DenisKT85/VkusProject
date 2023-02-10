using Microsoft.AspNetCore.Mvc;
using VkusProject.Data.interfaces;
using VkusProject.Data.Models;
using VkusProject.ViewModels;

namespace VkusProject.Controllers
{
    public class BludosController : Controller
    {
        //здесь будут функции при вызове которых будет возврщаться тип данных ViewResult (результат в виде html страницы)

        private readonly IAllBludos _allBludos;
        private readonly IBludosCategory _allCategories;

        public BludosController (IAllBludos iAllBludos, IBludosCategory iBludosCat)
        {
            _allBludos = iAllBludos;        
            _allCategories = iBludosCat;
        }

        public ViewResult List() //для возврата html страницы
        {
            //ViewBag.Category = "Some New";
            //var bludos = _allBludos.Bludos;
            //return View(bludos);
            ViewBag.Title = "Страница с блюдами";
            BludosListViewModel obj = new BludosListViewModel();
            obj.allBludos = _allBludos.Bludos;
            obj.currCategory = "Блюда";
            return View(obj);
        }
    }
}
