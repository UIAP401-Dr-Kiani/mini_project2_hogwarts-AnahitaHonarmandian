using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Subjects
    {
        

        //TODO-time

        public int NumberOfStudents { get; }
        public int Capacity { get ; }
        public uint SemesterPresentation { get ; }
        public string Name { get ; }

        public Subjects(int numberOfStudents, int capacity, uint semesterPresentation, string name)
        {
            NumberOfStudents = numberOfStudents;
            Capacity = capacity;
            SemesterPresentation = semesterPresentation;
            Name = name;
        }



        public Subjects() { }
    }
}
