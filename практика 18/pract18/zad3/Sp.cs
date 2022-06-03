using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class Sp : IEnumerable
    {
        private ArrayList list;
        public Sp()
        {
            list = new ArrayList();
        }
        public Sp(ArrayList a)
        {
            list = a;
        }
        public void Add(DataS m)
        {
            list.Add(m);
        }
        public Sp Clone()
        {
            return new Sp(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        { return list.GetEnumerator(); }


    }
}