using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarcraftChess.Controllers
{
    public class ChessController : Controller
    {
        // GET: Chess
        public ActionResult Chess()
        {
            return View();
        }
    }
}