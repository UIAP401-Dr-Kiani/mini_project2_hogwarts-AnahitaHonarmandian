using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Subject
    {

        public string Name { get; }
        public int Capacity { get; }
        public int NumberOfStudents { get; private set; }
        public uint SemesterPresentation { get; }
        public TimeSpan Time { get; set; }

        public Subject(string name, int capacity, uint semesterPresentation, uint minuteDuration)
        {
            Name = name;
            Capacity = capacity;
            NumberOfStudents = 0;
            SemesterPresentation = semesterPresentation;
            Time = TimeSpan.FromMinutes(minuteDuration);
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
