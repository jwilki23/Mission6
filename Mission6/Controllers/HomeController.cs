using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext movie)
        {
            _logger = logger;
            _movieContext = movie;
        }
        //method for when you click on index
        public IActionResult Index()
        {
            return View();
        }
        //method for when retrieving new entry page
        [HttpGet]
        public IActionResult NewMovies ()
        {
            return View();
        }
        //method to get podcasts page
        [HttpGet]
        public IActionResult Podcasts()
        {
            return View();
        }
        //method to add movie to data base
        [HttpPost]
        public IActionResult NewMovies (TrackerEntry te)
        {
            _movieContext.Add(te);
            _movieContext.SaveChanges();
            return View("Confirmation");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
