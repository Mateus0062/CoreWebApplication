using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WeaklyTypedForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSucess(Account login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new Account() { Username = "Bhawana",Password = "123456"};
            return View(user);
        }

        public IActionResult UserList()
        {
            var user = new List<Account>()
            {
                new Account() {Username = "Mateus", Password = "123"},
                new Account() {Username = "Luana", Password = "456"},
                new Account() {Username = "Miguel", Password = "789"},
                new Account() {Username = "Renata", Password = "123456789"}
            };
            return View(user);
        }
    }
}
