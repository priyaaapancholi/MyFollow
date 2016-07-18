using MyFollow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFollow.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ContextFollow db = new ContextFollow();
        public ActionResult Index()
        {
            return View(db.Product.ToList());
        }
    }
}