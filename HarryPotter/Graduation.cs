using HarryPotter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Graduation
    {
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public int ProfessorID { get; set; }
        public float Score { get; set; }

        public Graduation(int subjectID, int studentID, int professorID)
        {
            SubjectID = subjectID;
            StudentID = studentID;
            ProfessorID = professorID;
            Score = 0;
        }

        public void SetScore(float score)
        {
            score = Math.Abs(score);
            if (score > 20)
                score = 8;

            Score = score;
        }

        public bool IsAccepted()
        {
            return Score > 0;
            Console.WriteLine("Done");
        }

        public override string ToString()
        {
            return $"Name:{Tables.Subjects.FirstOrDefault(s => s.ID == SubjectID).Name}-Score:{Score}";
        }
    }
}
