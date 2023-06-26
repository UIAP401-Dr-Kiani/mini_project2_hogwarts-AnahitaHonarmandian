using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Panels
{
    internal class AdminPanel
    {
        public void AdminPanel1()
        {
            while (true)
            {

                Console.WriteLine(@"1.Send invitation letter
2.Exit");

                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                
                    Dumbledore.SendLetter();
                    
                }
              
                else
                {
                    break;
                }

            }
        }
    }
}