using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3
{
    class Program
    {// возвращает функцию х деленную на 10
        public static int F(int x)
        {
            return x % 10;
        }

        static void Main(string[] args)
        {
            // ввод числа и его конвертирование
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            // ввод числа б и его конвертирование
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            // сумма функции а и б
            int z = F(a) + F(b);
            // вывод результата на консоль
            Console.WriteLine("Результат работы функции:" + z);
            // задержка консоли
            Console.ReadKey();
        }
    }
}
