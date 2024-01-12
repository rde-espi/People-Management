﻿using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using PeopleManagement.Models;
using PeopleManagement.Models.Validator;
using System;

namespace PeopleManagement.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            UserViewModel user = new UserViewModel();
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);
            if (!results.IsValid)
            {
                foreach(var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + "Failed Validation. Error was: " + failure.ErrorMessage);
                }
            }
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
