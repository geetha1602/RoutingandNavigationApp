using Microsoft.AspNetCore.Mvc;
using RoutingNavigationApp.Areas.User.Models;

namespace RoutingNavigationApp.Areas.User.Controllers
{
    [Area("User")]
    public class UserProfileController : Controller
    {
        public IActionResult UserProfile()
        {
            
            return View();
        }
    }
}
