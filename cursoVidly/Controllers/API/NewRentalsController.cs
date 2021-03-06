﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using cursoVidly.Models;
using cursoVidly.DTOS;


namespace cursoVidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
            private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
               

        // post /api/Movies
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDTO rentalDTO)
        {
            var customer = _context.Customer.Single(
                 c => c.Id == rentalDTO.CustomerId);
 
             var movies = _context.Movies.Where(
                 m => rentalDTO.MovieIds.Contains(m.Id)).ToList();

             foreach (var movie in movies)
             {
                 if (movie.NumberAvailable == 0)
                     return BadRequest("Movie is not available.");

                 
                 movie.NumberAvailable--;
                 

                 var rental = new Rental
                 {
                     Customer = customer,
                     Movie = movie,
                     DateRented = DateTime.Now
                 };
 
                 _context.Rental.Add(rental);
             }
 
             _context.SaveChanges();

             
        return Ok();
        
        }
            

    }
}