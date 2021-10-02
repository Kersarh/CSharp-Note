using System;

namespace MyProgram
{
    // Агрегация – это когда экземпляр класса создается где-то в другом месте кода,
    // и передается в конструктор в качестве параметра.
    // При агрегации объекты Car и Engine будут равноправны.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Engine eng = new();
            Car car = new(eng);

            car.engine.PrintType();
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

        public Car(Engine eng)
        {
            engine = eng;
        }
    }
}