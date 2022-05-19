using System;

namespace zad1
{
    class Program
    {
        public static void Main() //Публичный статический метод Main без параметров и возвращаемого значения
        {

            Console.WriteLine("Введите число элементов массива a");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];

            for (int i = 0; i < size; ++i)
            {
                Console.Write("Введите {0} элемент массива: ", i + 1);
                a.SetValue(Convert.ToInt32(Console.ReadLine()), i);
                // Console.WriteLine(i);
            }
            foreach (int i in a)
                if (i % 2 != 0)
                    Console.WriteLine("Нечетный элемент:" + i);

            Console.ReadKey();

        }
    }
}
