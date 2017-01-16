﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cursoVidly.Models;
using System.ComponentModel.DataAnnotations;

namespace cursoVidly.Models
{
    public class Rental
    {
         public int Id { get; set; }
 
         [Required]
         public Customers Customer { get; set; }
          [Required]
         public Movies Movie { get; set; }
 
         public DateTime DateRented { get; set; }
 
         public DateTime? DateReturned { get; set; }

    }
}