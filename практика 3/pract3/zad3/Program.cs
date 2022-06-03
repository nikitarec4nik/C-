using System;

namespace zad3
{
    /// <summary>
    /// создание Делегата
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    class Program
    {
        public static void f(double x, out double y)
        {// решение примера и ввод у 
            y = x * x - 5 * x;
            Console.WriteLine(y);
        }

        public static int f(int x)
        { // возвращает результат

            return x * 2 - 5 * x;
        }

        static void Main(string[] args)
        {// число z
            double z;

            f(5.3, out z);
            // вывод на консоль
            Console.WriteLine(f(10));
            // задержка консоли
            Console.ReadKey();
        }
    }
}
