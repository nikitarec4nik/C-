using System;
using System.Text.RegularExpressions;

namespace zad2
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Regex.IsMatch("Группа BLACKPINK !", @"\w+(\w)\1\w+")) ? "Содержит" : "Данный текст не содержит две подряд идущие одинаковые буквы");



        }
    }
}
