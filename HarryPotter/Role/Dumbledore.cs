using HarryPotter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HarryPotter
{
    public class Dumbledore : AllowedPerson
    {
        public List<Dorm> DormList { get; }
        public List<Letter> Letters { get; private set; }

        //public List<Student> Students { get; private set; }

        public List<string> Students { get; private set; }
        public Dumbledore(List<Dorm> dormList) :
             base("Albus", "Dumbledore", 1800,
            Enums.GenderType.MALE, "Christopher",
            "Admin", "1", Enums.RaceBlood.PURE_BLOOD,
            0, Enums.Pet.OWL, true, Enums.Role.TEACHER)
        {
            DormList = dormList;
            Letters = new List<Letter>();
        }

        public static void SendLetter(int student_id)
        {
            
            Console.WriteLine(@"Whom do you want to send letter to?
student id:");
            student_id = Convert.ToInt32(Console.ReadLine());



        }

        public void ReceivedLetters(Letter letter)
        {
            Letters.Add(letter);
        }

        public void AddStudents(List<string> Students)
        {
            Console.WriteLine("Student information:");
            string info = Console.ReadLine();
            Students.Add(info);

           
        }

    }

}
