using Microsoft.AspNetCore.Mvc;
using RoutingNavigationApp.Areas.Admin.Models;

namespace RoutingNavigationApp.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProfileController : Controller
    {
        public IActionResult AdminProfile()
        {
            return View();
        }
    }
}
