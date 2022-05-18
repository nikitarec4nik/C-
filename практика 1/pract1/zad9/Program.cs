using System;

namespace zad9
{
    class Program
    {
        static double Func(double x)
        {
            return Math.Cos(x);
        }

        static void Main()
        {
            double a = Math.PI / 3;
            double b = 2*Math.PI/3;
            double h = (b - a) / 20d;
            for (double i = a; i <= b; i += h)
                Console.WriteLine("Func({0:0.000}) = {1:0.000}", i, Func(i));
        }
    }
}
