using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Letter : IFileWorker<Letter>
    {
        public Guid ID { get; }
        public string Title { get; }
        public string Receiver { get; }
        public string Context { get; }
        public DateTime WriteDateTime { get; }
        public string FileName { get => "Letter.txt"; }

        Letter( string title, string receiver, string context)
        {
            
            Title = title;
            Receiver = receiver;
            Context = context;
            WriteDateTime = DateTime.Now;
            ID= Guid.NewGuid();

        }

       Letter(Guid Id, string title, string receiver, string context, DateTime writeDateTime) 
        { 
            ID=Id;
            Title=title;
            Receiver=receiver;
            Context=context;
            WriteDateTime = writeDateTime;
        }

        public List<Letter> GetFromFile()
        {
            var letter = new List<Letter>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> letter_info in list_temp)
            {
                var id = letter_info[0];
                string title = letter_info[1];
                string receiver = letter_info[2];
                string context = letter_info[3];
                var writeDateTime = letter_info[4];
                

                letter.Add(new Letter(id, title, receiver, context, writeDateTime));
            }
            return letter;
        }
        bool isEqual(Letter letter)
        {
            return letter.ID == this.ID && letter.Title == this.Title && letter.Receiver == this.Receiver;
        }
        bool IsDuplicate()
        {
            foreach (var letter in GetFromFile())
            {
                if (isEqual(letter))
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
            return $"{ID}|{Title}|{Receiver}|{Context}|{WriteDateTime}";
        }


    }
}
