using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     public class Herbology : Subjects
    
    {
        public abstract List<Plants> PlantsList();
        public Herbology(string name, int capacity, uint semesterPresentation, uint minutesDuration) :
            base(name, capacity, semesterPresentation, minutesDuration)
        {

        }

        public override string ToString()
        {
            var herbology_info = $"Name: {Name} Capicity: {Capacity} {SemesterPresentation} {Time.ToString("c")}\n";
            var plants = "Subject Plantest:\n";
            foreach (var plant in PlantsList())
            {
                plants += (plant.ToString() + "\n");
            }
            return herbology_info + plants;
        }




    }
}
