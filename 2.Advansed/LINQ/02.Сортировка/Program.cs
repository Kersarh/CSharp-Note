using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SortNum();
            SortMany();
            Method();
        }

        /// <summary>
        /// Сортировка массива
        /// </summary>
        public static void SortNum()
        {
            int[] numbers = { 55, 56, 1, 78, 4, 1, 90, 45, 1, 67, 8, 4, 9, 0 };
            var sortNumbers = from i in numbers
                              orderby i
                              select i;
            // или 
            IEnumerable<int> sortNumbers2 = numbers.OrderBy(i => i);

            foreach (int i in sortNumbers)
                Console.WriteLine(i);
        }

        /// <summary>
        /// Сортировка по нескольким признакам
        /// </summary>
        public static void SortMany()
        {
            Dictionary<string, int> dic = new()
            {
                ["user1"] = 2,
                ["user2"] = 3,
                ["user3"] = 1,
                ["user4"] = 4,
                ["user6"] = 4,
                ["user5"] = 4,
            };
            // Упорядочить по 2 значениям
            var result = from i in dic
                         orderby i.Value, i.Key
                         select i;
            // или 
            var result2 = dic.OrderBy(i => i.Value).ThenBy(i => i.Key);

            foreach (KeyValuePair<string, int> a in result)
                Console.WriteLine($"{a.Value} - {a.Key}");
        }

        /// <summary>
        /// Удаление общих элементов
        /// </summary>
        public static void Method()
        {
            int[] m1 = { 1, 2, 3, 4, 5, 5, 5 };
            int[] m2 = { 3, 4, 5, 6, 7 };

            // из массива m1 убираются все общие элементы с массивом m2.
            var result1 = m1.Except(m2);

            foreach (int i in result1)
                Console.Write($"{i} ");
            Console.WriteLine("\n-----------------------");

            // Получаем общие элементы коллекций
            var result2 = m1.Intersect(m2);

            foreach (int i in result2)
                Console.Write($"{i} ");
            Console.WriteLine("\n-----------------------");

            // объединение массивов, без дубликатов
            var result3 = m1.Union(m2);
            //var result3 = m1.Concat(m2); // с сохранением дубликатов 

            foreach (int i in result3)
                Console.Write($"{i} ");
            Console.WriteLine("\n-----------------------");

            var result4 = m1.Concat(m2).Distinct();
            //var result4 = m1.Distinct(); // удаление дубликатов из текущей коллекции

            foreach (int i in result4)
                Console.Write($"{i} ");
            Console.WriteLine("\n-----------------------");

        }

    }

}
