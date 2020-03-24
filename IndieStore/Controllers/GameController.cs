using DomainModel;
using DomainModel.Explicit_Realization;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IndieStore.Controllers
{
    public class GameController : Controller
    {
     public   EFGameRepository repo;
      public  GameController()
        {
            repo = new EFGameRepository();
        }
        
        public ActionResult Index()
        {
            //TODO Repo demo
            IEnumerable<Game> game =  repo.GetGamesList();
      //      var game = new Game() { Name = "DOOM", Categories = { new Category() { Name = "DTF" } }, Description = "DOOM e g",Id =10, GameId= 10, Price=999 };
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose(true);
            }
            base.Dispose(disposing);
        }
    }
}