using HarryPotter.DataBase;
using HarryPotter.FileHandler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkHandler;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Subject : IFileWorker
    {
        public int ID { get; set; }
        public string Name { get; }
        public int Capacity { get; }
        public int NumberOfStudents { get; private set; }
        public uint SemesterPresentation { get; }
        public uint Time { get; set; }
        public int ProfessorID { get; set; }

        public Professor Professor { get { return Tables.Professors.FirstOrDefault(p => p.ProfessorID == ProfessorID); } }
        public TimeSpan TimeSpan { get { return TimeSpan.FromMinutes(Time); } }

        public string FileName { get => "Subject.txt"; }

        public Subject(string name, int capacity, uint semesterPresentation, uint minuteDuration, int professorID)
            : this(new Random().Next(), name, capacity, 0, semesterPresentation, minuteDuration, professorID)
        {

        }

        public Subject(int id, string name, int capacity, int numberOfStudents, uint semesterPresentation, uint minuteDuration, int professorID)
        {
            ID = id;
            Name = name;
            Capacity = capacity;
            NumberOfStudents = numberOfStudents;
            SemesterPresentation = semesterPresentation;
            Time = minuteDuration;
            ProfessorID = professorID;
        }

        public void IncreaseStudent()
        {
            NumberOfStudents++;
        }
        public bool CanSignUp()
        {
            return Capacity - NumberOfStudents > 0;
        }


        bool IsEqual(Subject subject)
        {
            return subject.Name == this.Name && subject.Capacity == this.Capacity && subject.NumberOfStudents == this.NumberOfStudents &&
                subject.SemesterPresentation == this.SemesterPresentation && subject.Time == this.Time;
        }
        bool IsDuplicate()
        {
            foreach (var subject in FileReader.GetSubjects())
            {
                if (IsEqual(subject))
                    return true;
            }

            return false;
        }
        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write(FileName, ConvertToStringFile());
        }

        public string ConvertToStringFile()
        {
            return $"{ID}|{Name}|{Capacity}|{NumberOfStudents}|{SemesterPresentation}|{Time}|{ProfessorID}";
        }





    }
}
