using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballApp.Models;

namespace FootballApp.Controllers
{
    public class HomeController : Controller
    {

        private FootballdatabaseEntities _db = new FootballdatabaseEntities();

        public ActionResult Index()
        {
            return View(_db.FootballTeamsTables.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}