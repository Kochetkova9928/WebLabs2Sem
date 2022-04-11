using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebLabs.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var model = new SignUpFirstViewModel
            {
                Birthday = DateTime.Now
            };

            return View("SignUpFirst", model);
        }

        [HttpPost]
        public IActionResult SignUp(SignUpFirstViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("SignUpFirst", model);
            }

            var signUpSecondViewModel = new SignUpSecondViewModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Birthday = model.Birthday,
                Gender = model.Gender
            };

            return View("SignUpSecond", signUpSecondViewModel);
        }


        [HttpPost]
        public IActionResult SignUpComplete(SignUpSecondViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("SignUpSecond", model);
            }

            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Birthday = model.Birthday,
                Gender = model.Gender,
                Email = model.Email,
                Password = model.Password
            };

            return View("SignUpResult", user);
        }


        [HttpGet]
        public IActionResult PasswordReset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PasswordReset(PasswordResetModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View("VerifyPasswordReset");
        }


        [HttpGet]
        public IActionResult VerifyPasswordReset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerifyPasswordReset(VerifyPasswordResetModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Code != "AdminCode" && model.Code != "123")
            {
                ModelState.AddModelError("Code", "Неверный код");

                return View(model);
            }

            return View("VerifyPasswordResetResult");
        }
    }
}
