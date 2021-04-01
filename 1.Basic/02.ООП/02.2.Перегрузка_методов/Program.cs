using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Перегрузка методов
             * Допускается совместное использование одного и того же имени 
             * двумя или более методами одного и того же класса.
             * При этом их параметры должны быть различны. 
             */

            // Вызовем перегруженный метод sum с различными параметрами
            Sum(); // Not Data
            Sum(1); // 2
            Sum(3, 7); // 10 

        }

        static void Sum()
        {
            Console.WriteLine("Not Data");
        }

        static void Sum(int x)
        {
            Console.WriteLine(x+1);
        }

        static void Sum(int x, int y) 
        {
            Console.WriteLine(x+y);
        }
    }
}
