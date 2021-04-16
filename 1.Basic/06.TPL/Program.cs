using System;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task
            * AsyncState: состояния задачи
            * CurrentId: возвращает идентификатор задачи
            * Exception: возвращает исключение при выполнении задачи
            * Status: статус задачи
            */

            // Для запуска задач можно использовать различные способы
            Task task1 = new(() => Console.WriteLine("Task 1"));
            task1.Start();

            // Второй способ в качестве параметра принимает делегат Action, который указывает, какое
            // действие будет выполняться. При этом этот метод сразу же запускает задачу:
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task 2"));

            // Третий способ
            Task task3 = Task.Run(() => Console.WriteLine("Task 3"));

            // ждем завершения задач
            task1.Wait();
            task2.Wait();
            task3.Wait();

            // Задачи продолжения
            Task taskNext = task3.ContinueWith((Task t) =>
            {
                Console.WriteLine($"Выполняется после task3");
            });

            // Запуск массива задач
            Task[] tasks1 = new Task[3]
            {
                new Task(() => Console.WriteLine("1")),
                new Task(() => Console.WriteLine("2")),
                new Task(() => Console.WriteLine("3"))
            };

            foreach (Task t in tasks1)
                t.Start();

            // ждем завершения задач
            Task.WaitAll(tasks1);







        }
    }
}
