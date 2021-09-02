using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProgram
{
    class TaskCancel
    {
        static void Func()
        {
            // Отмена задачи

            CancellationTokenSource cancelToken = new(); // Создаем объект
            CancellationToken token = cancelToken.Token; // Создаем токен

            Task task1 = new(() => MyMethod(5, token));
            task1.Start();
            cancelToken.Cancel(); // Прерываем задачу

            // Отмена Parallel

            try
            {
                Parallel.For(1, 10, new ParallelOptions { CancellationToken = token }, MyMethod2);
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine("Параллельная задача прервана");
            }
            finally
            {
                cancelToken.Dispose();
            }
            cancelToken.Cancel(); // Прерываем задачу

        }

        private static void MyMethod(int v, CancellationToken token)
        {
            // Какой то код
            Thread.Sleep(10000);

            // проверка токена на остановку задачи
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Задача прервана");
            }

            // Какой то код
        }

        private static void MyMethod2(int arg1)
        {
            // Какой то код
            Thread.Sleep(10000);
            // Какой то код
        }



    }
}
