using System;

namespace zad7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine($" { i } фт = { i * 0.453:N3} кг");
                i++;
            }
            while (i <= 100);
        }
    }
}
