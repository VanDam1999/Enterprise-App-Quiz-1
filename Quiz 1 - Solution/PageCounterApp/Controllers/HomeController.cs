using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PageCountIncrementImplement _pageCountIncrementImplement;
        
        public HomeController()
        {
            _pageCountIncrementImplement = new PageCountIncrementImplement();
        }

        public IActionResult Index()
        {
            int countViewHome = _pageCountIncrementImplement.IncrementPageCount("Home");
            
            return View(countViewHome);
        }
        public IActionResult OtherPage()
        {
            int countViewOtherPage = _pageCountIncrementImplement.IncrementPageCount("OtherPage");
            
            return View(countViewOtherPage);
        }
    }
}