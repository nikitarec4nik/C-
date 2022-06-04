using System;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6;
            Console.WriteLine($"Введено число {x} ");

            Task task1 = Task.Run(() =>
            {
                double z1 = (Math.Pow(x, 10) + x * 2 - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / (Math.Pow(x, 2) - x * 2 - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
                global::System.Console.WriteLine(z1);
            });
            Task task2 = Task.Run(() =>
            {
                double z2 = Math.Sqrt((x + 3) / (x - 3));
                global::System.Console.WriteLine(z2);
            });
            task1.Wait();
            task2.Wait();
        }
    }
}