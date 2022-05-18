using System;

namespace zad3
{
    class Point
    {
        public float x, y;
        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
    }
    class Triangle
    {
        public Point a { set; get; }
        public Point b { set; get; }
        public Point c { set; get; }

        public Triangle(Point _a, Point _b, Point _c)   //конструктор
        {
            a = _a;
            b = _b;
            c = _c;
        }
        public void sd_right(float d)   //сдвиг вправо
        {
            a.x = +d; b.x = +d; c.x = +d;
        }
        public void sd_left(float d)    //сдвиг влево
        {
            a.x = -d; b.x = -d; c.x = -d;
        }
        public void sd_up(float d)  //сдвиг верх
        {
            a.y = +d; b.y = +d; c.y = +d;
        }
        public void sd_down(float d)    //сдвиг вниз
        {
            a.y = -d; b.y = -d; c.y = -d;
        }
        public float R(Point _a, Point _b)
        {
            return Convert.ToSingle(Math.Sqrt(Math.Pow(_a.x - _b.x, 2) + Math.Pow(_a.y - _b.y, 2)));
        }
        public void sd_alfa(float d)    //поворот на угол d
        {
            Point M = new Point((a.x + b.x + c.x) / 3, (a.y + b.y + c.y) / 3);
            a.x = M.x + Convert.ToSingle(R(M, a) * Math.Cos(d));
            a.y = M.y - Convert.ToSingle(R(M, a) * Math.Sin(d));
            b.x = M.x + Convert.ToSingle(R(M, b) * Math.Cos(d));
            b.y = M.y - Convert.ToSingle(R(M, b) * Math.Sin(d));
            c.x = M.x + Convert.ToSingle(R(M, c) * Math.Cos(d));
            c.y = M.y - Convert.ToSingle(R(M, c) * Math.Sin(d));
        }
        public void sd_rad(float r) //увелечение на r
        {
            float d = 0;
            Point M = new Point((a.x + b.x + c.x) / 3, (a.y + b.y + c.y) / 3);
            a.x = Convert.ToSingle((R(M, a) + r) * Math.Cos(d));
            a.y = -Convert.ToSingle((R(M, a) + r) * Math.Sin(d));
            b.x = Convert.ToSingle((R(M, b) + r) * Math.Cos(d));
            b.y = -Convert.ToSingle((R(M, b) + r) * Math.Sin(d));
            c.x = Convert.ToSingle((R(M, c) + r) * Math.Cos(d));
            c.y = -Convert.ToSingle((R(M, c) + r) * Math.Sin(d));
        }

        public void show()  //вывод координат
        {
            Console.WriteLine("a(x,y)={0},{1}\nb(x,y)={2},{3}\nc(x,y)={4},{5}", a.x, a.y, b.x, b.y, c.x, c.y);
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(3, 3);
            Point c = new Point(3, 1);
            Triangle T = new Triangle(a, b, c);
            T.show();
        }
    }
}