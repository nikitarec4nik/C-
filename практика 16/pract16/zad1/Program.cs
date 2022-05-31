using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.CreateDirectory("D:\\Folder16");
            var file = new FileInfo($"{directory.FullName}\\File1.txt");
            if (!file.Exists)
            {
                file.Create();
            }
            FillFile(filePath: file.FullName);

            int count = default(int);
            using (StreamReader reader = new StreamReader(file.FullName, Encoding.UTF8))
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    count++;
                }
            }
            try
            {
                var numbers = ReadFile(filePath: file.FullName);
                var minNumber = numbers.Min();
                Console.WriteLine("Минимальное число в файле: " + minNumber);
                var countPositiveNumbers = numbers.Count(number => number > 0);
                Console.WriteLine("Количество положительных чисел в файле: " + countPositiveNumbers);
            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        private static void FillFile(string filePath, int minValue = -5, int maxValue = 6, int countNumbers = 10)
        {
            var random = new Random();
            using (var writer = new StreamWriter(filePath, append: false, encoding: Encoding.UTF8))
            {
                while (countNumbers > 0)
                {
                    writer.WriteLine(random.Next(minValue, maxValue));
                    countNumbers--;
                }
            }
        }

        private static IEnumerable<int> ReadFile(string filePath)
        {
            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var input = String.Empty;
                while ((input = reader.ReadLine()) != null)
                {
                    yield return int.Parse(input);
                }
            }
        }
    }

}
