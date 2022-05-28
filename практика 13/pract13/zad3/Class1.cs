using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class info
    {
        public delegate void muinfo(string message);
        public event muinfo inform;
        public info(string imya)
        {
            this.imya = imya;
        }
        public string imya { get; private set; }
        public void Put(string ima)
        {
            imya = ima;
            inform?.Invoke($"Поменять имя на: {ima}");
        }
    }
}
