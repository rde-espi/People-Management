using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Models;

namespace PeopleManagement.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            return View("Index",user);
        }
        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "email enviaDO";
            return View("Index", user);
        }
    }
}
