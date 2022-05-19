using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad5
{
    class Program
    {
        // Рекурсивный метод
        static int Factorial(int n)
        {
            int result;

            if (n == 1)
                return 1;
            result = Factorial(n - 1) / n;
            return result;
        }

        static void Main(string[] args)
        {
            label1:
            Console.WriteLine("Введите число: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}", n, Factorial(n));
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное число");
                goto label1;
            }

            Console.ReadLine();
        }
    }
}
