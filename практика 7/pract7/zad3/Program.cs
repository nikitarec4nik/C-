using System;
using System.Text.RegularExpressions;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Regex.IsMatch("Сегодня было очень красиво!", @"\d")) ? "Содержит" : "Данный текст не содержит числовые символы");



        }
    }
}
