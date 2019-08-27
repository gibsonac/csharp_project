using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using csharp_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace csharp_project.Controllers
{
    [Route("account/")]
    public class AccountController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public AccountController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                bool emailExists = dbContext.Users.Any(u => u.Email == user.Email);
                if (emailExists)
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                User newUser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                HttpContext.Session.SetInt32("Userid", newUser.Userid);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("submitlogin")]
        public IActionResult SubmitLogin(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LogEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LogPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    return View("Index");
                }
                User newUser = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LogEmail);
                HttpContext.Session.SetInt32("Userid", newUser.Userid);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
