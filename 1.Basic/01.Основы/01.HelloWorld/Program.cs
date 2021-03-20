using System; // Подключаемые модули (пространства имен)

namespace MyProgram // Объявление нового пространства имен
{ // {} открывают и закрывают блоки кода
    class Program // Объявление класса
    { 
        static void Main() // Объявление метода Main, точка входа в программу.
        {
            Console.WriteLine("Hello World!"); // Пишем текст в консоль
            Console.Write("Введите имя: ");
            string name = Console.ReadLine(); // получаем консольный ввод и сохраняем в name
            Console.WriteLine($"Привет {name}");
        }
    }
}
