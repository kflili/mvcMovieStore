using mvcMovieStore.Models;
using mvcMovieStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        // GET: Movies/Details/2
        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.ID == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { ID = 1, Name = "Shrek!" },
                new Movie { ID = 2, Name = "Wall-e"}
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}