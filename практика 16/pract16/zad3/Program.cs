using System;
using System.IO;


namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод текста из файла: \n------------------------------------  ");
            PrintTXT.Print();
            Console.WriteLine("==============================================================");
            var filePath = @"E:\Practice16.txt";
            var filePath1 = @"E:\Practice16Dop.txt";
            int count = File.ReadAllLines(filePath).Length;
            Console.WriteLine($"Количество строк: {count}");
            var numbers = SymbolCount.SymCount(filePath);
            int k = 1;
            foreach (var num in numbers)
            {
                Console.WriteLine($"Колличесвто символов в {k}-ой строке: { num.ToString()}");
                k++;
            }
            Console.WriteLine("Удаление последней строки зарисанно в новый файл ");
            DeletStringLast.DelStrL(filePath, filePath1);
            S1toS2.GetStringsS1ToS2(filePath, 1, 3);
            LongestString.GetLongestString(filePath);
            GetStringFirstLetter.GetLineWithFirstLetter(filePath, 'п');
            ReversOutput.PrintToFileReverseLinesInfile(filePath);

            Console.ReadLine();
        }
    }
}