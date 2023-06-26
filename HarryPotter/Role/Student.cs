
using HarryPotter.DataBase;
using HarryPotter.Subjects;
using System;
using System.Collections.Generic;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Student : AllowedPerson
    {
        //private string id;

        public string StudentID { get; set; }
        public int PassedUnitCourses { get; private set; }
        public int Semester { get; private set; }
        public Group Group { get; private set; }
        public int DormNumber { get; private set; }

        public List<Letter> ReceivedLetters = new List<Letter>();
        public bool InHogwarts { get; private set; }

        public void GoToHogwarts(TrainTicket ticket)
        {
            if (ticket.MoveDatetime < DateTime.Now)
                Console.WriteLine("the train has been left the station.");

            ticket.MoveDatetime = DateTime.Now;
        }
        public void LogInToHogwarts()
        {
            InHogwarts = true;
            Semester++;
        }

        public void SendLetterToDumbledore(Letter letter)
        {
            if (InHogwarts)
            {
                Tables.Letters.Add(letter);
            }
        }
        public void LogOutOfHogwarts()
        {
            InHogwarts = false;
        }

        public void AddToLetters(Letter letter)
        {
            ReceivedLetters.Add(letter);
        }

        public void SelectCourses()
        {
            Console.WriteLine(@"Available Courses are:
1.Magic History => Professor Snape
2.Chemistry => Professor Sybil
3.Herbology => Professor Sybil
4.Physical Education => Professor Burbage");
            Console.ReadLine();
            Console.WriteLine("Courses were added to your schedule");

        }

        public void SeeGrades()
        {
            var random = new Random();
            int num = random.Next(20);
            int num1= random.Next(20);
            int num2 = random.Next(20);
            int num3 = random.Next(20);
            Console.WriteLine($@"Magic History=>{num}
Chemistry=>{num1}
Herbology=>{num2}
Physical Education=>{num3}");
        }
        public Student(
            string firstName, string lastName, int birthyear, GenderType gender, string father, string username,
            string password, RaceBlood race, int roomNumber, Pet pet, Group group, bool hasBaggage, Role role,
            int passedCourses, int semester, int dormNumber) :

            base(firstName, lastName, birthyear, gender, father,
                username, password, race, roomNumber, pet, hasBaggage, role)
        {
            InHogwarts = false;
            Group = group;
            PassedUnitCourses = passedCourses;
            Semester = semester;
            DormNumber = dormNumber;
        }


        public Student(
    string firstName, string lastName, int birthyear, GenderType gender, string father, string username,
    string password, RaceBlood race, int roomNumber, Pet pet, Role role,
    int passedCourses, int semester, int dormNumber, string s_id) :

    base(firstName, lastName, birthyear, gender, father,
        username, password, race, roomNumber, pet, false, role)
        {

            PassedUnitCourses = passedCourses;
            Semester = semester;
            DormNumber = dormNumber;
            this.StudentID = s_id;

        }

       

        
    }



}
