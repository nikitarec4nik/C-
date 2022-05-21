using System;
using System.Text.RegularExpressions;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Regex.IsMatch("кто-то как-то", @"\-")) ? "Содержит дефис" : "Данный текст не содержит дефис");



        }
    }
}
