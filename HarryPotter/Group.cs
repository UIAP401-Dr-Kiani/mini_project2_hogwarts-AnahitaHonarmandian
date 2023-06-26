using System.Collections.Generic;
using static HarryPotter.Enums;
using WorkHandler;
using HarryPotter.FileHandler;

namespace HarryPotter
{
    public class Group : IFileWorker
    {
        public List<Student> Students { get; }
        public List<Professor> Professors { get; }
        public List<Student> QuidditchPlayers { get; }

        public int ID { get; }
        public int Score { get; }
        public Types Type { get; }

        public static string FileName { get => "Group.txt"; }

        public Group(int id, int score, Types type)
        {
            Students = new List<Student>();
            Professors = new List<Professor>();
            QuidditchPlayers = new List<Student>();
            ID = id;
            Score = score;
            Type = type;
        }


        bool isEqual(Group group)
        {
            return group.Score == this.Score && group.Type == this.Type;
        }
        bool IsDuplicate()
        {
            foreach (var group in FileReader.GetGroups())
            {
                if (isEqual(group))
                    return true;
            }

            return false;
        }
        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write(FileName, ConvertToStringFile());
        }

        public string ConvertToStringFile()
        {
            return $"{Score}|{Type}";
        }
    }
}
