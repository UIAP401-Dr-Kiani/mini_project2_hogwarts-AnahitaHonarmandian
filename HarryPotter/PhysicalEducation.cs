using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class PhysicalEducation : Subjects
        
    {
        public string ClassType { get ; }

        public PhysicalEducation(string name, int capacity, uint semesterPresentation, uint minutesDuration,string classType)
            :base( name, capacity, semesterPresentation, minutesDuration)
        {
           ClassType = classType;
        }
    }
}
