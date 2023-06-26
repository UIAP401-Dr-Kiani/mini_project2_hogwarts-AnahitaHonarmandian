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
     public class Plants 
    {

        public string PlantName { get; }
        public int Count { get; private set; }
        public string FileName { get => "Plants.txt"; }

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

        public List<Plants> GetFromFile()
        {
            var plants = new List<Plants>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> plant_info in list_temp)
            {
                string plantName = plant_info[0];
                int count = int.Parse(plant_info[2]);

                plants.Add(new Plants(plantName, count));
            }
            return plants;
        }
        bool IsEqual(Plants plants)
        {
            return plants.PlantName == this.PlantName && plants.Count == this.Count;
        }
        bool IsDuplicate()
        {
            foreach (var plants in GetFromFile())
            {
                if (IsEqual(plants))
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
            return $"{PlantName}|{Count}";
        }


    }
}
