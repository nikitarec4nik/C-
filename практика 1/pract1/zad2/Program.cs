using System;

namespace zad2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (double.TryParse(Console.ReadLine(), out var x) && double.TryParse(Console.ReadLine(), out var y))
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("x и y в первой четверти");
                else if (x < 0 && y < 0)
                    Console.WriteLine("x и y в третьей четверти");
                else
                    Console.WriteLine("x и y где-то в другом месте");
            }
        }
    }
}
