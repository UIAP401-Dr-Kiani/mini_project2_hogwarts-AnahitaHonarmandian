using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     public class Herbology : Subjects
    
    {
        public List<Plants> Plants { get; private set; }

        //public List<Semester1> Semester1Plants { get;  }
        //public List<Semester2> Semester2Plants { get; }
        //public List<Semester3> Semester3Plants { get; }



        public Herbology(string name, int capacity, uint semesterPresentation, uint minutesDuration, List<Plants> plants):
            base( name, capacity, semesterPresentation, minutesDuration)
        {

            Plants = plants;

            //Semester1Plants = new List<Semester1>();
            //Semester2Plants = new List<Semester2>();
            //Semester3Plants = new List<Semester3>();


        }

           


    }
}
