using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Models;
using PeopleManagement.Models.Validator;

namespace PeopleManagement.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            UserViewModel user = new UserViewModel();
            UserValidator validationRules = new UserValidator();
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
