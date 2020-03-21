using DomainModel;
using DomainModel.Explicit_Realization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IndieStore.Controllers
{
    public class GameController : Controller
    {
        EFGameRepository repo;
      public  GameController()
        {
            repo = new EFGameRepository();
        }
        public ActionResult Index()
        {
            //TODO Repo demo
            repo.GetGamesList();
            var game = new Game() { Name = "DOOM", Categories = { new Category() { Name = "DTF" } } };
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