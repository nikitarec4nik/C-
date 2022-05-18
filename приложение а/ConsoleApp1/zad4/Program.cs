using System;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружность");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга,ограниченного этой окружностью равна : {0}", (d * d) / (4 * Math.PI));
            Console.ReadKey();
        }
    }
}
    