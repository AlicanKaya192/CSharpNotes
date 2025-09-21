using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
