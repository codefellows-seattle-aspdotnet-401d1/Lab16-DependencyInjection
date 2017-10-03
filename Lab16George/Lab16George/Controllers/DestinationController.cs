using Microsoft.AspNetCore.Mvc;
using Lab16George.Models;

namespace Lab16George.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationRepository _destination;

        public DestinationController(IDestinationRepository destin)
        {
            _destination = destin;
        }

        public ViewResult Index()
        {
            return View(_destination.Destination);
        }
    }
}
