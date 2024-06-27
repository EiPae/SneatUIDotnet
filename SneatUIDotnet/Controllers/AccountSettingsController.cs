using Microsoft.AspNetCore.Mvc;

namespace SneatUIDotnet.Controllers
{
    public class AccountSettingsController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult Connections()
        {
            return View();
        }
    }
}
