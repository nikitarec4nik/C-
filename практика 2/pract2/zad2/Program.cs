using System;
using System.Collections.Generic;

namespace zad2
{
    internal class Program
    {
        public class Student : zav_kafedry
        {
            string surname;
            string name;
            int number_record_book;

            public Student() : base()
            {
                this.number_record_book = 0;
                this.name = String.Empty;
                this.surname = string.Empty;
                Input();
            }
            void Input()
            {
                Console.WriteLine("Введите имя: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите номер зачётки: ");
                number_record_book = Convert.ToInt32(Console.ReadLine());
            }
            public override string Vivod()
            {
                return base.Vivod() + "\n" +
                    " Номер зачётки - " + number_record_book + "\n" +
                    " Имя - " + name + " ";
            }
        }
        static void Main(string[] args)
        {
            zav_kafedry zav = new Student();
            zav.Vvod();
            Console.WriteLine(zav.Vivod());
        }
    }
    public class Prepod : zav_kafedry
    {
        string faculty;
        public Prepod() : base()
        {
            this.faculty = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название факультета ");
            faculty = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название факультета - " + faculty + " ";
        }

    }
    public class Person : zav_kafedry
    {
        string name;
        string surname;
        int age;

        public Person() : base()
        {
            this.name = String.Empty;
            this.surname = string.Empty;
            this.age = int.Parse(Console.ReadLine());
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите имя персоны: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите фамилию персоны: ");
            surname = Console.ReadLine();

            Console.WriteLine("Введите возраст персоны: ");
            int age = int.Parse(Console.ReadLine());
        }
        public override string Vivod()
        {
            return base.Vivod() + " Имя перосны - " + name + " ";
        }
    }
    public class zav_kafedry
    {
        int number_kafedry;
        string name_kafedry;
        public zav_kafedry()
        {
            this.name_kafedry = String.Empty;
            this.number_kafedry = 0;
            //Vvod();
        }
        public void Vvod()
        {
            Console.WriteLine("Введите название кафедры: ");
            name_kafedry = Console.ReadLine();
            Console.WriteLine("Введите номер кафедры: ");
            number_kafedry = int.Parse(Console.ReadLine());

        }
        public virtual string Vivod()
        {
            return "Название кафедры - " + name_kafedry + "\n" +
                "Номер кафедры - " + number_kafedry + "\n";
        }
    }
}
