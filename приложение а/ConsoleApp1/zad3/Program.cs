using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const double X = 3.5;
                const double E = 2.71;
                double Y = Math.Pow(Math.Cos(X), 2) - ((Math.Sqrt(Math.Pow(X, 3)) + 1) / (Math.Sin(X)) + Math.Pow(E, Math.Log10(2 * X)));
                Console.Write("Answer: " + Y);
                Console.ReadLine();
            }

        }
    }
}
