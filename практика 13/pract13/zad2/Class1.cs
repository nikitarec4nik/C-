using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class Calculator
    {
        public static double Get_Area(double x)
        {
            double Tan2;
            Tan2 = Math.Pow(Math.Tan(x), 2);
            Console.WriteLine($"Tan2 = { Math.Round(Tan2, 3) }");
            return Tan2;
        }
        public static double Get_Sin2(double x)
        {
            double Sin2;
            Sin2 = Math.Pow(Math.Sin(x), 2);
            Console.WriteLine($"Sin2 = { Math.Round(Sin2, 3) }");
            return Sin2;
        }
        public static double Get_Cos2(double x)
        {
            double Cos2;
            Cos2 = Math.Pow(Math.Cos(x), 2);
            Console.WriteLine($"Cos2 = { Math.Round(Cos2, 3) }");
            return Cos2;
        }
    }
}
