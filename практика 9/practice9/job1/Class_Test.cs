using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using job1.Interfaces;

namespace job1
{
        class Test : Ix, Iy, Iz, Iw
        {
            public int xVal;

            public Test()
            {
                xVal = this.xVal;
            }
            public Test(int key)
            {
                xVal = key;
            }

            public void F0(int xKey)
            {
                var y = Math.Pow(xKey, 3);
                Console.WriteLine(y);
            }

            public void F1()
            {
                Console.WriteLine("Общий метод F1.");
            }

            void Iz.F0(int xKey)
            {
                var a = 7 * (xKey) - 2;
                Console.WriteLine(a);
            }
            void Iz.F1()
            {
                Console.WriteLine("Mетод F1 из интерфейса Iz.");
            }

            public void IxF0(int key)
            {
                xVal = key - 5; Console.WriteLine("IxF0({0})...", xVal);
            }
            public void IxF1()
            {
                xVal = xVal;
                Console.WriteLine("IxF1({0})...", xVal);
            }
        }

    }

