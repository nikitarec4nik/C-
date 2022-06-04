using System;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Cos(int x)
        {
            Console.WriteLine(Math.Cos(x));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Parallel.For(-7, 3, Cos);
            Console.ReadLine();

        }
    }
}
