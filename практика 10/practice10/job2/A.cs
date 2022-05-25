using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job2
{
    public class A
    {
        private decimal a;
        private decimal b;

        public decimal c { get; set; }

        public A()
        {
        }

        public A(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
            this.c = a - b;
        }
    }
}

