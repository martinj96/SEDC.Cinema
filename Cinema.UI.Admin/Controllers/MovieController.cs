﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Admin.Controllers
{
    public class MovieController : BaseController
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
    }
}