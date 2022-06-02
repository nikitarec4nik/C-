using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2b;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            flowers[] material = new flowers[n];
            material[0] = new flowers.Roses(7, "Розовые", 11, "Турецкие");
            material[1] = new flowers.Tulips(5, "Жёлтые", 3, "Классические");
            material[2] = new flowers.Pionies(6, "Белые", 5, "Японские");
            foreach (flowers elem in material)
            {
                elem.Opisanie();
                elem.Sr();
            }
            Console.ReadLine();
        }
    }
}
