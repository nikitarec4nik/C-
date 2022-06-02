using System;

namespace _2b
{
    public abstract class flowers
    {
        public abstract void Opisanie();
        public abstract void Sr();
        public class Roses : flowers
        {
            public Roses(int cost, string color, int col, string type)
            {
                this.Cost = cost;
                this.color = color;
                this.col = col;
                this.type = type;
            }
            public int Cost;
            public string color;
            public int col;
            public string type;

            public override void Opisanie()
            {
                System.Console.WriteLine("Розы {0} Цвет: {1} Количество: {2} Цена: {3}", type, color, col, Cost);
            }
            public override void Sr()
            {
                if (col == 0) System.Console.WriteLine("Розы отсутствуют");
                if (Cost == 0) System.Console.WriteLine("Розы дорогие");
                else System.Console.WriteLine("Розы дешевые");
            }
        }
        public class Tulips : flowers
        {
            public Tulips(int cost, string color, int col, string type)
            {
                this.Cost = cost;
                this.color = color;
                this.col = col;
                this.type = type;
            }
            public int Cost;
            public string color;
            public int col;
            public string type;

            public override void Opisanie()
            {
                System.Console.WriteLine("Колокольчики {0} Цвет: {1} Количество: {2} Цена: {3}", type, color, col, Cost);
            }
            public override void Sr()
            {
                if (col == 0) System.Console.WriteLine("Колокольчики отсутствует");
                if (Cost == 0) System.Console.WriteLine("Колокольчики дорогая");
                else System.Console.WriteLine("Колокольчики дешевая");
            }
        }
        public class Pionies : flowers
        {
            public Pionies(int cost, string color, int col, string type)
            {
                this.Cost = cost;
                this.color = color;
                this.col = col;
                this.type = type;
            }
            public int Cost;
            public string color;
            public int col;
            public string type;

            public override void Opisanie()
            {
                System.Console.WriteLine("Пионы {0} Цвет: {1} Количество: {2} Цена: {3}", type, color, col, Cost);
            }
            public override void Sr()
            {
                if (col == 0) System.Console.WriteLine("Пионы отсутствуют");
                if (Cost == 0) System.Console.WriteLine("Пионы дорогие");
                else System.Console.WriteLine("Пионы дешевые");
            }
        }
    }
}
