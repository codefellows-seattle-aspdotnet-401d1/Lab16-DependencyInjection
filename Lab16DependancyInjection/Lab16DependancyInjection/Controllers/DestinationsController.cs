using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab16DependancyInjection.Models;

namespace Lab16DependancyInjection.Controllers
{
    public class DestinationsController : Controller
    {
        private IDestinationsRepository repository;

        public DestinationsController(IDestinationsRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {

            return View(repository.Destinations);
        }
    }
    
}