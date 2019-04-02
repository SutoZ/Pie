using Microsoft.AspNetCore.Mvc;
using Pie.Models;
using Pie.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        //constructor injection
        public HomeController(IPieRepository pieRepository) => _pieRepository = pieRepository;

        public IActionResult Index()
        {
            //return View(_pieRepository.);
            var pies = _pieRepository
                        .GetAllPies()
                        .OrderBy(x => x.Name);

            var homeViewModel = new HomeViewModel { Title = "Something title for Pie", Pies = pies.ToList() };
            return View(homeViewModel);
        }
    }
}
