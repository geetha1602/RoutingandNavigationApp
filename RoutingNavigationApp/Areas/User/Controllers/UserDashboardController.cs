using Microsoft.AspNetCore.Mvc;

namespace RoutingNavigationApp.Areas.User.Controllers
{
    [Area("User")]
    public class UserDashboardController : Controller
    {
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}
