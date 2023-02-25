using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieInfoContext movieContext { get; set; }
        //Constructor
        public HomeController( MovieInfoContext movie)
        {
            movieContext = movie;
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
            //pulls category data
            ViewBag.Categories = movieContext.Categories.ToList();
            return View();
        }

        //method to add movie to data base
        [HttpPost]
        public IActionResult NewMovies(TrackerEntry te)
        {
            ViewBag.Categories = movieContext.Categories.ToList();
            //method to add and save changes to entry if valid data is entered
            if (ModelState.IsValid)
            {
                movieContext.Add(te);
                movieContext.SaveChanges();
                return View("Confirmation", te);
            }
            //otherwise returns them back to the page they were on
            else
            {
                return View(te);
            }

        }
        //method to get podcasts page
        [HttpGet]
        public IActionResult Podcasts()
        {
            return View();
        }
        
        public IActionResult Collection()
        {
            var entries = movieContext.entries
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();
            return View(entries);
        }
        //method to edit an entry
        [HttpGet]
        public IActionResult Edit (int entryid)
        {
            //pulls category data
            ViewBag.Categories = movieContext.Categories.ToList();
            //creates variable holding data for the specified entry
            var entry = movieContext.entries.Single(x => x.EntryID == entryid);
            //returns NewMovies view with data from specified entry
            return View("NewMovies", entry);
        }
        //Saves the edits to the database
        [HttpPost]
        public IActionResult Edit (TrackerEntry blah)
        {
            //method to add and save changes to entry if valid data is entered
            if (ModelState.IsValid)
            {
                movieContext.Update(blah);
                movieContext.SaveChanges();
                return View("Confirmation", blah);
            }
            //otherwise returns them back to the page they were on
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int entryid)
        {
            //creates variable holding data for the specified entry
            var entry = movieContext.entries.Single(x => x.EntryID == entryid);
            //returns delete view with data from specified entry
            return View(entry);
        }
        [HttpPost]
        public IActionResult Delete (TrackerEntry te)
        {
            //method to delete and save changes to entry if valid data is entered
            movieContext.entries.Remove(te);
            movieContext.SaveChanges();
            //redirects back to collection view
            return RedirectToAction("Collection");
        }
    }
}
