using System;
using job1.Interfaces;

namespace job1
{
    partial class Program
    {   
            static void Main(string[] args)
            {
                Console.Write("Введите число W: ");
                int w = Convert.ToInt32(Console.ReadLine());
                Test x0 = new Test();
                Test x1 = new Test(5);
                x0.IxF0(10);
                x1.IxF1();
                x0.F0(5);
                x1.F1();
                (x0 as Iy).F0(7);
                (x1 as Iz).F1();
                Console.WriteLine("==========Prism test==========");
                Console.WriteLine("==========Ix==========");
                Ix ix = (Ix)x1;
                ix.IxF0(w);
                ix.IxF1();
                Console.WriteLine("==========Iy==========");
                Iy iy = (Iy)x1;
                iy.F0(w);
                iy.F1();

                Console.WriteLine("==========Iz==========");
                Iz iz = (Iz)x1;
                iz.F0(w);
                iz.F1();
                Console.ReadKey();
            }
        }
    }



    
