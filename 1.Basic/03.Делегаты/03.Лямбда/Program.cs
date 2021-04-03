using System;

namespace MyProgram
{
    class Program
    {
        delegate int Number(int x, int y);
        delegate void Hello(); // делегат без параметров
        static void Main(string[] args)
        {
            /*
             * Лямбда-выражения используются для создания анонимных функций.
             * Оператор объявления лямбда-выражения => отделяет список параметров лямбда-выражения
             * от исполняемого кода.
             * Лямбда-выражение может иметь одну из двух следующих форм:
             * (input-parameters) => expression
             * или
             * (input-parameters) => { <sequence-of-statements> }
             * 
             * Если лямбда-выражение не возвращает значение, оно может быть преобразовано в один из типов делегата Action; в противном случае его можно преобразовать в один из типов делегатов Func.
             */

            Number num = (x, y) => x + y;
            // (x, y) => x + y представляет лямбда-выражение
            // где x и y - это параметры, а x + y - выражение.
            Console.WriteLine(num(10, 20));

            // Используем делегат без параметров
            Hello hello1 = () => Console.WriteLine("Hello");
            hello1();

            // Тип  делегата Func
            Func<int, int, int> sum = (x, y) => x + y;
            Console.WriteLine(sum(5, 10));

            // Тип  делегата Action
            Action<string> print = name =>
            {
                string str = $"Hello {name}!";
                Console.WriteLine(str);
            };
            print("World");

        }

    }
}
