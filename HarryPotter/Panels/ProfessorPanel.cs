using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Panels
{
    public class ProfessorPanel
    {
        public void ProfessorPanel1()
        {
            while (true)
            {
                Console.WriteLine(@"1.Insert class details
2.Confirm grades
3.Exit");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine(@"Subject:");
                    Console.ReadLine();
                    Console.WriteLine(@"Date and time:");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Done");



                }
                if (x == 2)
                {
                    Console.WriteLine(@"Enter Subject id:");
                    int subjectId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(@"Enter Student id:");
                    int studentId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your ID:");
                    int professorId = Convert.ToInt32(Console.ReadLine());

                    Graduation g = new Graduation(subjectId, studentId, professorId);
                    g.IsConfirmed();


                }
                else
                {
                    break;
                }
            }
        }
    }
}
