using MyFollow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFollow.Controllers
{
    public class FollowController : Controller
    {
        // GET: Follow
        ContextFollow db = new ContextFollow();
        public ActionResult Index()
        {
            return View(db.Follow.ToList());
        }
    }
}