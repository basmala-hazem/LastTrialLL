using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    internal class File_mangement
    {
        private string path = "members.txt";


        public List<Members> LoadMembers()
        {
            List<Members> list = new List<Members>();

            if (!File.Exists(path))
                return list;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] p = line.Split(',');

                if (p.Length >= 6)
                {
                    Members m = new Members(
                        p[0],
                        int.Parse(p[1]),
                        int.Parse(p[2]),
                        int.Parse(p[3]),
                        p[4],

                        p[5],
                        p[6],
                        int.Parse(p[7]),
                        p[8],
                        p[9]
                        //0,
                        //0,
                        //"",
                        //"",
                       

                        //p[0],
                        //int.Parse(p[1]),
                        //(p[2]),
                        //p[3]
                    );

                    list.Add(m);
                }
            }

            return list;
        }


        public void SaveMembers(List<Members> members)
        {
            List<string> lines = new List<string>();

            foreach (var m in members)
            {
                string line =
                    m.Name + "," +
                    m.Age + "," +
                    m.Phone + "," +
                    m.Gender + "," +
                    m.Plan + "," +
                    m.Weight;

                lines.Add(line);
            }

            File.WriteAllLines(path, lines);
        }
        private string coachPath = "coach.txt";

        public List<Trainers> LoadCoaches()
        {
            List<Trainers> list = new List<Trainers>();

            if (!File.Exists(coachPath))
                return list;

            string[] lines = File.ReadAllLines(coachPath);

            foreach (string line in lines)
            {
                string[] p = line.Split(',');

                if (p.Length == 5)
                {
                    list.Add(new Trainers(
                        int.Parse(p[0]), // exp
                        (p[1]), // name
                        int.Parse(p[2]),            // age
                        (p[3]), // phone
                        (p[4]) // gender
                        
                    ));
                }
            }

            return list;
        }
    }
}
