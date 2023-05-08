using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Semester2:Herbology
    {

        public Semester2(int capacity, uint semesterPresentation, uint minutesDuration, List<Plants> plants) :
             base("Semester1", capacity, semesterPresentation, new List<Plants>())
        {

        }
    }
}
