using System;

namespace zad2
{
    class Program
    {
        public delegate double Calc(double X);
        delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double ch = Convert.ToDouble(Console.ReadLine());
            Calc C = new Calc(Calculator.Get_Area);
            C += Calculator.Get_Sin2;
            C += Calculator.Get_Cos2;
            C(ch);
            Console.ReadLine();
            DoOperation(7, 2, Add);
        }
        static void DoOperation(int a, int b, Operation operation)
        {
            int res = a + b;
            Console.WriteLine(res);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
