using HarryPotter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace HarryPotter
{
    public class Dumbledore : AllowedPerson
    {
        public List<Dorm> DormList { get; }
        public List<Letter> Letters { get; private set; }
        public List<Student> Students { get; private set; }

        public Dumbledore(List<Dorm> dormList) :
             base("Albus", "Dumbledore", 1800,
            Enums.GenderType.MALE, "Christopher",
            "Admin", "1", Enums.RaceBlood.PURE_BLOOD,
            0, Enums.Pet.OWL, true, Enums.Role.TEACHER)
        {
            DormList = dormList;
            Letters = new List<Letter>();
        }

        public static void SendLetter()
        {

          
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();


            Console.WriteLine("Context: ");
            string context = Console.ReadLine();


            foreach (var item in Tables.Students)
            {
                Console.WriteLine(item.FirstName + " " + item.StudentID);
            }
            Console.WriteLine("Enter student id:");
            string StudentID = Console.ReadLine();


            var letter = new Letter(title, StudentID, context);
            Tables.Letters.Add(letter);

          
            Student student = null;
            foreach (var item in Tables.Students)
            {
                if (item.StudentID.Equals(StudentID))
                {

                    student = item;
                    break;
                }

            }

            //if (student != null)
            //{


                student.AddToLetters(letter);
                Random gen = new Random();
                int range = 365 / 12;
                DateTime moveDatetime = DateTime.Today.AddDays(gen.Next(range));
                TrainTicket trainTicket = new TrainTicket("Home", "Hogwarts", moveDatetime);

                Console.WriteLine("Letter was sent with their train ticket");



            //}
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
