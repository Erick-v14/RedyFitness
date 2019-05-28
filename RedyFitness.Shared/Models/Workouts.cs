using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedyFitness.Shared.Models
{
    class Workouts
    {
        public Workouts()
        {
            Entries = new List<Entry>();
        }
        public int ExerciseID { get; set; }
        public string Name { get; set; }
        public IList<Entry> Entries { get; set; }


    }
}
