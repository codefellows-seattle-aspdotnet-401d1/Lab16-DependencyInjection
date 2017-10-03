using lab16miya.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab16miya.Controllers
{
    public class DestinationController : Controller
    {
        //implementing dependency injection with the interface
        private IDestinationRepository _repository;

        public DestinationController(IDestinationRepository repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Destination);
        }
    }
}
