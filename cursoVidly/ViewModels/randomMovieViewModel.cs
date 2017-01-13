using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cursoVidly.Models;

namespace cursoVidly.ViewModels
{
    public class randomMovieViewModel
    {
        public Movies Movie {get; set;}
        public List<Customers> Customers { get; set; }


    }
}