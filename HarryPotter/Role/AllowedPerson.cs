
using HarryPotter.DataBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WorkHandler;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class AllowedPerson : Human
    {
        public int AllowedPersonID { get; set; }
        public int RoomNumber { get; }
        public bool HasBaggage { get; }
        public Pet Pet { get; }
        public Role Role { get; }

        public new string FileName { get => "AllowedPerson.txt"; }

        public AllowedPerson(Human human, int allowedPersonID, int roomNumber, bool hasBaggage, Pet pet, Role role)
            : base(human.FirstName, human.LastName,
                  human.BirthYear, human.Gender,
                  human.FatherName, human.Username,
                  human.Password, human.Race)
        {
            AllowedPersonID = allowedPersonID;
            RoomNumber = roomNumber;
            HasBaggage = hasBaggage;
            Pet = pet;
            Role = role;
        }

        public AllowedPerson(string firstName, string lastName,
           int birthyear, GenderType gender, string fatherName,
           string username, string password, RaceBlood race,
           int roomNumber, Pet pet, bool hasBaggage, Role role) :

            base(firstName, lastName, birthyear,
                gender, fatherName, username, password, race)
        {
            RoomNumber = roomNumber;
            Pet = pet;
            HasBaggage = hasBaggage;
            Role = role;
        }

        public static Human GetHuman(string username) => Tables.Humans.FirstOrDefault(p => p.Username == username);

        public List<AllowedPerson> GetFromFile()
        {
            var list_temp = FileWorker.Read(FileName);
            var allowedPeople = new List<AllowedPerson>();

            foreach (List<string> person_info in list_temp)
            {
                int id = int.Parse(person_info[0]);
                int roomNumber = int.Parse(person_info[1]);
                var hasBaggage = bool.Parse(person_info[2]);
                Enum.TryParse(person_info[3], out Pet pet);
                Enum.TryParse(person_info[4], out Role role);

                var username = person_info[5];
                var human = GetHuman(username);

                allowedPeople.Add(new AllowedPerson(human, id, roomNumber, hasBaggage, pet, role));

            }
            return allowedPeople;
        }

        bool isEqual(AllowedPerson allowedPerson)
        {
            return allowedPerson.Pet == this.Pet && allowedPerson.Role == this.Role && allowedPerson.HasBaggage == this.HasBaggage;
        }
        bool IsDuplicate()
        {
            foreach (var allowedPerson in GetFromFile())
            {
                if (isEqual(allowedPerson))
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
            return $"{AllowedPersonID}|{RoomNumber}|{HasBaggage}|{Pet}|{Role}|{Username}";
        }

       
    }
}
