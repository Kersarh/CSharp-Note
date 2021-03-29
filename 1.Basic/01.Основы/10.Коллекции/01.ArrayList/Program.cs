using System;
using System.Collections;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList представляет коллекцию объектов разных типов.
             * 
             * https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.arraylist?view=net-5.0
             * Мы не рекомендуем использовать ArrayList класс для новой разработки.
             * Вместо этого рекомендуется использовать универсальный List<T> класс.
             * ArrayList Класс предназначен для хранения разнородных коллекций объектов.
             * Однако это не всегда обеспечивает наилучшую производительность.
             * Вместо этого рекомендуется следующее:
             * Для разнородной коллекции объектов используйте List<Object>.
             * Для однородной коллекции объектов используйте List<T> класс.
             * С классом List познакомимся чуть позже
             */



            ArrayList list = new(); // Создаем
            list.Add(10); // добавляем int
            list.Add(55.5); // добавляем double
            list.Add("Hello"); // добавляем string
            list.AddRange(new int[] { 20, 40 }); // добавляем массив

            // получение элемента по индексу
            Console.WriteLine(list[1]);
            Console.WriteLine(new string('-', 20));

            // Пройдемся по списку циклом foreach
            foreach (object obj in list)
            {
                Console.WriteLine(obj); 
            }
            Console.WriteLine(new string('-', 20));

            // удаляем первый элемент
            list.RemoveAt(0);

            // переворачиваем список
            list.Reverse();

            // перебор значений циклом for
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();
        }
    }
}
