using System;
using System.Collections.Generic;
using System.Linq;
using RedyFitness.Controllers;

namespace RedyFitness.Dto
{
    public class EntryDTO
    {

        //add entry class
        public int id { get; set; }
      
        public DateTime Date { get; set; }

        public int ExerciseID { get; set; }


        public int Repitions { get; set; }
        
        public double Weight { get; set; }

        public string Notes { get; set; }
        

        public EntryDTO ToModel()
        {
            return new EntryDTO()
            {
                id = id,
                Date = Date,
                ExerciseID = ExerciseID,
                Repitions = Repitions,
                Weight = Weight,
                Notes = Notes
            };
        }
    }
   
}