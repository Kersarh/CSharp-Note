using System;

namespace MyProgram
{
    // Паттерн Стратегия(Strategy) определяет набор алгоритмов, инкапсулирует их и обеспечивает их взаимозаменяемость.
    class Program
    {
        static void Main(string[] args)
        {
            Animal auto = new(new FlyMove());
            auto.MyMethod();
            auto.SetStrategy(new RaceMove());
            auto.MyMethod();
        }
    }

    // Интерфейс используется для реализации алгоритма стратегии
    interface IStrategy
    {
        void Move();
    }

    // Классы реализующие конкретные стратегии
    class FlyMove : IStrategy
    {
        public void Move()
        {
            Console.WriteLine("По воздуху");
        }
    }

    class RaceMove : IStrategy
    {
        public void Move()
        {
            Console.WriteLine("По земле");
        }
    }


    class Animal
    {
        // Хранит ссылку на один из объектов Стратегии.
        private IStrategy _mov;

        // Принимает стратегию через конструктор
        public Animal(IStrategy strategy)
        {
            _mov = strategy;
        }

        // Изменение стратегии во время выполнения
        public void SetStrategy(IStrategy strategy)
        {
            _mov = strategy;
        }

        // Метод через который реализуется стратегия
        public void MyMethod()
        {
            // Вызовет Move заданной стратегии
            _mov.Move();
        }
    }
}
