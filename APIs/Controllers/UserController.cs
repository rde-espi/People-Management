using APIs.Validator;
using Common;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public IActionResult Create(UserModel user)
        {
            
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + "Failed Validation. Error was: " + failure.ErrorMessage);
                }
            }

            if (user.Password == "123")
            {
                return Ok(new { Response = "OK" });
            }
            else
            {
                return Ok(new { Response = "Error" });
            }

        }

        [HttpPost("forgot")]
        public IActionResult Forgot([FromBody]string email)
        {
            return Ok(new { Response = "OK" });
        }

        [HttpPost("reset")]
        public IActionResult Reset(UserModel user)
        {
            return Ok(new { Response = "OK" });
        }
    }
}
