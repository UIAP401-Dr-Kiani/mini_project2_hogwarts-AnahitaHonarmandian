using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHandler
{
    public static class FileWorker
    {

        public static List<List<string>> Read(string filename)
        {
            var lines = new List<List<string>>();
            try
            {
                using (var sr = new StreamReader(filename))
                {
                    var line = sr.ReadLine();

                    while (line != null)
                    {
                        lines.Add(line.Split('|').ToList());
                        line = sr.ReadLine();
                    }
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return lines;

        }

        public static void Write(string filename, string txt)
        {
            try
            {
                using (var w = File.AppendText(filename))
                {
                    w.WriteLine(txt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
