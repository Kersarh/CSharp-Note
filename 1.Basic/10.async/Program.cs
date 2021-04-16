using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Асинхронный метод в определении использует модификатор async
            // Также содержит одно или несколько выражений await.
            // Когда в блоке кода встречается оператор await
            // выполнение асинхронного метода останавливается,
            // пока не завершится асинхронная задача.
            // Возможные возвращаемые типы:
            // void
            // Task
            // Task<T>
            // ValueTask<T>
            // Асинхронный метод не может использовать параметры типа out и ref

            AsyncMethod();   // вызов асинхронного метода

            // Возврат значений
            Console.WriteLine("------- MyMethodAsync ------");
            string s = await MyMethodAsync();
            Console.WriteLine($"Task<T> {s}");

            Console.WriteLine("------- MyMethodAsync2 ------");
            await MyMethodAsync2();

            Console.WriteLine("------- MyMethodAsync3 ------");
            await MyMethodAsync3();

            Console.WriteLine("------- MyMethodAsync4 ------");
            CancellationTokenSource ct = new();
            CancellationToken token = ct.Token;
            _ = MyMethodAsync4(token);
            Thread.Sleep(3000);
            ct.Cancel();
            
            Console.WriteLine("------- MyMethodAsync4 ------");
            // Асинхронный поток
            MyAsyncStream ast = new();
            await ast.MyMethod();



            Console.WriteLine("Завершение главного потока... press any key to exit...");
            Console.ReadKey(); // для ожидания завершения асинхронных методов
        }

        public static string MyMethod(int? n = null)
        {
            Console.WriteLine(n);
            Console.WriteLine("Начало MyMethod");
            Thread.Sleep(3000); // Эмитируем какую то работу...
            Console.WriteLine("Конец MyMethod");
            return "Возврат строки из MyMethod";
        }
        static async void AsyncMethod()
        {
            Console.WriteLine("Начало AsyncMthod"); // Выполняется синхронно
            // AsyncMethod ждет завершение задачи в то время как
            // Выполнение кода возвращается в вызвавший метод
            string str = await Task.Run(() => MyMethod());
            Console.WriteLine(str);
            Console.WriteLine("Конец AsyncMthod");
        }

        static async Task<string> MyMethodAsync()
        {
            return await Task.Run(() => MyMethod());
        }

        public static async Task MyMethodAsync2()
        {
            // Будут выполняться последовательно!
            await Task.Run(() => MyMethod(1));
            await Task.Run(() => MyMethod(2));
            await Task.Run(() => MyMethod(3));
        }

        public static async Task MyMethodAsync3()
        {
            // будут выполнены параллельно
            Task t1 = Task.Run(() => MyMethod(4));
            Task t2 = Task.Run(() => MyMethod(5));
            Task t3 = Task.Run(() => MyMethod(6));
            await Task.WhenAll(new[] { t1, t2, t3 });
        }

        public static async Task MyMethodAsync4(CancellationToken token)
        {
            while (true)
            {
                Console.WriteLine("Начало прерываемого метода");
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана");
                    return;
                }
                await Task.Run(() => MyMethod());
            }

        }

    }
}
