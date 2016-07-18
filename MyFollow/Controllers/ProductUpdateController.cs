using MyFollow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFollow.Controllers
{
    public class ProductUpdateController : Controller
    {
        // GET: ProductUpdate
        ContextFollow db = new ContextFollow();
        public ActionResult Index()
        {
            return View(db.ProductUpdate.ToList());
        }
    }
}