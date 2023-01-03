using Microsoft.AspNetCore.Mvc;

namespace SysBankWeb.Controllers
{
    public class CustomerPortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
