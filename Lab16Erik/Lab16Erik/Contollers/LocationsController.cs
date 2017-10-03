using Lab16Erik.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16Erik.Contollers
{
    public class LocationsController : Controller
    {
        private readonly ILocationRepo _repository;

        public LocationsController(ILocationRepo repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Location);
        }    
    }
}
