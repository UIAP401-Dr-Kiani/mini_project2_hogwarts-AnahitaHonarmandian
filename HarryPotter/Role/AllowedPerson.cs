using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class AllowedPerson : Human
    {
        //TODO- schedule

        public int RoomNumber{ get  ;}
        public Pet Pet { get ; }       
         
        public bool HasBaggage { get; }
        public Role Role { get; }

        public List<Letter> ReceivedLetters { get; }

        public new string FileName { get => "AllowedPerson.txt"; }
       

       public AllowedPerson(string firstName, string lastName, 
           int birthyear, GenderType gender, string fatherName,
           string username, string password, RaceBlood race,
           int roomNumber, Pet pet,  bool hasBaggage, Role role):
            
            base(firstName, lastName, birthyear,
                gender, fatherName, username, password, race)
        {
            RoomNumber = roomNumber;
            Pet = pet;
            HasBaggage = hasBaggage;
            Role = role;
            ReceivedLetters = new List<Letter>();
        }

        public void AddToLetters (Letter letter)
        {
            ReceivedLetters.Add(letter);
        }

        public List<AllowedPerson> GetFromFile()
        {
            var AllowedPerson = new List<AllowedPerson>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> person_info in list_temp)
            {
               
                int roomNumber = int.Parse(person_info[0]);
                Enum.TryParse(person_info[1], out Pet pet);
                var hasBaggage = person_info[2];
                Enum.TryParse(person_info[3], out Role role);
                var letters = person_info[4];

                AllowedPerson.Add(new AllowedPerson(roomNumber,pet,hasBaggage,role,letters));;
            }
            return AllowedPerson;
        }
        bool isEqual(AllowedPerson allowedPerson)
        {
            return  allowedPerson.Pet ==this.Pet && allowedPerson.Role==this.Role && allowedPerson.HasBaggage==this.HasBaggage;
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
            return $"{RoomNumber}|{HasBaggage}|{Pet}|{Role}|{ReceivedLetters}";
        }
    }
}
