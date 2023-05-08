using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Plants : Subjects
    {
       
        public string PlantName { get ; }    
        public int Count { get; private set; }

        public Plants(string name, int capacity, uint semesterPresentation, uint minutesDuration,string plantName, int count) :
            base(name, capacity, semesterPresentation, minutesDuration)
        {
            PlantName = plantName;
            Count = count;
        }

        public void IncreasePlant(int value)
        {
            Count += Math.Abs(value);
        }
        public void DecreasePlant()
        {
            if (Count > 0)
            {
                Count--;
            }
        }
    }
}
