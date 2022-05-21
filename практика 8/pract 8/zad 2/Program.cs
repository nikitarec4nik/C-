using System;
using System.Collections.Generic;

namespace zad_2
{
    class Program
    {
        //Перечиление работкников; числа - сколько часов должны отработать работники
        enum Employs
        {
            Manager = 150,
            Admin = 270,
            Director = 290
        };

        //Статический класс Accauntant
        static class Accauntant
        {
            //Метод для проверки даваьт ли работнику премию
            //emp - работник; workedHours - отработанные работником часы
            //возвращает true или false
            public static bool AskForBonus(Employs emp, int workedHours)
            {
                return (int)emp < workedHours;
            }
        }

        static void Main(string[] args)
        {
            //Словарь отработанных часов работниками
            //ключ - работник
            //value - сколько часов он отработал
            var empHours = new Dictionary<Employs, int>
            {
                [Employs.Manager] = 100,
                [Employs.Admin] = 310,
                [Employs.Director] = 90
            };

            //Перебираем словарь и выводим на экран выдавать примию или нет.
            foreach (var pair in empHours)
            {
                Console.WriteLine($"{ pair.Key }: { Accauntant.AskForBonus(pair.Key, pair.Value) }");
            }
        }
    }
}