﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLharjoitusMVC.Controllers
{
    public class MyOwnPageController : Controller
    {
        // GET: MyOwnPage
        public ActionResult Index()
        {
            return View();
        }
    }
}