using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{

    class MyDictionary<Tkey, Tvalue> : IEnumerable<KeyValueClass<Tkey, Tvalue>>
    {
        public int Count { get { return myArray.Length; } }

        private KeyValueClass<Tkey, Tvalue>[] myArray = new KeyValueClass<Tkey, Tvalue>[0];


        public void Add(Tkey key, Tvalue value)
        {

            Array.Resize(ref myArray, myArray.Length + 1);

            myArray[myArray.Length - 1] = new KeyValueClass<Tkey, Tvalue>() { key = key, value = value };

        }

        public IEnumerator<KeyValueClass<Tkey, Tvalue>> GetEnumerator()
        {
            foreach (var item in myArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myArray.GetEnumerator();
        }

        public Tvalue this[Tkey index]
        {
            get
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i].key.Equals(index))
                    {
                        return myArray[i].value;
                    }

                }
                throw new DllNotFoundException("Не найдено!");
            }
        }
    }
}


