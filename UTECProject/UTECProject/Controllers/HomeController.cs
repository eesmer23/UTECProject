﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UTECProject.Models;

namespace UTECProject.Controllers
{
    PortalDB d = new PortalDB();
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CrearUsuario()
        {
            return View();
        }
    }
}