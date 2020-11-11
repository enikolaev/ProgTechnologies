using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    class Table : IDrawable
    {
        public void Draw()
        {
            ConsoleColor oldf = Console.ForegroundColor;
            ConsoleColor oldb = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(this);
            Console.ForegroundColor = oldf;
            Console.BackgroundColor = oldb;
        }

        public override string ToString()
        {
            string table =
                "**************************\n" +
                "*                        *\n" +
                "*                        *\n" +
                "*                        *\n" +
                "**************************\n\n";
            return table;
        }
    }
}
