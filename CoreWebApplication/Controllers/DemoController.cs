using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CoreWebApplication.Controllers
{
    public class DemoController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 101, Name = "King", Amount = 12000},
            new Customer() {Id = 102, Name = "Mateus", Amount = 13000}
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Method1()
        {
            TempData["Message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Method2()
        {
            if (TempData["Message"] != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "Mateus");
            return RedirectToAction("Sucess");

        }

        public IActionResult Sucess()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Index");
        }
        
        public IActionResult QueryTest()
        {
            string name = "King Kochhar";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
            {
                name = HttpContext.Request.Query["name"];
            }
            ViewBag.Name = name;

            return View();
            
        }   
    }
}
