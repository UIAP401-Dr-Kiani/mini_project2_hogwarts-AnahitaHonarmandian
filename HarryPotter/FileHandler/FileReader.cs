using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkHandler;
using static HarryPotter.Enums;

namespace HarryPotter.FileHandler
{
    public static class FileReader
    {
        private const string DORM_FILE_NAME = "Dorm.txt";
        private const string LETTER_FILE_NAME = "Letter.txt";
        private const string GROUP_FILE_NAME = "Group.txt";
        private const string SUBJECT_FILE_NAME = "Subject.txt";
        private const string PROFESSOR_FILE_NAME = "Professor.txt";
        private const string ALLOWEDPERSON_FILE_NAME = "AllowedPerson.txt";

        public static List<AllowedPerson> GetFromFile()
        {
            var list_temp = FileWorker.Read(ALLOWEDPERSON_FILE_NAME);
            var allowedPeople = new List<AllowedPerson>();

            foreach (List<string> person_info in list_temp)
            {
                int id = int.Parse(person_info[0]);
                int roomNumber = int.Parse(person_info[1]);
                var hasBaggage = bool.Parse(person_info[2]);
                Enum.TryParse(person_info[3], out Pet pet);
                Enum.TryParse(person_info[4], out Role role);

                var username = person_info[5];
                var human = AllowedPerson.GetHuman(username);

                allowedPeople.Add(new AllowedPerson(human, id, roomNumber, hasBaggage, pet, role));
            }
            return allowedPeople;
        }

        public static List<Dorm> GetDorms()
        {
            var dorms = new List<Dorm>();
            var list_temp = WorkHandler.FileWorker.Read(DORM_FILE_NAME);

            foreach (List<string> dorm_info in list_temp)
            {
                int id = int.Parse(dorm_info[0]);
                string groupid = dorm_info[1];
                int floor = int.Parse(dorm_info[2]);
                int room = int.Parse(dorm_info[3]);
                Enum.TryParse(dorm_info[4], out GenderType gender);
                int bedCount = int.Parse(dorm_info[5]);

                dorms.Add(new Dorm(id, groupid, floor, room, gender, bedCount));
            }
            return dorms;
        }

        public static List<Letter> GetLetters()
        {
            var letter = new List<Letter>();
            var list_temp = FileWorker.Read(LETTER_FILE_NAME);

            foreach (List<string> letter_info in list_temp)
            {
                var id = Guid.Parse(letter_info[0]);
                string title = letter_info[1];
                string receiver = letter_info[2];
                string context = letter_info[3];
                var writeDateTime = DateTime.Parse(letter_info[4]);

                letter.Add(new Letter(id, title, receiver, context, writeDateTime, false));
            }
            return letter;
        }
        public static List<Group> GetGroups()
        {
            var group = new List<Group>();
            var list_temp = FileWorker.Read(GROUP_FILE_NAME);

            foreach (List<string> group_info in list_temp)
            {
                int id = int.Parse(group_info[0]);
                int score = int.Parse(group_info[1]);
                Enum.TryParse(group_info[2], out Types type);
                group.Add(new Group(id, score, type));
            }
            return group;
        }
        public static List<Subject> GetSubjects()
        {
            var subject = new List<Subject>();
            var list_temp = FileWorker.Read(SUBJECT_FILE_NAME);

            foreach (List<string> sub_info in list_temp)
            {
                int id = int.Parse(sub_info[0]);
                string name = sub_info[1];
                int capacity = int.Parse(sub_info[2]);
                int numberOfStudents = int.Parse(sub_info[3]);
                var semesterPresentation = uint.Parse(sub_info[4]);
                var time = uint.Parse(sub_info[5]);
                var proffesorID = int.Parse(sub_info[6]);
                subject.Add(new Subject(id, name, capacity, numberOfStudents, semesterPresentation, time, proffesorID));
            }
            return subject;
        }
        public static List<Professor> GetProffesors()
        {
            var professors = new List<Professor>();
            var list_temp = FileWorker.Read(PROFESSOR_FILE_NAME);

            foreach (List<string> person_info in list_temp)
            {
                var professorID = int.Parse(person_info[0]);
                var groupID = int.Parse(person_info[1]);
                var simultaneousTeaching = bool.Parse(person_info[2]);
                var allowedPersonID = int.Parse(person_info[3]);
                var allowedPerson = Professor.GetAllowedPerson(allowedPersonID);

                professors.Add(new Professor(allowedPerson, professorID, simultaneousTeaching, groupID));
            }
            return professors;
        }

      
        private const string CHEMICAL_FILE_NAME = "Chemical.txt";
        public static List<Chemicals> GetChemicals()
        {
            var chemicals = new List<Chemicals>();
            var list_temp = FileWorker.Read(CHEMICAL_FILE_NAME);

            foreach (List<string> chem_info in list_temp)
            {
                string name = chem_info[0];
                string formula = chem_info[1];

                chemicals.Add(new Chemicals(name, formula));
            }
            return chemicals;
        }

        

    }
}
