using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Details()
        {
            ViewBag.seriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final Issue!! Witness the final hour </p>";
            ViewBag.artists = new string[]
            {
                "Script: Dan Scott",
                "Inking: Peter Stones"
            };

            return View();
        }
    }
}