using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Letter
    {
        public Guid ID { get; }
        public string Title { get; }
        public string Receiver { get; }
        public string Context { get; }
        public DateTime WriteDateTime { get; }

        Letter( string title, string receiver, string context)
        {
            
            Title = title;
            Receiver = receiver;
            Context = context;
            WriteDateTime = DateTime.Now;
            ID= Guid.NewGuid();

        }

       Letter(Guid Id, string title, string receiver, string context, DateTime WriteDateTime) 
        { 
            Id=Id;
            Title=title;
            Receiver=receiver;
        }
    }
}
