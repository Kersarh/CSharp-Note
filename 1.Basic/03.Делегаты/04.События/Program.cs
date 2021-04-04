using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* События позволяют классу или объекту уведомлять
             * другие классы или объекты о возникновении каких-либо ситуаций.
             * Класс создающий событие называется издателем,
             * класс принимающий событие подписчиком.
             * 
             * События объявляются с помощью ключевого слова event,
             * после которого указывается тип делегата, который представляет событие
             */

            MyClass obj = new();
            obj.Notify += DisplayMessage; // Добавляем обработчик для события Notify
            obj.Notify += DisplayColorMessage; // и еще один

            obj.Add(50);    // + 50

            obj.Notify -= DisplayMessage;     // удаляем ненужный обработчик

            obj.Sub(40);   // Вычитаем 40

            obj.Sub(200);  // Отнимаем больше чем число

            obj.Notify -= DisplayColorMessage;     // удаляем ненужный обработчик

            // Установка в качестве обработчика анонимного метода
            obj.Notify += delegate (string mes)
            {
                Console.WriteLine($"Анонимный обработчик: {mes}");
            };
            obj.Add(100);
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine($"DisplayMessage: {message}");
        }
        private static void DisplayColorMessage(String message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"DisplayRedMessage: {message}");
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }

    }


    class MyClass
    {
        public delegate void Handler(string message); // делегат для события
        public event Handler Notify; // событие
        public int num;

        public MyClass()
        {
            num = 100;
        }


        public void Add(int n)
        {
            num += n;
            if (Notify != null) Notify($"Сумма увеличилась!: {num}"); // Вызов события
            //Notify?.Invoke($"На счет поступило: {num}");
        }

        public void Sub(int n)
        {
            if (num >= n) // Не позволяем вычесть боше чем число
            {
                num -= n;
                Notify?.Invoke($"Осталось: {n}"); // Вызов события
            }
            else
            {
                // Если вычитаем больше чем число
                Notify?.Invoke($"Есть {num}, в вычитается {n}"); ;
            }
        }
    }


}
