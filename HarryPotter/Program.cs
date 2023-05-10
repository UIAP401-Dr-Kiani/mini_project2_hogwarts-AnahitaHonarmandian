using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("amiri", "zahrayi", 1999, Enums.GenderType.FEMALE, "ali", "ab", "cd1", Enums.RaceBlood.MUGGLE_BLOOD);
            human.WriteToFile();

            foreach (var item in human.GetFromFile())
            {
                Console.WriteLine(item.BirthYear);
            }
            Console.ReadLine();
        }
    }
}
