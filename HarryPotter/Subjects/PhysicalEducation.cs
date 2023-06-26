using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class PhysicalEducation : Subject
        
    {
        public string ClassType { get; }
        public PhysicalEducation(string name, int capacity, uint semesterPresentation, uint minutesDuration, string classType, int professorID)
            : base(name, capacity, semesterPresentation, minutesDuration, professorID)
        {
            ClassType = classType;
        }
    }
}
