using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class DeletStringLast
    {
        public static void DelStrL(string filePath, string filePath1)
        {
            string[] readText = File.ReadAllLines(filePath);
            string[] writeText = new string[readText.Length - 1];
            Array.Copy(readText, 0, writeText, 0, readText.Length - 1);
            File.WriteAllLines(filePath1, writeText);
        }
    }
}
