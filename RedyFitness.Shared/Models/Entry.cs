using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RedyFitness.Shared.Models
{
   public class Entry
    {
        public Entry()
        {

        }
        public int ExerciseID { get; set; }

        public DateTime Date { get; set; }
        public int Repititions { get; set; }
        public decimal Weight { get; set; }
        public string Notes { get; set; }



    }
}
