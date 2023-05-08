using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Semester1 : Herbology
    {

        public Semester1(int capacity, uint semesterPresentation, uint minutesDuration, List<Plants> plants) :
            base("Semester1", capacity, semesterPresentation, new List<Plants>())
        {
            
        }
    }
}
