using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Group :IFileWorker<Group>
    {
      
        public List<Student> Students { get; }
        public List<Professor> Professors { get; }
        public List<Student> QuidditchPlayers { get; }
        public int Score{ get ;  }
        public Types Type { get ; }

        public string FileName { get => "Group.txt"; }

       public Group(int score,Types type)
        {
            Students = new List<Student>();
            Professors = new List<Professor>(); 
            QuidditchPlayers = new List<Student>();
            Score = score;
            Type = type;
        }

        public List<Group> GetFromFile()
        {
            var group = new List<Group>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> group_info in list_temp)
            {

                
                int score = int.Parse(group_info[0]);
                Enum.TryParse(group_info[1], out Types type);
               

                group.Add(new Group(type, score));
            }
            return group;
        }
        bool isEqual(Group group)
        {
            return group.Score == this.Score && group.Type == this.Type;
        }
        bool IsDuplicate()
        {
            foreach (var group in GetFromFile())
            {
                if (isEqual(group))
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
            return $"{Score}|{Type}";
        }
    }
}
