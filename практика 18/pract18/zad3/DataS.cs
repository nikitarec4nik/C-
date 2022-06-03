using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class DataS : Sport
    {
        string ds;
        public DataS(string s, string g, string ds) : base(s, g)
        {
            this.ds = ds;
        }
        public override void PrintSport()
        {
            Console.WriteLine("В " + g + " состоится игра по " + s + ": дата проведения " + ds);
        }
    }
}
