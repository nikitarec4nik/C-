using System;

namespace zad7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($" { i } фт = { i * 0.453:N3} кг");
            }
        }
    }
}
