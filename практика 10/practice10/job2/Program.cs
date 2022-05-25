using System;

namespace job2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(3, 2);
            B b = new B(3, a.c);
            Console.WriteLine($"a.c = {a.c}");
            Console.WriteLine($"b.c2 = {b.c2}");
        }
    }
}
