using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Класс Queue<T> Представляет очередь, коллекцию объектов работающую
            * по алгоритму FIFO "первый пришел - первый ушел".
            * Queue<T> имеет следующие методы:
            * Dequeue используется для вывода первого элемента из очереди
            * Enqueue: добавляет элемент в конец очереди
            * Peek используется для просмотра следующего элемента в очереди
            */

            // Создадим очередь
            Queue<int> qnum = new();

            // Добавит элементы в очередь
            qnum.Enqueue(1); // очередь 1
            qnum.Enqueue(2); // очередь 1, 2
            qnum.Enqueue(3); // очередь 1, 2, 3
            qnum.Enqueue(4); // очередь 1, 2, 3, 4
            qnum.Enqueue(5); // очередь 1, 2, 3, 4, 5

            Console.WriteLine($"Очередь: {string.Join(" ", qnum )}");

            // получаем первый элемент очереди
            int num  = qnum.Dequeue(); //очередь 2, 3, 4, 5
            Console.WriteLine($"Извлеченный элемент из очереди {num}");

            Console.WriteLine($"Очередь: {string.Join(" ", qnum)}");

            // Следующий элемент в очереди
            num = qnum.Peek(); //очередь также 2, 3, 4, 5
            Console.WriteLine($"Следующий элемент {num}");

        }
    }
}
