using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Dictionary Представляет коллекцию ключей и значений Dictionary<TKey,TValue>.
            * Словарь хранит объекты представляющие пару ключ-значение.
            * Каждый объект словаря является структурой
            * KeyValuePair<TKey, TValue>
            * Благодаря свойствам Key и Value
            * возможно получить ключ и значение элемента словаря.
            */

            // Создадим словарь
            Dictionary<int, string> season = new();

            // Заполним его значениями
            season.Add(1, "Зима");
            season.Add(3, "Весна");
            season.Add(2, "Лето");
            season.Add(4, "Осень");

            // Можно инициализировать при создании
            Dictionary<int, string> season2 = new()
            {
                { 1, "Зима"},
                { 2, "Весна"},
                { 3, "Лето" },
                { 4, "Осень" },
            };

            // C C# 6.0 можно инициализировать так
            Dictionary<int, string> season3 = new()
            {
                [1] = "Зима",
                [2] = "Весна",
                [3] = "Лето",
                [4] = "Осень",
            };

            // Получение элементов словаря
            foreach (KeyValuePair<int, string> keyValue in season)
            {
                Console.WriteLine($"Ключ: {keyValue.Key}, Значение: {keyValue.Value}");
            }

            // получение элемента по ключу
            string s1 = season[3]; // Весна

            // изменение объекта
            season[1] = "Winter";

            // удаление по ключу
            season.Remove(1);

        }
    }
}
