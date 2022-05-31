using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class GetStringFirstLetter
    {
        public static string GetLineWithFirstLetter(string path, char firstChar)
        {
            return Convert.ToString(File.ReadAllLines(path)
                .Where(s => s[0] == firstChar));
        }
    }
}
