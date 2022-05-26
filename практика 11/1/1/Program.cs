using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coat closet = new Coat();
            Close close = new Close();
            Suit sofa = new Suit();
            Console.WriteLine("Выберите что сделать: ");
            Console.WriteLine("1. Одежда \n2.Пальто \n3.Костюм");
            int i = 0;
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    close.GetInfo();
                    break;
                case 2:
                    closet.GetInfo();
                    break;
                case 3:
                    sofa.GetInfo();
                    break;
            }
        }
    }
}
