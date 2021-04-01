using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Наследование позволяет создать новый класс на основе уже существующего(родительского) сохранив при этом свойства и функциональность.
            */

            // Создадим экземпляр класса B наследующего от класса A
            B obj = new();
            // В классе и мы можем использовать поля и методы класса A
            obj.Method1();
            // Так и дополнять класс новыми методами
            obj.Method2();

        }
    }

    class A
    {
        public void Method1()
        {
            Console.WriteLine("Класс A, Метод 1");
        }
    }

    class B : A // класс B наследует свойства от A
    {
        public void Method2()
        {
            Console.WriteLine("Класс B, Метод 2");
        }
    }

}
