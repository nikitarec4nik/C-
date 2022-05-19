using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]) == false)
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
