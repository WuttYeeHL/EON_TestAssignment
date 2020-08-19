using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eon_TestAssignment.Models;
using Eon_TestAssignment.Data;

namespace Eon_TestAssignment.Controllers
{
    public class HomeController : Controller
    {
        protected UserContext dbcontext;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult RegisteredForm()
        {
            return View();
        }

        public IActionResult RegisteredList([FromServices] UserContext dbcontext)
        {
            List<User> listReg = dbcontext.users.ToList();
            ViewData["user"] = listReg;
            return View();

           
        }

        public IActionResult AddUser([FromServices] UserContext dbcontext, string name, string email, string gender, string date, string days, string addReq)
        {
            
            User addUser = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Email = email,
                Gender = gender,
                RegisteredDate = date,
                SelectedDays = days,
                AddRequest = addReq
            };
            dbcontext.Add(addUser);
            dbcontext.SaveChanges();

            return RedirectToAction("RegisteredList", "Home");
        }
    }
}
