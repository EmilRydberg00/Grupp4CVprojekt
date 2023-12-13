using Microsoft.AspNetCore.Mvc;

namespace Grupp4CVprojekt.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int gahbafittaFunka()
        {
            return 0;
        }
    }
}
