using System.Collections.Generic;
using static HarryPotter.Enums;
using WorkHandler;

using System.Linq;
using HarryPotter.FileHandler;
using System;
using HarryPotter.DataBase;

namespace HarryPotter
{
    public class Professor : AllowedPerson
    {
        public int ProfessorID { get; set; }
        public int GroupID { get; }
        public bool SimultaneousTeaching { get; }
        public new string FileName { get => "Professor.txt"; }
        public static AllowedPerson GetAllowedPerson(int allowedPersonID) =>
            Tables.AllowedPersons.FirstOrDefault(p => p.AllowedPersonID == allowedPersonID);

        public Group GetGroup() =>
            Tables
            .Groups
            .FirstOrDefault(g => g.ID == GroupID);

        public IEnumerable<Subject> GetPresentedCourses() =>
            Tables.Subjects.Where(s => s.ProfessorID == ProfessorID);
        public Professor(AllowedPerson allowedPerson, int professorId, bool simultaneousTeaching, int groupid) :

            base(GetHuman(allowedPerson.Username), allowedPerson.AllowedPersonID,
                allowedPerson.RoomNumber, allowedPerson.HasBaggage, allowedPerson.Pet, allowedPerson.Role)
        {
            ProfessorID = professorId;
            SimultaneousTeaching = simultaneousTeaching;
            GroupID = groupid;
        }

        public Professor(int id, string firstName, string lastName,
                         int birthyear, GenderType gender, string fatherName,
                         string username, string password, RaceBlood race,
                         int roomNumber, Pet pet, bool hasBaggage, Role role,
                         bool simultaneousTeaching, int groupid) :

            base(firstName, lastName, birthyear, gender,
                 fatherName, username, password, race,
                 roomNumber, pet, hasBaggage, role)
        {
            ProfessorID = id;
            SimultaneousTeaching = simultaneousTeaching;
            GroupID = groupid;
        }

        void AddNewCourse(Subject subject)
        {
            if (subject == null)
                throw new ArgumentNullException();

            if (!GetPresentedCourses()
                .Any(s => s.SemesterPresentation == subject.SemesterPresentation &&
                s.TimeSpan == subject.TimeSpan &&
                s.Professor.SimultaneousTeaching))
                Tables.Subjects.Add(subject);

            if (!GetPresentedCourses().Any(s => s.SemesterPresentation == subject.SemesterPresentation))
                Tables.Subjects.Add(subject);

        }
        bool isEqual(Professor professor)
        {
            return professor.FullName == this.FullName && professor.GroupID == this.GroupID && professor.SimultaneousTeaching == this.SimultaneousTeaching;
        }
        bool IsDuplicate()
        {
            foreach (var professor in FileReader.GetProffesors())
            {
                if (isEqual(professor))
                    return true;
            }

            return false;
        }

        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write(FileName, ReadyToWrite());
        }

        public string ReadyToWrite()
        {
            return $"{ProfessorID}|{GroupID}|{SimultaneousTeaching}|{AllowedPersonID}";
        }



    }
}
