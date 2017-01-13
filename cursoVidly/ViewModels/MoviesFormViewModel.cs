using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using cursoVidly.Models;

namespace cursoVidly.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int? stock { get; set; }

         public string Title
        {
            get
            {


                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

         public MoviesFormViewModel()
         {
             Id = 0;
         }
         public MoviesFormViewModel(Movies movies)
         {
                    Id = movies.Id;
                    Name = movies.Name;
                    ReleaseDate = movies.ReleaseDate;
                    DateAdded = movies.DateAdded;
                    stock = movies.stock;
                    GenreId = movies.GenreId;
         }
    }
}