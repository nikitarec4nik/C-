using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = File.CreateText("input.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine(Console.ReadLine());
                }
            }

            using (StreamReader sr = File.OpenText("input.txt"))
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < System.IO.File.ReadAllLines("input.txt").Length; i++)
                {
                    int count = 0;
                    string s = sr.ReadLine();
                    char[] chars = s.ToCharArray();
                    foreach (char ch in chars)
                    {
                        if ((ch == '.') || (ch == '!') || (ch == '?')) { }
                        else
                        { count++; }
                    }
                    sw.WriteLine(s + " " + count);
                }
            }

        }
    }
}