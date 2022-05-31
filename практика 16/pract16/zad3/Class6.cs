using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class ReversOutput
    {
        public static void PrintToFileReverseLinesInfile(string path)
        {
            string pathoutput = @"E:\Practice16Reverse.txt";
            File.WriteAllLines(pathoutput, File.ReadAllLines(path).Reverse());
        }
    }
}
