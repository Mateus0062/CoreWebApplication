using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Message()
        {
            return View();
        }
    }
}
