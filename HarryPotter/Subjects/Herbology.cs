using System;
using System.Collections.Generic;
using System.Collections.Generic;

namespace HarryPotter
{
    public abstract class Herbology : Subject

    {
        public abstract List<Plants> PlantsList();
        public Herbology(string name, int capacity, uint semesterPresentation, uint minutesDuration, int professorID)
            : base(name, capacity, semesterPresentation, minutesDuration, professorID)
        {

        }

        public override string ToString()
        {
            var herbology_info = $"Name: {Name} Capacity: {Capacity} {SemesterPresentation} {Time.ToString("c")}\n";
            var plants = "Subject Plants:\n";
            foreach (var plant in PlantsList())
            {
                plants += (plant.ToString() + "\n");
            }
            return herbology_info + plants;
        }




    }
}
