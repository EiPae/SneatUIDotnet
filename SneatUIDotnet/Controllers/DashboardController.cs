using Microsoft.AspNetCore.Mvc;

namespace SneatUIDotnet.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
