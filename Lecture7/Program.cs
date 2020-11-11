using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class Student
    {
        public string Name;
        private DateTime Birth;

        public int GetAge()
        {
            return DateTime.Now.Year - Birth.Year;
        }

        public void SetAge(int a)
        {
            int year = DateTime.Now.Year - a;
            Birth = new DateTime(year, 1, 1);
        }

        public int Age {
            get { return DateTime.Now.Year - Birth.Year; }
            set {
                int year = DateTime.Now.Year - value;
                Birth = new DateTime(year, 1, 1);
            }
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Student> stud_list = new List<Student>();
            stud_list.Add(new Student { Name = "John"});
            stud_list.Add(new Student { Name = "Mary" });
            stud_list.Add(new Student { Name = "Bob" });

            DirectoryInfo dir = new DirectoryInfo("New_Dir");


            //for (int i = 0; i <= 100; i++)
            //{
            //    File.Create(dir.Name + "/fff" + i.ToString() + ".txt");
            //    // New_Dir/fff0.txt
            //}

            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                files[i].Delete();

            }

            dir.Delete();

            Console.ReadKey();
        }
    }
}
