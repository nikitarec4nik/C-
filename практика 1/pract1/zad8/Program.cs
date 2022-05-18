using System;

namespace zad8
{
    class Program
    {
        static int Sqr(int val)
        {
            int result = 0;
            for (int i = 1; i <= 2 * val - 1; i = i + 2)
                result += i;
            return result;
        }
        static void Main(string[] args)
        {
            int val = 9;
            for (int i = 1; i <= val; i++)
                Console.WriteLine(i + ": " + Sqr(i));
            Console.ReadKey(true);
        }
    }
}