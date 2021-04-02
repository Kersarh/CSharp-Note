using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Свойство — предоставляет механизм для чтения, записи или вычисления
             * значения частного поля.
             * Свойства представляют собой специальные методы, называемые методами доступа.
             * Это позволяет легко получать доступ к данным и помогает повысить безопасность и гибкость методов.
             * Свойства позволяют создать дополнительную логику при работе с полями класса.
             * Например при проверка корректности присваиваемого значения переменной класса.
             */

            MyClass obj1 = new();

            obj1.Age = 5; // не принято
            obj1.Age = 120; // не принято
            obj1.Age = 30; // принято

            MyClass2 obj2 = new();
            Console.WriteLine($"UserName: {obj2.UserName}"); // Пустое значение так как не задано

        }
    }

    public class MyClass
    {
        private int age; // Невозможно использовать за пределами класса
        private int newint;

        // Свойство класса через которое можно работать с переменной age вне текущего класса
        public int Age
        {
            // get Позволяет получить значение приватного поля
            get { return age; } // Свойства также могут иметь модификатор доступа

            // set позволяет задать значение приватного поля
            // В данном случае мы проверяем корректность данных поля age
            set
            {
                if (value < 20)
                {
                    Console.WriteLine("Только для 20+");
                }
                else if (value > 100)
                {
                    Console.WriteLine("Вам правда больше 100 лет?");
                }
                else
                {
                    Console.WriteLine("Значение принято!");
                    age = value;
                }
            }
        }
        public int NewInt
        {
            get => newint; // Более кратка запись кода выше
            set => newint = value; // просто устанавливаем значение без проверок
        }
    }

    public class MyClass2
    {
        // Автоматические свойства
        // Создаются компилятором их преимущество в том что
        // в любой момент мы можем развернуть автоматическое свойство в обычное
        // Саму переменную компилятор подставит сам
        public string Name { get; set; } = "user";
        public int Age { get; set; } = 23;

        private string username;

        // эквивалентно public string UserName { get { return name; } }
        // Задат
        public string UserName => username;

        private string data;
        public string MyData { get { return data; }}
    }



}
