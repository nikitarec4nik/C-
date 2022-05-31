using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();

            myDict.Add("Polinchesta", "Director");
            myDict.Add("Rec4nik", "Model");
            myDict.Add("Inna", "Speaker");

            foreach (var item in myDict)
            {
                Console.Write("{0} | {1}\n", item.key, item.value);
            }

            Console.WriteLine("Количество пар: {0}", myDict.Count);

            Console.WriteLine("Выберите: ");
            var key = Console.ReadLine();
            Console.WriteLine("{0}", myDict[key]);
            Console.ReadLine();
        }
    }
}
