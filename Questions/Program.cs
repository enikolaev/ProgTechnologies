using System;

namespace Questions
{
    class Program
    {

        static void Main(string[] args)
        {
            double Z, x, y;
            Console.Write("Inter x > ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inter y > ");
            y = Convert.ToDouble(Console.ReadLine());
            int n = 0;
            Console.Write("Number of add > ");
            n = Convert.ToInt32(Console.ReadLine());


            Z = 0;
            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                { // Нечетное
                    Z += i * (i + 2) / Math.Pow(Math.Cos(x), i + 1);
                } else
                { // Четное
                    Z -= i * (i + 2) / Math.Pow(Math.Sin(y), i + 1);
                }
                //Console.WriteLine($"i = {i}, Z = {Z}");
            }


            Console.WriteLine($"Final Z = {Z:0.00}");
            Console.ReadKey();
        }
    }
}