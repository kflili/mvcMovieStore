using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcMovieStore.Dtos;
using mvcMovieStore.Models;

namespace mvcMovieStore.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.MovieIDs.Count == 0)
            {
                return BadRequest("No Movie IDs have been given.");
            }

            var customer = _context.Customers
                .SingleOrDefault(c => c.ID == newRental.CustomerID);

            if (customer == null)
            {
                return BadRequest("CustomerID is not valid.");
            }

            var movies = _context.Movies.Where(m => newRental.MovieIDs.Contains(m.ID)).ToList();

            if (movies.Count != newRental.MovieIDs.Count)
            {
                return BadRequest("One or more movieIDs are invalid.");
            }

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
