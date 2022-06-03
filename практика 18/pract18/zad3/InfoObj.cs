using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class InfoObj
    {
        public static void Info<tip>(tip obj)
            where tip : Sport
        {
            obj.PrintSport();
        }

    }
}
