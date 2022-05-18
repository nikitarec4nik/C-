using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
 
            for (int i = b - 1; i > a; i--)
                Console.WriteLine(i);
            Console.WriteLine(b - a - 1);
 
            Console.ReadKey();
        }
    }
}