using System;

namespace pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите число килограмм: ");
            int cm, a, b;
            cm = Convert.ToInt32(Console.ReadLine());
            b = (cm - (cm % 1000)) / 1000;
            a = cm % 100;
            Console.WriteLine($"Результат: {b} тонны, {a} килограмм");
            Console.ReadKey();
        }
    }
}
