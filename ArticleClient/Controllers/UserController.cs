﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArticleClient.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddNew()
        {

            return View();
        }

        public ActionResult Profile()
        {

            return View();
        }
	}
}