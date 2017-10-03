using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16Erik.Contollers
{
    public class HomeController : Controller 
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
