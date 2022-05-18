using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Record
    {
        public int id;
        public string Name;
        public string Surname;
        public DateTime Birthday;
        public string PhoneNumber;
        public static bool brake = false;

        public Record(int id, string Name, string Surname, DateTime Birthday, string PhoneNumber)
        {
            this.id = id;
            this.Name = Name;
            this.Surname = Surname;
            this.Birthday = Birthday;
            this.PhoneNumber = PhoneNumber;
        }
    }

    public class Notebook
    {
        private List<Record> notebookRecords;
        public List<Record> NotebookRecords
        {
            get { return notebookRecords; }
            set { notebookRecords = value; }
        }

        public Notebook()
        {
            notebookRecords = new List<Record>();
        }

        public List<Record> SearchRecords(string Name, string Surname, DateTime? Birthday, string PhoneNumber)
        {
            List<Record> ret = new List<Record>();
            foreach (Record rec in notebookRecords)
                if (rec.Name == Name || rec.Surname == Surname || rec.Birthday == Birthday || rec.PhoneNumber == PhoneNumber)
                    ret.Add(rec);
            return ret;
        }

        public void AddRecord(int id, string Name, string Surname, DateTime Birthday, string PhoneNumber)
        {
            id = Convert.ToInt32(Console.ReadLine());
            Name = Convert.ToString(Console.ReadLine());
            Birthday = Convert.ToDateTime(Console.ReadLine());
            PhoneNumber = Convert.ToString(Console.ReadLine());
            Record rec = new Record(id, Name, Surname, Birthday, PhoneNumber);
            notebookRecords.Add(rec);
            Console.WriteLine(Convert.ToString(id), Name, Surname, Birthday, PhoneNumber);
        }

        public void DeleteRecords(string Name, string Surname, DateTime Birthday, string PhoneNumber)
        {
            List<Record> records = SearchRecords(Name, Surname, Birthday, PhoneNumber);
            foreach (Record rec in records)
                notebookRecords.Remove(rec);
        }

        public void SortBySurname()
        {
            notebookRecords.OrderBy(x => x.Surname);
        }

        private void test()
        {
            SearchRecords(null, null, null, null); //вернёт все записи
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var needExit = false;
            while (!needExit)
            {
                char resp = ReadMenuSelection("Выберите: [Q]=Выход, [A]=генерация случайного числа", new char[] { 'Q', 'A' });
                switch (resp)
                {
                    case 'Q':
                        Console.WriteLine("Завершение программы");
                        needExit = true;
                        break;
                    case 'A':
                        Console.WriteLine("Генерация случайного числа:");
                        Console.WriteLine(new Random().Next(100));
                        break;
                    default:
                        Console.WriteLine("Не предусмотренный ответ.");
                        break;
                }
            }
        }

        private static char ReadMenuSelection(string Mesage, char[] ValidResponces)
        {
            while (true)
            {
                Console.WriteLine(Mesage);
                var key = Console.ReadKey();
                if (ValidResponces.Contains(key.KeyChar))
                {
                    Console.WriteLine();
                    return key.KeyChar;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод. Попробуйте исчо рас-рас.");
                }
            }
        }
    }
}