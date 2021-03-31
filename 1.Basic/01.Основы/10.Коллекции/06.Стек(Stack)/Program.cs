using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Класс Stack<T> представляет коллекцию реализующую алгоритм LIFO
            * "последний пришел - первый ушел".
            * Stack<T> имеет следующие методы:
            * Push: добавляет элемент в стек
            * Pop: извлекает элемент из стека
            * Peek используется для просмотра следующего элемента в стеке
            */

            // Создадим стек
            Stack<int> snum = new();

            // Добавим элементы в стек
            snum.Push(1); // в стеке 1
            snum.Push(2); // в стеке 2, 1
            snum.Push(3); // в стеке 3, 2, 1
            snum.Push(4); // в стеке 4, 3, 2, 1
            snum.Push(5); // в стеке 5, 4, 3, 2, 1

            Console.WriteLine($"Стек: {string.Join(" ", snum)}");

            // Получаем первый элемент стека
            int num = snum.Pop(); // в стеке 4, 3, 2, 1
            Console.WriteLine($"Извлеченный элемент: {num}");

            Console.WriteLine($"Стек: {string.Join(" ", snum)}");

            // Следующий элемент в стеке
            num = snum.Peek(); // стек также 4, 3, 2, 1
            Console.WriteLine($"Следующий элемент: {num}");

        }
    }
}
