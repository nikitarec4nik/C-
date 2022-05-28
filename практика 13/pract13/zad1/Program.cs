using System;

namespace zad1
{
    class Program
    {
        public delegate double Calc(double X);
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double ch = Convert.ToDouble(Console.ReadLine());
            Calc C = new Calc(Calculator.Get_Area);
            C += Calculator.Get_Sin2;
            C += Calculator.Get_Cos2;
            C(ch);
            Console.ReadLine();
        }
    }
}