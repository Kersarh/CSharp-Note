using System;

namespace MyProgram
{
    //Реализация основывается на определенном интерфейсе с последующей его реализации в классах.

    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal an = new();
            an.Move();
        }
    }

    public interface IMovable // Интерфейс который мы будем реализовывать в классах
    {
        void Move();
    }

    public class Animal : IMovable // Класс реализующий интерфейс
    {
        public void Move()
        {
            Console.WriteLine("Бег");
        }
    }
}