using System;

namespace MyProgram
{
    // Композиция определяет отношение классов при котором один полностью управляет жизненным циклом другого.

    //При этом класс автомобиля полностью управляет жизненным циклом объекта двигателя.При уничтожении объекта автомобиля в области памяти вместе с ним будет уничтожен и объект двигателя. И в этом плане объект автомобиля является главным, а объект двигателя - зависимой.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car = new();
            car.engine.PrintType();
            // После удаления из памяти класса Car класс Engine также будет удален.
        }
    }

    public class Engine
    {
        public void PrintType()
        {
            Console.WriteLine("Двигатель");
        }
    }

    public class Car
    {
        public Engine engine;

        public Car()
        {
            engine = new Engine();
        }
    }
}