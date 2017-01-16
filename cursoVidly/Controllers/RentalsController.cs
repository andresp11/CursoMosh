using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cursoVidly.Models;
using System.Data.Entity;
using cursoVidly.ViewModels;


namespace cursoVidly.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }
    }
}