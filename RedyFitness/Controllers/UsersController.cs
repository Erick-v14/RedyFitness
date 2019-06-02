using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedyFitness.Controllers
{
    public class UsersController : Controller
    {
        // GET: Customer
        public ActionResult CreateUser()
        {
            return View();
        }
    }
}