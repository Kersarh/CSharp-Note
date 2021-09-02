using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProgram
{
    class TaskParallel
    {
        public static void Inv()
        {
            // Метод Parallel.Invoke в качестве параметра принимает массив объектов Action
            Parallel.Invoke(Print,
                () => Print2(5)
                );

            //Parallel.For позволяет выполнять итерации цикла параллельно
            Parallel.For(1, 10, Print2); // Вызовет Print2(1-10)

            // Parallel.ForEach осуществляет итерацию по коллекции подобно циклу foreach,
            // за исключением того что перебор осуществляется параллельно.
            List<int> list = new() { 1, 2, 3, 4, 10 };
            ParallelLoopResult par = Parallel.ForEach<int>(list,
            Print2);

            // Преждевременный выход из цикла
            ParallelLoopResult ParallelBreak = Parallel.For(1, 10, Print3);

            if (!ParallelBreak.IsCompleted) // проверяет завершился ли цикл полностью
            {
                Console.WriteLine($"Завершено на итерации {ParallelBreak.LowestBreakIteration}");
                // LowestBreakIteration индекс на котором произошло прерывание
            }

        }

        static void Print()
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
        }

        static void Print2(int x)
        {
            Console.WriteLine($"Итерация {x}");
        }

        static void Print3(int x, ParallelLoopState pls)
        {
            if (x == 3)
            {
                pls.Break(); // Преждевременное прерывание цикла
            }
            Console.WriteLine($"{Task.CurrentId}");
        }

    }
}
