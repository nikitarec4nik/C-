using System;

namespace zad1
{
    class Program
    {
        /// <summary>
        /// Вычисление функции
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        static int func(int arg)
        { return (arg / 10) % 10; }

        /// <summary>
        /// Метод Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 123456, b = 345678, c = 987694, result;
            result = func(a) + func(b) - func(c);
            Console.Write($" Сумма вторых справа цифр = { result } ");
            Console.ReadKey();
        }
    }
}


