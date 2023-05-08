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
       

       public AllowedPerson(string firstName, string lastName, 
           int birthyear, Gender gender, string fatherName,
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
    }
}
