using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Coat : Close
    {
        public double м;
        public string material;
        public double consumption;
        public Coat()
        {
            this.м = 0;
            this.material = null;
            this.consumption = 0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите размер пальто:");
            м = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите материал:");
            material = Console.ReadLine();
        }
        public virtual void CostCloset()
        {
            consumption = м / 6.5 + 0.5;
        }
        public override void GetInfo()
        {
            CostCloset();
            Console.WriteLine("Размер польто: {0} \nМатериал: {1} \nЦена: {2}", м, material, consumption);
        }
    }
}
