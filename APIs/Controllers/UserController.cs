using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //public IActionResult Login()
        //{
        //    return Ok();
        //}
       
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (user.Password == "123")
            { 
                return Ok(new { Response = "OK" }); 
            }
            else
            {
                return Ok(new { Response = "Error" });
            }
            
        }

        [HttpPost("Create")]
        public IActionResult SignUp(UserModel user)
        {
            if (user.Password == "123")
            {
                return Ok(new { Response = "OK" });
            }
            else
            {
                return Ok(new { Response = "Error" });
            }

        }
    }
}
