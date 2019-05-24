using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedyFitness.Dto
{
    public class Entry
    {

        public string[] Workouts = new string[]
        {
            "Bench Press",
            "Squat",
            "Shoulder Press",
            "Deadlift"
        };

        //add entry class
        public int id { get; set; }
      
        public DateTime Date { get; set; }

        public int Exercise { get; set; }


        public int numOfReps { get; set; }
        
        public double numOfWeight { get; set; }

        public string notes { get; set; }
        

        public Entry ToModel()
        {
            return new Entry()
            {
                id = id,
                Date = Date,
                Exercise = Exercise,
                numOfReps = numOfReps,
                numOfWeight = numOfWeight,
                notes = notes
            };
        }
    }
   
}