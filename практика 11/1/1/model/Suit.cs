using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Suit : Close
    {
        public double h;
        public string material;
        public string corner;
        public double cost;
        public Suit()
        {
            this.h = 0;
            this.material = null;
            this.corner = null;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Введите рост: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите материал: ");
            material = Console.ReadLine();

        }
        public virtual void CostSofa()
        {
            cost = 2 * h + 0.3;
        }
        public override void GetInfo()
        {
            CostSofa();
            Console.WriteLine("Рост: {0} \nМатериал: {1} \nСтоимость: {2}", h, material, cost);
        }
    }
}