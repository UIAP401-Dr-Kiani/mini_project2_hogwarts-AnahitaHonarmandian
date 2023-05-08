using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Herbology : Subjects
    
    {
        
        public List<Semester1> Semester1Plants { get;  }
        public List<Semester2> Semester2Plants { get; }
        public List<Semester3> Semester3Plants { get; }

        public Herbology(string name, int capacity, uint semesterPresentation, uint minutesDuration):
            base( name, capacity, semesterPresentation, minutesDuration)
        {
            Semester1Plants = new List<Semester1>();
            Semester2Plants = new List<Semester2>();
            Semester3Plants = new List<Semester3>();


        }

           


    }
}
