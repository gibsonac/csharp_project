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
    public class HomeController : Controller
    {
        public User loggedUser
        {
            get{
                return dbContext.Users.FirstOrDefault(u => u.Userid == HttpContext.Session.GetInt32("Userid"));
            }
        }
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
//////////HOMEPAGE/////////////
        public IActionResult Index()
        {
            ViewBag.User = loggedUser;
            return View();
        }
//////////GALLERY OF ALL THE IMAGES TO CHOOSE FROM /////////////
        [HttpGet("gallery")]
        public IActionResult Gallery()
        {
            List<Gallery> AllImages = dbContext.Galleries.ToList();

            ViewBag.User = loggedUser;
            return View(AllImages);
        }
//////////ABOUT US PAGE /////////////
        [HttpGet("aboutus")]
        public IActionResult AboutUs()
        {
            ViewBag.User = loggedUser;
            return View();
        }
//////////THE LIST OF PRODUCTS TO PURCHASE /////////////
        [HttpGet("store")]
        public IActionResult Store()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.User = loggedUser;
            return View(AllProducts);
        }
        [HttpGet("image/{id}")]
        public IActionResult Image(int id)
        {
            Gallery ThisImage = dbContext.Galleries.FirstOrDefault(i => i.Galleryid == id);
            ViewBag.ThisImage = ThisImage;
            ViewBag.User = loggedUser;
            return View();
        }
        [HttpPost("AddToCart/{id}")]
        public IActionResult AddToCart(int id, ProductQuantity thisProduct)
        {
            Order newOrder = new Order();
            newOrder.Userid = loggedUser.Userid;
            dbContext.Orders.Add(newOrder);
            dbContext.SaveChanges();
            Product RequestedProduct = dbContext.Products.FirstOrDefault(p => p.Style == thisProduct.Style && p.Size == thisProduct.Size);
            Gallery ThisImage = dbContext.Galleries.FirstOrDefault(i => i.Galleryid == id);

            Item newItem = new Item();
            newItem.Productid = RequestedProduct.Productid;
            newItem.Orderid = (dbContext.Orders.LastOrDefault(o => o.Userid == loggedUser.Userid)).Userid;
            newItem.Galleryid = ThisImage.Galleryid;
            newItem.Quantity = thisProduct.Quantity;
            dbContext.Items.Add(newItem);
            dbContext.SaveChanges();
            ViewBag.User = loggedUser;
            return View();
        }
    }
}
