using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesInClass.Controllers
{
    public class HomeController : Controller
    {
        MovieDBEntities db = new MoviesInClass.MovieDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Now doing Inventory";

            Inventory inv = db.Inventories.Find(4);

            return View(inv);
        }

        public ActionResult Contact()
        {
            var rentals = from r in db.Rentals
                          where r.CustomerID == 1 && r.DiskID == 2
                          select r;

            Rental rental = null;
            if (rentals.Count() > 0)
                rental = rentals.First();

            return View(rental);
        }
    }
}