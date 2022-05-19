using System;
using System.Linq;

namespace zad2
{
    internal class Program
    {
        public static int[] Massiv(int a, int b)
        {
            int x = 100;
            int[] mas = new int[x];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(a, b);
            }
            return mas;
        }
        public static void PrintMas(int[] mas)
        {
            foreach (var item in mas)
            {
                Console.Write(" " + item);
            }
        }
        public static void PrintArrayReverse(int[] mas, int countInLine = 6)
        {
            var reversMas = mas.Reverse().ToArray();

            for (int i = 0; i < reversMas.Length; i++)
            {
                if (i % countInLine == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{reversMas[i]} ");
            }

        }
        public static void Sort(int[] mas)
        {
            Array.Sort(mas);
            Array.Reverse(mas);
            foreach (var item in mas)
            {
                Console.Write(" " + item);
            }
        }
        public static int Binary(int[] mas, int k)
        {
            Array.Sort(mas);
            var sortmas = Array.BinarySearch(mas, k);
            return sortmas;
        }
        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the initial boundary of the array: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the final boundary of the array: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter K: ");
            var k = Convert.ToInt32(Console.ReadLine());
            var mas = Massiv(a, b);
            PrintArray(mas);
            Console.WriteLine();
            Console.Write("Array on the contrary: ");
            PrintArrayReverse(mas, 6);
            Console.WriteLine();
            var itemIndex = Binary(mas, k);
            Console.WriteLine(itemIndex);
            Console.ReadLine();
        }
    }
}
