using RedyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedyFitness.Controllers
{
    public class WorkoutsController : Controller
    {
        // GET: Workouts
        public ActionResult LogWorkout()
        {
            var exercises = GetExercises();

            var model = new LogWorkoutModel();

        //   model.Exercises = GetSelectListItems(exercises);

            return View();
        }

        [HttpPost]
        public ActionResult LogWorkout(LogWorkoutModel model)
        {
            var exercises = GetExercises();

          //  model.Exercises = GetSelectListItems(exercises);

            if (ModelState.IsValid)
            {
                Session["LogWorkoutModel"] = model;
                return RedirectToAction("Done");
            }
            return View("Workouts", model);
        }
        public ActionResult Done()
        {
            var model = Session["LogWorkoutModel"] as LogWorkoutModel;
            return View(model);
        }
        private IEnumerable<string>GetExercises()
        {
            return new List<string>
            {
                "Bench Press",
                "Shoulder Press",
                "Deadlift",
                "Squat"
            };
        }
        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string>elements)
        {
            var selectList = new List<SelectListItem>();
            foreach(var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }
            return selectList;
        }
    }
}