using System;

namespace zad3
{
    class program
    {
        public static void Main()
        {
            int i, j;
            Console.WriteLine("Введите размер массива:");
            i = Convert.ToInt32(Console.ReadLine());
            j = i;
            int summa = 0, k = 0, num = 0;
            int[,] a = new int[i, j];
            int[] b = new int[j];
            Random rand = new Random();
            for (i = 0; i < 5; i++) //заполнение двумерного массива случайными числами
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            //вычисление сумму столбцов
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    summa += a[j, i];
                    if (a[j, i] > 0) num++; //подсчитывание количества положительных элементов столбцов
                    if (j == 4)
                    {
                        b[k] = summa; //внесение в новый массив суммы столбцов
                        Console.WriteLine("Количество положительных элементов в столбце= " + k + num);
                        summa = 0;  //обнуление сумму столбцов
                        num = 0; //обнуление количество положительных элементов в столбце
                    }
                }
        }
    }
}
