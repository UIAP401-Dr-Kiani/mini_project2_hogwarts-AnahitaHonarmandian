using HarryPotter.Panels;
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


            Human.GetFromFile();

            FirstPanel firstPanel = new FirstPanel();
            //int student_id = 0;
            firstPanel.Panel1();
        }
    }
}
