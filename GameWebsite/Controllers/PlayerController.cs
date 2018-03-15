using GameWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameWebsite.Controllers
{
    [Route("/Player")]
    public class PlayerController : Controller
    {
        // GET: Player
        GameDB dbConnnect = new GameDB();
        public ActionResult Index()
        {
            Console.WriteLine("Hello Player");
            return View(dbConnnect.Table.ToList());
        }


        [HttpPost]
        public ActionResult Register(string username, string email, string password)
        {
            if (username == null || email == null || password == null)
            {
                return null;
            }
            using (GameDB context = new GameDB())
            {
                context.Table.Add(new Player() { Username = username, Email = email, Password = password });
                context.SaveChanges();
            }

            //ViewBag.name = Username;
            return View();
        }
    }
}