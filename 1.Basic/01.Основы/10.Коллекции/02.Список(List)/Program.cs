using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Класс List<T> из пространства имен System.Collections.Generic
             * представляет простейший список объектов.
             */

            // Создадим список объектов типа int
            List<int> listInt = new() { 1, 2, 3, 4, 5 };

            listInt.Add(6); // Добавление элемента

            listInt.AddRange(new int[] { 7, 8, 9}); // Добавление массива

            listInt.Insert(0, 10); // Вставляем на первое место в списке число 10

            listInt.RemoveAt(0); // Удаляем первый элемент
            Console.WriteLine($"{string.Join(" ", listInt)}");


            // Создание не однородной коллекции (object = любой тип)
            List<object> mylist = new() { 5, "Hello", 3.14, "World" };
            Console.WriteLine($"{string.Join(" ", mylist)}");

        }
    }
}

/*
 * void Add(item): добавление нового элемента в список
 * void AddRange(ICollection col): добавление в список массива
 * int BinarySearch(T item): бинарный поиск элемента в списке.
 *      Если элемент найден то возвращает индекс этого элемента. Список должен быть отсортирован.
 * int IndexOf(T item): возвращает индекс первого вхождения элемента
 * void Insert(int i, T item): вставляет элемент item в списке на позицию i
 * bool Remove(T item): удаляет элемент item из списка если успешно возвращает true
 * void RemoveAt(int i): удаление элемента по индексу i
 * void Sort(): сортировка
 */
