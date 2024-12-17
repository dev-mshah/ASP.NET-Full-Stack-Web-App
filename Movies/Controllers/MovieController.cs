using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext Context { get; set; }

        public MovieController(MovieContext ctx)
        {
            Context = ctx;
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = Context.Movies.Find(id);
     
            
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            
            Context.Movies.Remove(movie);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Movie());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = Context.Movies.Find(id);
            return View(movie);
        }

        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                {
                    Context.Movies.Add(movie);
                }
                else
                {
                    Context.Movies.Update(movie);
                }
                Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            
            else
            {
                ViewBag.Action=(movie.MovieId==0) ? "Add":"Edit";
                return View(movie);
            }
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

