using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab16miya.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string welcomeString = "Here you can learn all you need to know about your upcoming travel destination.";
            return View(welcomeString);
        }
    }
}
