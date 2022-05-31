using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zad3
{
    internal class PrintTXT
    {
        public static void Print()
        {
            try
            {
                using (StreamReader sr = new StreamReader("E:\\Practice16.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение: " + e.Message);
            }
        }
    }
}