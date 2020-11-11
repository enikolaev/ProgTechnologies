using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lecture6
{
    public static class IntExtension { 
        public static int Cube(this int self)
        {
            return self * self * self;
        }

        public static void Save(this int self, string fname)
        {
            using (StreamWriter ss = new StreamWriter(fname))
            {
                ss.WriteLine(self);
            }
        }
    }

    static class PersontExtension
    {
        public static void Save(this Person self, string fname)
        {
            using (StreamWriter ss = new StreamWriter(fname))
            {
                ss.WriteLine(self);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pers = new Person("Nikolaev E.I.", "34083540320423", new DateTime(
                1988, 12, 25));
            var stud = new Student("Nikolaev E.I.", "34083540320423", DateTime.Now,
                "INS-19-1", 2);
            var stud1 = new Student("NNNNNNNN I. R.", 
                "24244", 
                new DateTime(1988, 12,  23),
                "INS-19-1", 
                2);
            var stud2 = new Student("Potapin E.I.", "340832423442", DateTime.Now,
                "INS-19-1", 2);
            var teach = new Teacher("Nikolaev E.I.", "34083540320423", DateTime.Now,
                "IST", 15);
            var teach1 = new Teacher("ttttttttt E.I.", "5656565", DateTime.Now,
                "IBAS", 10);

            Person[] all = { pers, stud, stud1, stud2, teach, teach1, pers };

/*            foreach (var human in all)
            {
                WriteLine(human.ToString());
            }*/

            IDrawable te = new Teacher(
                "ttttttttt E.I.", 
                "5656565", 
                DateTime.Now,
                "IBAS", 
                10);

            Table t1 = new Table(), t2 = new Table();

            IDrawable[] ToDraw = { teach, stud2, t2, teach1, stud, te, t1 };

            /*            foreach (var item in ToDraw)
                        {
                            item.Draw();
                        }*/

            System.Int32 x = 5, y = 111111111;

            x.Cube().Save("x.txt");
            y.Save("y.txt");
            pers.Save("pers.txt");

            WriteLine("OK");

            ReadKey();

        }
    }
}
