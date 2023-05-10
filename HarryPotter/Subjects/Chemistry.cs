using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Chemistry : Subject
    {
        public List<Chemicals> Chemicals { get; }

        public Chemistry(string name, int capacity, uint semesterPresentation, uint minutesDuration):

            base( name, capacity, semesterPresentation, minutesDuration)
        {
            Chemicals = new List<Chemicals>();  
        }
    }
}
