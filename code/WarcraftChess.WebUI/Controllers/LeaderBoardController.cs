using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarcraftChess.Controllers
{
    public class LeaderboardController : Controller
    {
        // GET: LeaderBoard
        public ActionResult Leaderboard()
        {
            return View();
        }
    }
}