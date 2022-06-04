using System;
using System.Threading.Tasks;
namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Task task1 = Task.Run(() =>
            {
                if (((n / 1000) > 0) || ((n < 99))) Console.WriteLine("Число не трехзначное");
                else
                {
                    int prod = 1;
                    while (n > 0)
                    {
                        int rem;
                        n = Math.DivRem(n, 10, out rem);
                        prod *= rem;
                    }
                    Console.WriteLine($"произведение чисел = {prod}");
                }
            });
            task1.Wait();
        }
    }
}
