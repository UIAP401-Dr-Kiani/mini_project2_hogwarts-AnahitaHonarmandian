using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Panels
{
    public class FirstPanel
    {
        public void Panel1(int student_id) 
        {
            while (true)
            {

                Console.WriteLine(@"1.Dumbledore
2.Professor
3.Student");

                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Username:");
                    Console.ReadLine();
                    Console.WriteLine("Password:");
                    string s = Console.ReadLine();
                    if (s == "admin")
                    {
                        AdminPanel f=new AdminPanel();
                        f.AdminPanel1(student_id);
                    }

                }
                if (n == 2)
                {
                    
                    
                    ProfessorPanel m = new ProfessorPanel();
                    m.ProfessorPanel1();

                }
                if (n == 3)
                {
                   StudentPanel s=new StudentPanel();
                    s.StudentPanel1();

                }



            }


        }


        



       
    }
}
