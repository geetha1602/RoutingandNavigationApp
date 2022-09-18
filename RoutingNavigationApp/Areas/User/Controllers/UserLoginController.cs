using Microsoft.AspNetCore.Mvc;
using RoutingNavigationApp.Areas.User.Models;
using System.Reflection;

namespace RoutingNavigationApp.Areas.User.Controllers
{
    [Area("User")]
    public class UserLoginController : Controller
    {
        public IActionResult ULogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ULogin(UserModel um)
        {
            if (ModelState.IsValid)
            {
                if (um.Name == "User")
                {
                    TempData["Name"] = um.Name;
                    return RedirectToAction("UserDashboard", "UserDashboard");
                }
            }
            return View();
        }
    }
}
