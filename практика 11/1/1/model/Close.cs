using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Close
    {
        public string name;
        public Close()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Console.Write("Введите название одежды: ");
            name = Console.ReadLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Название: {0}", name);
        }
    }
}