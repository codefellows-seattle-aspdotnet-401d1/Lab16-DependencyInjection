using Lab16Tom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16Tom.Controllers
{
    public class DestinationsController : Controller
    {
        private IDestinationsRepository _repository;

        public DestinationsController(IDestinationsRepository repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Destinations);
        }
        
    }
}
