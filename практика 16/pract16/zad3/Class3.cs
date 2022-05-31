using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class LongestString
    {
        public static string GetLongestString(string path)
        {
            return Convert.ToString(File.ReadAllLines(path)
                .Where(s => s.Length == File.ReadAllLines(path).Max(m => m.Length))
                .First());
        }
    }
}
