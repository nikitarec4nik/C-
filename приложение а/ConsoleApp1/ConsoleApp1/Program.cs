using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Vvedite 3 4isla");
            Console.Write("a= ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToInt16(Console.ReadLine());
            {
                sum = a + b + c;
            }
            Console.WriteLine("{0}+{1}+{2}", a, b, c);
            Console.WriteLine("Resultat vy4esleniya :{0}", sum);
            Console.ReadLine();
        }
    }
}
