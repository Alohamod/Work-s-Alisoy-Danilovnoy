using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class drun
    {
        private string _name;
        private double _time_Friend;
        private int[] _marks_norm_ti_friends;

        public string Name => _name;
        public double Time_Friend => _time_Friend;
        public int[] Marks_norm_ti_friends => _marks_norm_ti_friends;

        public drun(string name, double time)
        {
            _name = name;
            _time_Friend = time;
            _marks_norm_ti_friends = new int[0];
        }
        public void AddMarks(int mark)
        {
            Array.Resize(ref _marks_norm_ti_friends, _marks_norm_ti_friends.Length + 1);
            _marks_norm_ti_friends[_marks_norm_ti_friends.Length-1] = mark;
        }


    }

    public class drunDTO
    {
        //свойство с публич сетером
        public string Name { get; set; }
        public string drunType { get; set; }
        public double Time_Friend { get; set; }
        public int[] Marks_norm_ti_friends { get; set; }
        // конструктор без параметеров
        public drunDTO()
        {

        }
/*        public drunDTO(string name, double time)
        {
            Name = name;
            Time_Friend = time;
        }*/
        public drunDTO(drun rux)
        {
            drunType = rux.GetType().Name;
            Name = rux.Name;
            Time_Friend = rux.Time_Friend;
            Marks_norm_ti_friends = rux.Marks_norm_ti_friends;
        }
        // Game => GAmeDTO
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            drun drun1 = new drun("Руслан", 1);
            drun1.AddMarks(2);
            drun1.AddMarks(2);
            drun1.AddMarks(2);
            drun1.AddMarks(2);
            drun1.AddMarks(1);
            drun1.AddMarks(3);
            drunDTO drunDTO1 = new drunDTO(drun1);
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullPath = Path.Combine(folderPath, "druni.xml");

            var serializer = new XmlSerializer(typeof(drunDTO));


            using (var writer = new StreamWriter(fullPath))
            {

                serializer.Serialize(writer, drunDTO1);

            }

            drunDTO drunDTO2;
            using (var reader = new StreamReader(fullPath))
            {
                drunDTO2 = (drunDTO)serializer.Deserialize(reader);

            }
            drun drun2 = new drun(drunDTO2.Name, drunDTO2.Time_Friend);
            Console.WriteLine(string.Join(" ", drun1.Marks_norm_ti_friends));
            foreach ( var i in drunDTO2.Marks_norm_ti_friends)
            {
                drun2.AddMarks(i);
            }
            Console.WriteLine(string.Join(" ", drun2.Marks_norm_ti_friends));

            if (CompareDruns(drun1, drun2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("No");
            }




        }
        public static bool CompareDruns(drun d1, drun d2)
        {
            if (d1.Name != d2.Name) return false;
            if (d1.Time_Friend != d2.Time_Friend) return false;
            //if (d1.Marks_norm_ti_friends != d2.Marks_norm_ti_friends) return false;

            return true;
        }
    }
    
}
