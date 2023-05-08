using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Subjects
    {

        public string Name { get; }
        public int Capacity { get; }
        public int NumberOfStudents { get; private set; }
        public uint SemesterPresentation { get; }
        public TimeSpan Time { get; set; }

        public Subjects(string name, int capacity, uint semesterPresentation, uint minuteDruration)
        {
            Name = name;
            Capacity = capacity;
            NumberOfStudents = 0;
            SemesterPresentation = semesterPresentation;
            Time = TimeSpan.FromMinutes(minuteDruration);
        }

        public void IncreaseStudent()
        {
            NumberOfStudents++;
        }
        public bool CanSignUp()
        {
            return Capacity - NumberOfStudents > 0;
        }




    }
}
