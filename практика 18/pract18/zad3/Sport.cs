using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class Sport
    {
        public string s;
        public string g;
        public Sport(string s, string g)
        {
            this.s = s;
            this.g = g;
        }
        virtual public void PrintSport()
        {
            Console.WriteLine("В " + g + " состоится игра по " + s);
        }
    }
}
