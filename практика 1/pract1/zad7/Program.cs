using System;

namespace zad7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine($" { i } фт = { i * 0.453:N3} кг");
                i++;
            }
        }
    }
}
