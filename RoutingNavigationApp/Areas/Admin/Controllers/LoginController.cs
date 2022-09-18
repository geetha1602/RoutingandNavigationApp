using Microsoft.AspNetCore.Mvc;
using RoutingNavigationApp.Areas.Admin.Models;


namespace RoutingNavigationApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminModel am)
        {
            if (ModelState.IsValid)
            {
                if (am.Name == "Admin")
                {
                    TempData["Name"] = am.Name;
                    return RedirectToAction("AdminDashboard", "Dashboard");
                }
            }
            return View();
        }
    }
}
