using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class TaskReturn
    {
        public static void ReturnData()
        {
            // Использую ранее реализованный метод
            Task<int> task1 = new(() => MyMethod(5));
            task1.Start();
            Console.WriteLine($"{task1.Result}");

            // Реализация логики при объявлении задачи
            Task<string> task2 = new(() =>
            {
                return "Data";
            });
            task2.Start();

            string str = task2.Result;  // ожидаем получение результата
            Console.WriteLine($"{str}");

            task1.Wait();
            task2.Wait();

        }

        static int MyMethod(int x) => x + 1;

    }

}
