﻿using MyFollow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFollow.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        FollowContext db = new FollowContext();
        public ActionResult Index()
        {
            return View(db.ProductDetail.ToList());
        }
    }
}