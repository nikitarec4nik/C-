using System;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            Task task1 = Task.Run(() =>
            {
                if (((n / 1000) > 0) || ((n < 99))) Console.WriteLine("Число не трехзначное");
                else
                {
                    result = (n % 100) * 10 + n / 100;
                }
            });
            Task task2 = task1.ContinueWith(task1 =>
            {
                Console.WriteLine("Получено трехзначное число: {0}", result);
            });
            task1.Wait();
        }
    }
}
