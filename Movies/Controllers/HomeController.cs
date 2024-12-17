using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using System.Diagnostics;

namespace Movies.Controllers
{
	public class HomeController: Controller
	{
		private MovieContext Context { get; set; }

		public HomeController(MovieContext ctx)
		{
			this.Context = ctx;
		}
		public IActionResult Index()
		{
			var movies = Context.Movies.OrderBy(m => m.Name).ToList();
			return View(movies);

		}
	}
}

