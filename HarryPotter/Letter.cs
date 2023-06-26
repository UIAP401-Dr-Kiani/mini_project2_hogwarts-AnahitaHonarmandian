using HarryPotter.FileHandler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkHandler;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Letter
    {
        public Guid ID { get; }
        public string Title { get; }
        public string Receiver { get; }
        public string Context { get; }
        public DateTime WriteDateTime { get; }
        public bool IsRead { get; private set; }

       
        public Letter(string title, string receiver, string context) : this(Guid.NewGuid(), title, receiver, context, DateTime.Now, false)
        {

        }

        
        public static void GetFromInput()
        {
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Receiver: ");
            string receiver = Console.ReadLine();

            Console.WriteLine("Context: ");
            string context = Console.ReadLine();

            var letter = new Letter(title, receiver, context);
            DataBase.Tables.Letters.Add(letter);
        }

        public Letter(Guid Id, string title, string receiver, string context, DateTime writeDateTime, bool isRead)
        {
            ID = Id;
            Title = title;
            Receiver = receiver;
            Context = context;
            WriteDateTime = writeDateTime;
            IsRead = isRead;
        }

        bool isEqual(Letter letter)
        {
            return letter.ID == this.ID && letter.Title == this.Title && letter.Receiver == this.Receiver;
        }

        bool IsDuplicate()
        {
            foreach (var letter in FileReader.GetLetters())
            {
                if (isEqual(letter))
                    return true;
            }

            return false;
        }
        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write("Letter.txt", ReadyToWrite());
        }

        public string ReadyToWrite()
        {
            return $"{ID}|{Title}|{Receiver}|{Context}|{WriteDateTime}";
        }


    }
}
