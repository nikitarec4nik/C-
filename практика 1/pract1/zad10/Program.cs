using System;
using System.Linq;

namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 100; i++)
            {
                if ((from x in i.ToString() select Math.Pow(Convert.ToInt32("" + x), 2)).Sum() % 13 == 0) Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}