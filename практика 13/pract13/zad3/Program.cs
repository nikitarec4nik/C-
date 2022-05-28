using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое имя: ");
            string a = Console.ReadLine();
            Console.Write("Второе имя: ");
            string b = Console.ReadLine();
            info Men = new info(a);
            Console.Write("Неизменное имя: ");
            Console.WriteLine(Men.imya);
            Men.inform += vivod;
            Men.Put(b);
            Console.WriteLine($"Измененное имя: {Men.imya}");
            Men.inform -= vivod;
            Console.Read();
        }
        private static void vivod(string message)
        {
            Console.WriteLine(message);
        }
    }
}

