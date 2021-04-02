using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Полиморфизм - это возможность использования одного и того же имени
            * операции или метода к объектам разных классов.
            */

            MyClass obj = new();
            obj.Method();
            obj.Method2();
        }
    }

    class Base
    {
        // Данный метод может быть переопределен в дочерних классах
        public virtual void Method()
        {
            Console.WriteLine("Класс: Basе, Метод: Method");
        }

        public void Method2()
        {
            Console.WriteLine("Класс: Basе, Метод: Method2");
        }
    }

    class MyClass:Base
    {
        // Переопределяем метод базового класса 
        public override void Method()
        {
            Console.WriteLine("Переопределенный Method");

            // Возможно обратиться к методу базового класса
            base.Method();
        }

        // Сокрытие
        public new void Method2()
        {
            Console.WriteLine("Сокрытый Method2");
        }
    }

}
