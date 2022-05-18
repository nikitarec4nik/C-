using System;

namespace pract2
{
    class A
    {
        public int a;
        public int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double Work()
        {
            return b * a;
        }
        public double Root()
        {
            return Math.Sqrt(b) / 2 * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            A c = new A(a, b);
            Console.WriteLine("Произведение = " + c.Work());
            Console.WriteLine("Результат вычисления значения= " + c.Root());
            Console.ReadLine();
        }
    }
}
