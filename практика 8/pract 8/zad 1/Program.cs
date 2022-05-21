using System;
using System.Collections.Generic;

namespace zad_1
{
    class Program
    {
        //Структура Train
        private struct Train
        {
            public int Id { get; init; }
            public string Destination { get; init; }
            public DateTime Date { get; init; }

            public Train(int id, string destination, DateTime date)
            {
                Id = id;
                Destination = destination;
                Date = date;
            }
        }

        //Кол-во train-ов в массиве
        private const int TrainsCount = 8;

        static void Main(string[] args)
        {
            //Создание массива train-ов
            Train[] trains = new Train[TrainsCount];
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i] = InputTrain();
            }

            //Сортировка train-ов по их индексам
            Array.Sort(trains, (a, b) => a.Id.CompareTo(b.Id));

            //Поиск поезда по id
            try
            {
                Console.Write("Введите id чтобы найти поезд: ");
                var id = int.Parse(Console.ReadLine());
                var train = GetTrainById(id, trains);

                OutputTrain(train);
            }
            catch (KeyNotFoundException exception)
            {
                //Если не удалось найти train - выводим на экран сообщение ошибки
                Console.WriteLine(exception.Message);
            }
        }

        private static void OutputTrain(Train train)
        {
            Console.WriteLine(
                $"Id: { train.Id };" +
                $" Destination: { train.Destination }; " +
                $"Date: { train.Date.Date }");
        }

        private static Train GetTrainById(int id, Train[] trains)
        {
            foreach (var train in trains)
            {
                if (train.Id == id)
                    return train;
            }

            //Если не удалось найти train по id - выбрасываем ошибку с сообщением не удалось найти
            throw new KeyNotFoundException("Поезд не найден");
        }

        private static Train InputTrain()
        {
            Console.Write("Введите id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Введите место назначения: ");
            var destination = Console.ReadLine();

            Console.Write("Введите время отправления: ");
            var date = DateTime.Parse(Console.ReadLine());

            return new Train(id, destination, date);
        }
    }
}