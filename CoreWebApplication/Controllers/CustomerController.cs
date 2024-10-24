using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class CustomerController : Controller
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
            return View();
        }

        //[Route("~/")]
        //[Route("/sample/message")]

        public IActionResult Message()
        {
            return View();
        }
    }
}
