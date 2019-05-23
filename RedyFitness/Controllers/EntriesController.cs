﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedyFitness.Dto;

namespace RedyFitness.Controllers
{
    public class EntriesController : Controller
    {
        // GET: Entries
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View(new Login());
        }
    }
}