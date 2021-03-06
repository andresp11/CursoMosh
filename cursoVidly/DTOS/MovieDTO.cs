﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using cursoVidly.Models;

namespace cursoVidly.DTOS
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        
        public int GenreId { get; set; }

        [Required]
        
        public DateTime ReleaseDate { get; set; }

        [Required]
        
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        
        public int stock { get; set; }

        public Genre genre { get; set; }

        public int NumberAvailable { get; set; }
    }
}