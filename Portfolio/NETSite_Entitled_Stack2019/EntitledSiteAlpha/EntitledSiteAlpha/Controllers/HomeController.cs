using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntitledSiteAlpha.Models;
using Microsoft.AspNetCore.Authorization;

namespace EntitledSiteAlpha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Bank()
        {
            ViewData["Message"] = "This will be the guild bank page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "This page must have a contact form to send an email to an admin.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Roster()
        {
            ViewData["Message"] = "This page must show all the guild members and their current DKP.";

            return View();
        }

        public IActionResult RoleCreator()
        {
            return View();
        }

        public IActionResult UpdateDKP()
        {
            return View();  
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
