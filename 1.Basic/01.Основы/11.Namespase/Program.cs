// Чтобы задействовать классы из других пространств имен эти пространства подключаются
// с помощью директивы using
using System; // Console.WriteLine("...");

// Директива using static обозначает доступ к статическим членам которые можно получить,
// не указывая типа
using static System.Console; // WriteLine("...");

// Также возможно использование псевдонимов
// В программе вместо названия класса используется его псевдоним.
using print = System.Console; // print.WriteLine("...");

/*
* Все классы и структуры не существуют сами по себе,
* а заключаются в специальные контейнеры - пространства имен.
* Создаваемый по умолчанию класс Program уже находится в пространстве имен(namespace)
* которое обычно совпадает с названием проекта
*/

namespace MyProgram // пространство имен
{
    class Program
    {
        /* Полное название класса MyProgram.Program
        * Класс Program видит все классы
        * которые объявлены в том же пространстве имен
        * даже в других файлах
        */
        static void Main(string[] args)
        {
            // Без using System;
            System.Console.WriteLine("Hello World!");

            // При наличии using System;
            Console.WriteLine("Hello World!");

            // Использование через псевдоним
            // using print = System.Console;
            print.WriteLine("Hello World!");

            // При использовании
            // using static System.Console;
            WriteLine("Hello World!");


        }
    }
}
