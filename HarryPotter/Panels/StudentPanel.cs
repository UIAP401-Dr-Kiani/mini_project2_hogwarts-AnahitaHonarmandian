using HarryPotter.DataBase;
using HarryPotter.Subjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter.Panels
{
    public class StudentPanel
    {
        public void StudentPanel1()
        {

            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter 1 if you're not a wizard:");
            int raceBlood = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("ID:");
            int StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Semester:");
            int sem = Convert.ToInt32(Console.ReadLine());
            Student std1 = new Student(firstName, lastName, 0, GenderType.MALE, "", "",
            "", RaceBlood.PURE_BLOOD, 0, Pet.OWL, null, true, Role.STUDENT,
            0, sem, 0);


            if (raceBlood == 1)
            {
                Console.WriteLine("You are not able to go to Hogwarts stupid MUGGLE!!!");
            }
            if (raceBlood == 2)
            {


                if (sem == 1)
                {
                    Console.WriteLine(@"1.check mail box:");
                    Console.ReadLine();
                    Console.WriteLine("Enter your id again : ");
                    string username = Console.ReadLine();


                    foreach (var item in Tables.Students)
                    {
                        if (username.Equals(item.StudentID))
                        {
                            foreach (var j in item.ReceivedLetters)
                            {
                                Console.WriteLine(j.Context);
                            }

                        }
                    }

                    Console.WriteLine($"Dear {firstName} {lastName}; Welcome to Hogwarts.");
                    Console.WriteLine("Press any key to start your journey!!");
                    Console.ReadLine();
                    Random gen = new Random();
                    int range = 365 / 12;
                    DateTime moveDatetime = DateTime.Today.AddDays(gen.Next(range));
                    TrainTicket ticket = new TrainTicket("Home", "Hogwarts", moveDatetime);

                    Console.WriteLine($"Your train is going to leave on {moveDatetime}\n");
                    Student std = new Student(firstName, lastName, 0, GenderType.MALE, "", "",
            "", RaceBlood.PURE_BLOOD, 0, Pet.OWL, null, true, Role.STUDENT,
            0, sem, 0);
                    std1.GoToHogwarts(ticket);

                    Console.WriteLine("LATER ON...");
                    var list = new List<string> { "HUFFLEPUFF", "GRYFFINDOR", "RAVENCLAW", "SLYTHERIN" };
                    var random = new Random();
                    int group = random.Next(list.Count);

                    Console.WriteLine($"You belong to {list[group]}");
                    int num = random.Next(300);
                    Console.WriteLine($"Your room number is {num}");


                    if (sem == 2)
                    {
                        Console.WriteLine(@"1.Choose courses
2.See grades
3.Send letter to dumbledore");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (x == 1)
                        {
                            Student std2 = new Student(firstName, lastName, 0, GenderType.MALE, "", "",
                                             "", RaceBlood.PURE_BLOOD, 0, Pet.OWL, null, true, Role.STUDENT,
                                                 0, sem, 0);
                            std2.SelectCourses();
                        }
                        if (x == 2)
                        {
                            Student std3 = new Student(firstName, lastName, 0, GenderType.MALE, "", "",
                                                          "", RaceBlood.PURE_BLOOD, 0, Pet.OWL, null, true, Role.STUDENT,
                                                            0, sem, 0);
                            std3.SeeGrades();
                        }
                        if (x == 3)
                        {

                            Guid ID = Guid.NewGuid();
                            Console.WriteLine("Title:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Receiver:");
                            string receiver = Console.ReadLine();
                            Console.WriteLine("Context:");
                            string context = Console.ReadLine();
                            DateTime date = new DateTime();

                            Letter letter = new Letter(ID, title, receiver, context, date, false);
                            Student std4 = new Student(firstName, lastName, 0, GenderType.MALE, "", "",
                                                            "", RaceBlood.PURE_BLOOD, 0, Pet.OWL, null, true, Role.STUDENT,
                                                                 0, sem, 0); ;
                            std4.SendLetterToDumbledore(letter);
                        }
                    }
                }

            }
        


           
            


        }
        
    }
}
