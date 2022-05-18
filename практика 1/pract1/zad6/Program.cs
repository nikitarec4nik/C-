using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            if (int.TryParse(Console.ReadLine(), out var n))
            {
                Console.WriteLine(GetCategory(n));
            }
            else Console.WriteLine("Вы ошиблись");
            Console.ReadKey();

            string GetCategory(int age)
            {
                if (age < 1) return "Младенец";
                if (1 <= age && age <= 11) return "Ребёнок";
                if (12 <= age && age <= 15) return "Подросток";
                if (16 <= age && age <= 25) return "Юноша";
                if (26 <= age && age <= 70) return "Мужчина";
                return "Пожилой человек";
            }
        }
    }
}
