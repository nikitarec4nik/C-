using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("R=");
            var r = double.Parse(Console.ReadLine());
            Console.Write("H=");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine($"S={2 * Math.PI * r * (h + r)}");
        }
    }
}
