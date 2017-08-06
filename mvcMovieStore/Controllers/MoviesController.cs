using mvcMovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // demostrate action parameters
        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            pageIndex = pageIndex ?? 1;
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(string.Format($"pageIndex = {pageIndex} & sortBy = {sortBy}"));
        }
    }
}