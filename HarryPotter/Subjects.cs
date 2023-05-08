using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Subjects
    {

        public string Name { get; }
        public int NumberOfStudents { get; private set; }
        public int Capacity { get ; }
        public uint SemesterPresentation { get; set; }
        public TimeSpan Time { get; }
        

        public Subjects(string name, int capacity, uint semesterPresentation, uint minutesDuration )
        {
            NumberOfStudents = 0;
            Capacity = capacity;
            SemesterPresentation = semesterPresentation;
            Name = name;
            Time= TimeSpan.FromMinutes( minutesDuration );
        }



        
    }
}
