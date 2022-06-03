using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sp SpList = new Sp();
            Dictionary<string, string> city = new Dictionary<string, string>(2);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите вид спорта");
                string s = null;
                s = Console.ReadLine();
                Console.WriteLine("Введите город");
                string g = Console.ReadLine();
                Console.WriteLine("Введите дату проведения");
                string ds = Console.ReadLine();
                SpList.Add(new DataS(s, g, ds));
                var key = $"{i + 1}";
                city[key] = g;
            }
            Console.WriteLine("=======================");
            foreach (KeyValuePair<string, string> keyValue in city)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine("=======================");
            foreach (DataS x in SpList)
                x.PrintSport();
            SpList.RemoveAt(1);
            Console.WriteLine("=======================");
            Sp c1 = (Sp)SpList.Clone();
            foreach (DataS x in c1)
                x.PrintSport();
            Console.ReadLine();
        }
    }
}
