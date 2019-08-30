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
    // public static class SessionExtensions
    // {
    //     // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
    //     public static void SetObjectAsJson(this ISession session, string key, object value)
    //     {
    //         // This helper function simply serializes theobject to JSON and stores it as a string in session
    //         session.SetString(key, JsonConvert.SerializeObject(value));
    //     }

    //     // generic type T is a stand-in indicating that we need to specify the type on retrieval
    //     public static T GetObjectFromJson<T>(this ISession session, string key)
    //     {
    //         string value = session.GetString(key);
    //         // Upon retrieval the object is deserialized based on the type we specified
    //         return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    //     }
    // }
    public class HomeController : Controller
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
        // public Order loggedUserOrder 
        // {
        //     get{
        //         return dbContext.Orders
        //         .Include(o => o.ItemsOrdered)
        //             .ThenInclude(i => i.Product)
        //         .Include(o => o.ItemsOrdered)
        //             .ThenInclude(i => i.ChosenImage)
        //         .FirstOrDefault(o => o.PurchaseMade == false && o.Userid == loggedUser.Userid);
        //     }
        // }
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        //////////HOMEPAGE/////////////
        public IActionResult Index()
        {
            // ViewBag.UserCart = loggedUserOrder;
            ViewBag.User = loggedUser;
            if (ViewBag.User != null)
            {
                foreach (var order in ViewBag.User.Orders)
                {
                    System.Console.WriteLine(order.PurchaseMade);
                }
            }
            else
            {
                System.Console.WriteLine("there isn't anything in cart!");
            }
            return View();
        }
        //////////GALLERY OF ALL THE IMAGES TO CHOOSE FROM /////////////
        [HttpGet("gallery")]
        public IActionResult Gallery()
        {
            List<Gallery> AllImages = dbContext.Galleries
            .Include(p => p.Category)
            .ToList();
            // ViewBag.UserCart = loggedUserOrder;
            ViewBag.User = loggedUser;
            return View(AllImages);
        }
        //////////ABOUT US PAGE /////////////
        [HttpGet("aboutus")]
        public IActionResult AboutUs()
        {
            // ViewBag.UserCart = loggedUserOrder;
            ViewBag.User = loggedUser;
            return View();
        }
        //////////THE LIST OF PRODUCTS TO PURCHASE /////////////
        [HttpGet("store")]
        public IActionResult Store()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            // ViewBag.UserCart = loggedUserOrder;
            ViewBag.User = loggedUser;
            return View(AllProducts);
        }
        [HttpGet("image/{id}")]
        public IActionResult Image(int id)
        {
            Gallery ThisImage = dbContext.Galleries.FirstOrDefault(i => i.Galleryid == id);
            // ViewBag.UserCart = loggedUserOrder;
            ViewBag.ThisImage = ThisImage;
            ViewBag.User = loggedUser;
            return View();
        }
        [HttpPost("AddToCart/{id}")]
        public IActionResult AddToCart(int id, ProductQuantity thisProduct)
        {
            if (loggedUser == null)
            {
                HttpContext.Session.SetInt32("Galleryid", id);
                return RedirectToAction("Index", "Account");
            }
            else
            {
                // if(HttpContext.Session.GetObjectFromJson<List<Item>>("Cart") == null)
                // {
                //     List<Item> newCart = new List<Item>();
                //     HttpContext.Session.SetObjectAsJson("Cart", newCart);
                //     Product RequestedProduct = dbContext.Products.FirstOrDefault(p => p.Style == thisProduct.Style && p.Size == thisProduct.Size);
                //     Gallery ThisImage = dbContext.Galleries.FirstOrDefault(i => i.Galleryid == id);

                //     Item newItem = new Item();
                //     newItem.Productid = RequestedProduct.Productid;
                //     newItem.Orderid = (dbContext.Orders.LastOrDefault(o => o.Userid == loggedUser.Userid)).Userid;
                //     newItem.Galleryid = ThisImage.Galleryid;
                //     newItem.Quantity = thisProduct.Quantity;
                //     ViewBag.User = loggedUser;
                //     return View();
                // }
                // else
                // {

                // }
                //////need an if statement on if they already have an existing "Cart" --- or basically an Order that doesn't have their "PurchaseMade" bool as true....
                Order currentCart = loggedUser.Orders.FirstOrDefault(o => o.PurchaseMade == false);
                if (currentCart == null)
                {
                    Order newOrder = new Order();
                    newOrder.Userid = loggedUser.Userid;
                    dbContext.Orders.Add(newOrder);
                    dbContext.SaveChanges();
                    Product RequestedProduct = dbContext.Products.FirstOrDefault(p => p.Style == thisProduct.Style && p.Size == thisProduct.Size);
                    Gallery ThisImage = dbContext.Galleries.FirstOrDefault(i => i.Galleryid == id);

                    Item newItem = new Item();
                    newItem.Product = RequestedProduct;
                    newItem.Order = (dbContext.Orders.LastOrDefault(o => o.Userid == loggedUser.Userid));
                    newItem.ChosenImage = ThisImage;
                    newItem.Quantity = thisProduct.Quantity;
                    dbContext.Items.Add(newItem);
                    dbContext.SaveChanges();
                    ViewBag.User = loggedUser;
                    return RedirectToAction("Index");
                }
                else
                {
                    Product RequestedProduct = dbContext.Products.FirstOrDefault(p => p.Style == thisProduct.Style && p.Size == thisProduct.Size);
                    Gallery ThisImage = dbContext.Galleries.FirstOrDefault(i => i.Galleryid == id);

                    Item newItem = new Item();
                    newItem.Product = RequestedProduct;
                    newItem.Order = currentCart;
                    newItem.ChosenImage = ThisImage;
                    newItem.Quantity = thisProduct.Quantity;
                    dbContext.Items.Add(newItem);
                    dbContext.SaveChanges();
                    ViewBag.User = loggedUser;
                    return RedirectToAction("Index");
                }
            }
        }
        [HttpGet("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            Item thisItem = dbContext.Items.FirstOrDefault(i => i.Itemid == id);
            dbContext.Remove(thisItem);
            dbContext.SaveChanges();
            return RedirectToAction("ViewCart");
        }
        [HttpGet("viewcart")]
        public IActionResult ViewCart()
        {
            if (loggedUser == null)
            {
                return RedirectToAction("Index", "Account");
            }
            else
            {
                var currentCart = loggedUser.Orders
                .FirstOrDefault(o => o.PurchaseMade == false);
                Order CartItems = dbContext.Orders
                .Include(o => o.ItemsOrdered)
                    .ThenInclude(i => i.ChosenImage)
                .Include(o => o.ItemsOrdered)
                    .ThenInclude(i => i.Product)
                .FirstOrDefault(o => o.Orderid == currentCart.Orderid);
                double sum = 0;
                foreach (var item in CartItems.ItemsOrdered)
                {
                    double total = 0;
                    total += item.Product.Price;
                    total *= item.Quantity;
                    sum += total;
                }
                ViewBag.Total = sum;
                ViewBag.Cart = CartItems;
                ViewBag.User = loggedUser;
                return View();
            }
        }
        [HttpGet("test")]
        public IActionResult Test()
        {
            return View();
        }
    }
}
