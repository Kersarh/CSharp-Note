using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Кортеж предназначен для группирования нескольких элементов данных
            * Определение:
            * (тип_хранимых_значений) имя = (значение);
            * Для обращения к элементам кортежа используется поле
            * Item[номер_элемента]
            * 
            * Чаще всего кортежи используются как возвращаемый методом тип.
            * Можно сгруппировать результаты метода в кортеж
            */

            (string, int) tuple1 = ("Текст", 10);
            Console.WriteLine($"1: {tuple1.Item1}, 2: {tuple1.Item2}.");

            // Тип данных можно не указывать явно. Например
            var tuple2 = ("абв", 10);
            tuple2.Item2 += 5;
            Console.WriteLine(tuple2.Item2);

            // Возможно задать название для полей кортежа
            // и обращаться к полям по названию
            var tuple3 = (txt: "абв", num: 10);
            (string txt, int num) tuple4 = ("абв", 10);
            Console.WriteLine($"{tuple3.txt} и {tuple4.num}");

            // Возможно упрощенное использование
            var (text, number) = ("абв", 10);
            Console.WriteLine($"text: {text}, number: {number}");

        }
    }
}
