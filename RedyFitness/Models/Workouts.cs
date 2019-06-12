using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RedyFitness.Models
{
    public class Workouts
    {
        public int id { get; set; }
        public string Name { get; set; }

        [Required]
        [Display(Name = "Reps")]
        public int MaxReps { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public double MaxWeight { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage ="Please enter a valid date")]
        public DateTime EntryDate { get; set; }


    }
    public class LogWorkoutModel
    {
     
       public List<string> ExerciseList = new List<string>
            (new string[]
            {
                "Deadlift",
                "Bench Press",
                "Squat",
                "Shoulder Press",
            });
        [Required]
        [Display(Name ="Reps")]
        public int MaxReps { get; set; }

        [Required]
        [Display(Name ="Weight")]
        public double MaxWeight { get; set; }

        [Required]
        [Display(Name ="Exercises")]
        public string Exercises { get; set; }

        public IEnumerable<SelectListItem> workouts { get; set; }
        
    }
}