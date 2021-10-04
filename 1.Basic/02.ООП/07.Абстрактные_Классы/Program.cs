using System;

namespace MyProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* Особенность абстрактных классов в том,что их можно
            * использовать только как родительский класс (не возможно создать экземпляр класса)
            * Для объявления используется ключевое слово abstract.
            *
            * Абстрактные классы могут быть полезны чтобы объединить реализацию схожих классов.
            * Например Вы пишите программы в которой работают как пользователи так и сотрудники фирмы.
            * Пусть страницы входа для пользователя и сотрудника различны.
            * Но у них есть и общие данные: логин, пароль и должны пройти авторизацию.
            * Чтобы не писать все это для каждого типа пользователей можно
            * вынести схожие черты абстрактный класс,
            * от которого будут наследоваться и пользователи и сотрудники.
            */

            Transport car = new Car(4, 100000, "Bob");
            Transport bus = new Bus(20, 20000, "Рога и копыта");
            // или
            Car car2 = new(4, 100000, "Bob");
            Bus bus2 = new(20, 20000, "Рога и копыта");

            car2.DisplayData();
            bus2.DisplayData();

            car2.PrintDriver();
            bus2.PrintOffiseOwner();

            /* Несмотря на очень упрощенную реализацию
            * часть общей логики мы вынесли в класс Transport
            * от которого наследуются Car и Bus.
            */
        }
    }

    internal abstract class Transport // включает в себя общую логику классов Car и Bus
    {
        public int Capacity { get; set; }
        public int Mileage { get; set; }

        public Transport(int cap, int mil)
        {
            Capacity = cap;
            Mileage = mil;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Вместимость {Capacity}, Пробег {Mileage}");
        }

        public abstract void AbstractMethod(); // Абстрактный метод должен быть определен в классах наследниках!
    }

    internal class Car : Transport
    {
        private string driver;

        public Car(int cap, int mil, string drw) : base(cap, mil)
        {
            // конструктор на основе абстрактного класса.
            driver = drw;
        }

        public override void AbstractMethod() // реализация абстрактного метода
        {
            Console.WriteLine($"Абстрактный метод Car");
        }

        public void PrintDriver() // Уникальный метод присущий только классу Car
        {
            Console.WriteLine($"Водитель {driver}");
        }
    }

    internal class Bus : Transport
    {
        private string officeOwner;

        public Bus(int cap, int mil, string own) : base(cap, mil)
        {
            officeOwner = own;
        }

        public override void AbstractMethod()
        {
            Console.WriteLine($"Абстрактный метод Bus");
        }

        public void PrintOffiseOwner() // Уникальный метод присущий только классу Bus
        {
            Console.WriteLine($"Фирма владелец {officeOwner}");
        }
    }
}