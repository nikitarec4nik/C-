using System;

namespace zad2
{
    class Program
    {

        public static int f(int x)
        {
            // возвращает результат операций
            return x * x - 5 * x;
        }

        static void Main(string[] args)
        {
            // ввод числа а и его конвертирование 
            Console.WriteLine("Введите число a");
            int A = Convert.ToInt32(Console.ReadLine());
            // ввод числа б и его конвертирование 
            Console.WriteLine("Введите число b");
            int B = Convert.ToInt32(Console.ReadLine());
            // ввод числа h и его конвертирование  
            Console.WriteLine("Введите число h");
            int h = Convert.ToInt32(Console.ReadLine());
            // число count равно 1
            int count = 1;
            // цикл,  где считается функция, после этого происходит операция (сложение, вычитание, умножение)
            for (int i = A; i <= B; i += h)
            {
                if (f(i) < 0)
                {
                    Console.WriteLine("РЕЗУЛЬТАТ ИТЕРАЦИИ №" + count + "=" + (A + B));
                }

                else if (f(i) >= 0 && f(i) < 10)
                {
                    Console.WriteLine("РЕЗУЛЬТАТ ИТЕРАЦИИ №" + count + "=" + (A - B));
                }

                else
                {
                    Console.WriteLine("РЕЗУЛЬТАТ ИТЕРАЦИИ №" + count + "=" + (A * B));
                }
                // увеличение на 1
                count += 1;
            }
            // задержка консоли
            Console.ReadLine();
        }
    }
}
