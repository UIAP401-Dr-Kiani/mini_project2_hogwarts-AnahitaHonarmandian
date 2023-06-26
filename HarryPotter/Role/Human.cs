using System;
using System.Collections.Generic;
using static HarryPotter.Enums;
using WorkHandler;
using System.IO;
using System.Text;

using HarryPotter.DataBase;

namespace HarryPotter
{
    public class Human : IFileWorker
    {
        public string Username { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get { return FirstName + ' ' + LastName; } }
        public int BirthYear { get; }
        public string FatherName { get; }
        public string Password { get; }
        public string FileName { get => "human.txt"; }
        public GenderType Gender { get; }
        public RaceBlood Race { get; }


        public Human(string firstName, string lastName, int birthyear, GenderType gender, string fatherName, string username, string password, RaceBlood race)
        {
            FirstName = string.IsNullOrEmpty(firstName) ? "No Name" : firstName;
            LastName = lastName;
            BirthYear = Math.Abs(birthyear);
            Gender = gender;
            FatherName = fatherName;
            Username = username;
            Password = password;
            Race = race;
        }

        public static List<Student> GetFromFile()
        {

            var humans = new List<Student>();

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(@"C:\Users\1377t\Downloads\Telegram Desktop\HarryPotter\files\human.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    string[] person_info = line.Split(',');
                    //Console.WriteLine(parts[0]);

                    string firstName = person_info[0];
                    string lastName = person_info[1];
                    int birthyear = int.Parse(person_info[2]);
                    Enum.TryParse(person_info[3], out GenderType gender);
                    var fatherName = person_info[4];
                    var username = person_info[5];
                    var password = person_info[6];
                    Enum.TryParse(person_info[7], out RaceBlood race);
                    int room_number = int.Parse(person_info[8]);
                    Enum.TryParse(person_info[9], out Pet pet);
                    Enum.TryParse(person_info[10], out Role role);
                    int passedCourse = int.Parse(person_info[11]);
                    int semester = int.Parse(person_info[12]);
                    int dormnumber = int.Parse(person_info[13]);
                    string s_id = person_info[14];

                    humans.Add(new Student(firstName, lastName, birthyear, gender, fatherName, username, password, race, room_number, pet, role, passedCourse, semester, dormnumber, s_id));
                    Tables.Students.Add(new Student(firstName, lastName, birthyear, gender, fatherName, username, password, race, room_number, pet, role, passedCourse, semester, dormnumber, s_id));
                }
            }

            return humans;
        }
        bool IsEqual(Human human)
        {
            return human.FirstName == this.FirstName && human.LastName == this.LastName && human.FatherName == this.FatherName;
        }
        bool IsDuplicate()
        {
            foreach (var human in GetFromFile())
            {
                if (IsEqual(human))
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
            return $"{FirstName}|{LastName}|{BirthYear}|{Gender}|{FatherName}|{Username}|{Password}|{Race}";
        }

        public override string ToString()
        {
            return $"{FirstName}|{LastName}|{BirthYear}|{Gender}|{FatherName}|{Username}|{Password}|{Race}";
        }
    }
}
