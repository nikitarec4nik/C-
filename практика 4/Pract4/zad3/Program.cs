using System;

namespace zad3
{
    internal class Program
    {


        public static double PowerA3(double a, out double b)
        {
            b = Math.Pow(a, 3);
            return b;
        }
        static void Main(string[] args)
        {
            try
            {
                int length = 4;
                for (int i = 0; i <= length; i++)
                {
                    Console.Write("Input number: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double temp;
                    var b = PowerA3(a, out temp);
                    Console.WriteLine("Number {0} to the power of 3= {1}", a, b);
                }
                Console.WriteLine("Program completed, press enter to exit.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
}