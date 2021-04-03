using System;

namespace MyProgram
{
    class Program
    {
        delegate void MessageHandler(string message);

        static void Main(string[] args)
        {
            /* Анонимная функция — это "встроенный" оператор или выражение,
            *  которое может использоваться, когда тип делегата неизвестен.
            *  Ее можно использовать для инициализации именованного делегата
            *  или передать вместо типа именованного делегата в качестве параметра метода.
            */

            // Определение как функцию
            MessageHandler handler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };

            handler("hello world!");

            // Определение через лямбда функцию
            MessageHandler handler2 = (x) => { Console.WriteLine(x); };
            handler2("Привет Мир!!!");

        }
    }
}
