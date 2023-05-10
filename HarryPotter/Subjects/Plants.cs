using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     public class Plants 
    {

        public string PlantName { get; }
        public int Count { get; private set; }

        public Plants(string plantName, int count)
          
        {
            PlantName = plantName;
            IncreasePlant(count);
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

        public override string ToString()
        {
            return $"Name:{PlantName} - #{Count}";
        }
    }
}
