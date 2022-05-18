using System;

namespace zad2
{
    internal class Program
    {


        static double F(double x)
        {
            if ((0 < x) && (x < 1))
            {
                return 3 * Math.Pow(x, 2);
            }
            else if ((-1 < x) && (x < 3))
            {
                return -2 / x;
            }
            else if (1 <= x)
            {
                return x / x - 1;
            }
            else
            {
                throw new IndexOutOfRangeException("OUT OF RANGE!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input X: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Function result:" + F(x));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
            catch (IndexOutOfRangeException dx)
            {
                Console.WriteLine(dx.Message);
            }
            Console.ReadLine();
        }
    }
}


