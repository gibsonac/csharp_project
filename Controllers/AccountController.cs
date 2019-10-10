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
    [Route("account")]
    public class AccountController : Controller
    {
        public User loggedUser
        {
            get
            {
                return dbContext.Users
                .Include(u => u.Orders)
                    .ThenInclude(o => o.ItemsOrdered)
                    .ThenInclude(i => i.Product)
                .Include(u => u.Orders)
                    .ThenInclude(o => o.ItemsOrdered)
                    .ThenInclude(i => i.ChosenImage)
                .FirstOrDefault(u => u.Userid == HttpContext.Session.GetInt32("Userid"));
                
            }
        }
        private MyContext dbContext;
        public AccountController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            ViewBag.User = loggedUser;
            return View();
        }
        //////////REGISTERING A NEW USER /////////////
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                bool emailExists = dbContext.Users.Any(u => u.Email == user.Email);
                if (emailExists)
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    ViewBag.User = loggedUser;
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                User newUser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                HttpContext.Session.SetInt32("Userid", newUser.Userid);
                if (HttpContext.Session.GetInt32("Galleryid") == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    int? id = HttpContext.Session.GetInt32("Galleryid");
                    return RedirectToAction("Image", "Home", new { id = id });
                }

            }
            ViewBag.User = loggedUser;
            return View("Index");
        }
        //////////LOGGING IN AN EXISITING USER /////////////
        [HttpPost("submitlogin")]
        public IActionResult SubmitLogin(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LogEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    ViewBag.User = loggedUser;
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LogPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                    ViewBag.User = loggedUser;
                    return View("Index");
                }
                User newUser = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LogEmail);
                HttpContext.Session.SetInt32("Userid", newUser.Userid);
                if (HttpContext.Session.GetInt32("Galleryid") == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    int id = (int)HttpContext.Session.GetInt32("Galleryid");
                    return RedirectToAction("Image", "Home", new { id = id });
                }
            }
            ViewBag.User = loggedUser;
            return View("Index");
        }


        [HttpPost("Update/{id}")]
        public IActionResult Update(User oldInfo, int id)
        {
            User toUpdate = dbContext.Users.FirstOrDefault(d => d.Userid == id);
            if (toUpdate == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                toUpdate.First_Name = oldInfo.First_Name;
                toUpdate.Last_Name = oldInfo.Last_Name;
                toUpdate.Email = oldInfo.Email;
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                toUpdate.Password = Hasher.HashPassword(toUpdate, oldInfo.Password);
                toUpdate.Street = oldInfo.Street;
                toUpdate.State = oldInfo.State;
                toUpdate.City = oldInfo.City;
                toUpdate.Zipcode = oldInfo.Zipcode;
                dbContext.SaveChanges();
                return RedirectToAction("AccountInfo", "Account");
            }
        }

        //////////LOGGING USER OUT /////////////
        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        //////////LIST OF PAST ORDERS PAGE /////////////
        [HttpGet("orders")]
        public IActionResult Orders()
        {
            List<Order> OrderList = dbContext.Orders
            .Include(o => o.ItemsOrdered)
                .ThenInclude(i => i.Product)
            .Include(o => o.ItemsOrdered)
                .ThenInclude(i => i.ChosenImage)
            .Where(o => o.Userid == HttpContext.Session.GetInt32("Userid") && o.PurchaseMade == true)
            .ToList();
            ViewBag.User = loggedUser;
            return View(OrderList);
        }

        //////////ACCOUNT INFO PAGE /////////////
        [HttpGet("info")]
        public IActionResult AccountInfo()
        {
            ViewBag.User = loggedUser;
            return View(loggedUser);
        }
    }
}