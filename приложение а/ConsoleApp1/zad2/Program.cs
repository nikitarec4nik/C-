using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a four-digit number: ");
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = 0;
            while (FirstNumber > 0)
            {
                SecondNumber = SecondNumber + FirstNumber % 10;
                FirstNumber = FirstNumber / 10;
            }
            Console.WriteLine("Sum all numbers = " + SecondNumber);
            Console.ReadLine();

        }
    }
}

