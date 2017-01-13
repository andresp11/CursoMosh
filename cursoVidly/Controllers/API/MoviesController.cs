using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using cursoVidly.Models;
using cursoVidly.DTOS;
using AutoMapper;
using System.Data.Entity;


namespace cursoVidly.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/Movies
        public IHttpActionResult GetMovies()
        {
            var movieDTO = _context.Movies.Include(c=> c.genre).
                                ToList().
                                Select(Mapper.Map<Movies, MovieDTO>);
            return Ok(movieDTO);
        }

        //Get /api/Movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movies, MovieDTO>(movie));
        }


        // post /api/Movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movie = Mapper.Map<MovieDTO, Movies>(movieDTO);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDTO.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDTO);
        }

        [HttpPut]
        //Put /api/Movies/1
        public void UpdateMovie(int id, MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var movieInDb = _context.Movies.SingleOrDefault(c=> c.Id == id);

            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map(movieDTO, movieInDb);
            

            _context.SaveChanges();

        }

        [HttpDelete]
        //Delete /api/Movies/1
        public void DeleteMovie(int id)
        {
            var MovieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (MovieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Movies.Remove(MovieInDb);
            _context.SaveChanges();
        }
    }
}
