using System;
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

        //dropdown for workout entry
        public ActionResult workout()
        {
            #  region ViewBag
    List<SelectListItem> WorkoutList = new List<SelectListItem>() {
        new SelectListItem {
            Text = "Bench Press", Value = "1"
        },
        new SelectListItem {
            Text = "Squat", Value = "2"
        },
        new SelectListItem {
            Text = "Shoulder Press", Value = "3"
        },
        new SelectListItem {
            Text = "Dead Lift", Value = "4"
        },    
    };
            ViewBag.WorkoutList = WorkoutList;
            #  endregion
             return View();
        }


    }
}