using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение :");
            string n = Console.ReadLine();
            if (n.Length == 3)
                Console.WriteLine("Номер = " + n[0] + n[2]);
            else Console.WriteLine("Неправильное число!");
        }
    }
}
