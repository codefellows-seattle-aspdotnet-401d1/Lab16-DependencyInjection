using Microsoft.AspNetCore.Mvc;
using PackerPlanner.Models;

namespace PackerPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repo) => _repository = repo;

        public IActionResult Index()
        {
            return View(_repository.Destination);
        }
    }
}