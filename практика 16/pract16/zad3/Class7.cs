using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class SymbolCount
    {
        public static List<int> SymCount(string filePath)
        {
            var countsCharInLines = new List<int>();
            using (var reader = new StreamReader(filePath, detectEncodingFromByteOrderMarks: true))
            {
                var line = String.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    var count = line.Length;
                    countsCharInLines.Add(count + 1);
                }
            }
            return countsCharInLines;
        }
    }
}
