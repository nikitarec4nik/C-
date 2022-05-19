using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст-");
            string text = Console.ReadLine();
            Console.WriteLine(String.Join("*", text.Split('а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я')));
            Console.ReadKey();
        }
    }
}

