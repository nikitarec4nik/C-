using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Фамилию ИО: ");
            string newtext = "";
            string str1 = Console.ReadLine();
            string rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ";
            int sum = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                newtext += str1.ToLower()[i];
                for (int j = 0; i < rus.Length; j++)
                {
                    if (newtext[i] == rus[j])
                    {
                        sum += j + 1;
                        break;
                    }
                }
            }
            Console.WriteLine("Код:" + sum);
            int first = sum / 100;
            int second = (sum / 10) % 10;
            int third = sum % 10;
            int forth = sum % 10;
            int sum2 = first + second + third;
            if (sum2 > 10)
            {
                int first2 = sum2 / 10;
                int second2 = sum2 % 10;
                int sum3 = first2 + second2;
                Console.WriteLine("Код:" + sum3);
            }
            else
                Console.WriteLine("Код:" + sum2);
        }
    }
}
