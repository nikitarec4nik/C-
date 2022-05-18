using System;

namespace Pract4
{
    internal class Program
    {
            static double Y1(double x)
            {
                return (Math.Pow(x, 3) - 2 / x + 10) + 4 * x;
            }
            static double Y2(double x)
            {
                return Math.Log(x, Math.E) + Math.Cos(x) / x + 6;
        }
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Input х1: ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Function result Y1:" + Y1(x1));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                try
                {
                    Console.Write("Input х2: ");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    if (Double.IsNaN(Y2(x2)))
                    {
                        Console.WriteLine("Not a number.");
                    }
                    else
                    {
                        Console.WriteLine("Function result Y2:" + Y2(x2));
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                Console.ReadLine();
            }
        }
    }
    
