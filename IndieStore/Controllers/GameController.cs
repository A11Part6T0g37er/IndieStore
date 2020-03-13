using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IndieStore.Controllers
{
    public class GameController : Controller
    {
        IGamesRepository repo;
      public  GameController(IGamesRepository r)
        {
            repo = r;
        }
        public ActionResult Index()
        {
            //TODO Repo demo
            repo.GetGamesList();
            var game = new Game() {Name="DOOM" };
            return View(game);
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