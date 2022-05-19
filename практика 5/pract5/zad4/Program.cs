using System;

namespace zad4
{
    internal class Program
    {

        static int N = 4;
        static int M = 10;

        static void Main()
        {
            int[,] matrix = new int[N, N];
            Random r = new Random();
            int mul = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = r.Next(1, M);
                    if (j == 1) mul *= matrix[i, j];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            if (mul / 100 >= 1 && mul / 100 < 10)
                Console.WriteLine($"Answer:{mul} Yes, is three-digit!");
            else Console.WriteLine($" Answer: {mul} - No, is't three-digit!!");
            Console.ReadKey();
        }
    }
}
