using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    class Person
    {
        public Person(string pFio, string pSnils, DateTime dd)
        {
            fio = pFio; snils = pSnils; birth = dd;
        }

        public override string ToString()
        {
            return "This is person \n" +
                $"FIO: {fio}, SNILS: {snils}, date of birth {birth.ToString()}\n";
        }

        protected string fio;
        protected string snils;
        protected DateTime birth;
    }

    class Admin : Person
    {
        private float salary;
        public Admin(string fio, string snils, DateTime dd, float s) 
            : base(fio, snils, dd)
        {
            this.salary = s;
        }

        public override string ToString()
        {
            return "********************************* \n" + 
                "Admin \n" +
                $"FIO: {fio}, SNILS: {snils}, date of birth {birth.ToString()}\n"
                + $"Salary: {salary} \n" +
                "********************************* \n\n";
        }
    }

    class Teacher : Person, IDrawable, IPrintable
    {
        public override string ToString()
        {
            return "This is teacher \n" +
                            $"FIO: {fio}, SNILS: {snils}, date of birth {birth.ToString()}\n"
                            + $"Kafedra: {kafedra}, Stazh: {stazh} \n\n";
        }

        public void Draw()
        {
            ConsoleColor oldf = Console.ForegroundColor;
            ConsoleColor oldb = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(this);
            Console.ForegroundColor = oldf;
            Console.BackgroundColor = oldb;
        }

        public void Print()
        {
            ///////
        }

        public void Scan()
        {
            /////
        }

        public Teacher(string pFio, string pSnils, DateTime dd,
            string pKaf, int pStazh) : base(pFio, pSnils, dd)
        {
            this.kafedra = pKaf;
            this.stazh = pStazh;
        }
        // описывает преподавателя
        string kafedra;
        int stazh;
    }

    class Student : Person, IDrawable
    {

        public override string ToString()
        {
            return "This is student \n" +
                $"FIO: {fio}, SNILS: {snils}, date of birth {birth.ToString()}\n"
                + $"Group: {group}, Kurs: {kurs} \n\n";
        }

        public void Draw()
        {
            ConsoleColor oldf = Console.ForegroundColor;
            ConsoleColor oldb = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(this);
            Console.ForegroundColor = oldf;
            Console.BackgroundColor = oldb;
        }

        public Student(string pFio, string pSnils, DateTime dd,
    string pgroup, int pkurs) : base(pFio, pSnils, dd)
        {
            this.group = pgroup;
            this.kurs = pkurs;
        }

        // описывает студента
        string group;
        int kurs;
    }
}
