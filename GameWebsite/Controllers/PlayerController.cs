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
    }
}