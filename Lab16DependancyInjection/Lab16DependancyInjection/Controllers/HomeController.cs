using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab16DependancyInjection.Controllers.HomeController
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}