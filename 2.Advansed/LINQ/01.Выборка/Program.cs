using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FirstLetter();
            SelectNum();
            SelectData();
            VarQueri();
            ManyInData();
            SkipTake();
        }

        /// <summary>
        /// Отфильтруем значения по первой букве
        /// </summary>
        public static void FirstLetter()
        {
            string[] data = { "Весна", "Лето", "Осень", "Зима", "Январь", "Февраль", "Март", "Апрель", "Май" };

            IOrderedEnumerable<string> selectData = from i in data // определяем каждый объект из teams как t
                                                    where i.ToUpper().StartsWith("О") //фильтрация по критерию
                                                    orderby i  // упорядочиваем по возрастанию
                                                    select i; // выбираем объект
            foreach (string s in selectData)
            {
                Console.WriteLine(s);
            }

            // Через методы расширения
            IOrderedEnumerable<string> selectData2 = data.Where(i => i.ToUpper().StartsWith("Б")).OrderBy(i => i);

            foreach (string s in selectData2)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// Получим четные элементы из массива
        /// </summary>
        public static void SelectNum()
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            IEnumerable<int> data = from i in numbers
                                    where i % 2 == 0
                                    where i > 10
                                    select i;
            foreach (int i in data)
            {
                Console.WriteLine(i);
            }

            // Через метод расширения
            IEnumerable<int> data2 = numbers.Where(i => i % 2 == 0 && i > 10);
            foreach (int i in data2)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Выборка определенных данных
        /// </summary>
        public static void SelectData()
        {
            Dictionary<string, int> dic = new()
            {
                ["user1"] = 1,
                ["user2"] = 2,
                ["user3"] = 3,
                ["user4"] = 4,
            };

            // получим только содержимое поля key
            IEnumerable<string> unames = from u in dic select u.Key;
            foreach (string n in unames)
            {
                Console.WriteLine(n);
            }
            // ------------------------------------
            // Оператор select позволяет создать объект анонимного типа на основе заданного.
            // Результат содержит набор объектов анонимного типа с определенными свойствами  user_name, user_id.
            var items = from u in dic
                        select new
                        {
                            user_name = u.Key,
                            user_id = DateTime.Now.Year - u.Value
                        };

            foreach (var n in items)
            {
                Console.WriteLine($"{n.user_name} - {n.user_id}");
            }
        }

        /// <summary>
        /// Оператор let для промежуточных вычислений
        /// </summary>
        public static void VarQueri()
        {
            Dictionary<string, int> dic = new()
            {
                ["user1"] = 1,
                ["user2"] = 2,
                ["user3"] = 3,
                ["user4"] = 4,
            };

            var data = from u in dic
                       let name = u.Key + "_new"
                       select new
                       {
                           Name = name,
                           id = u.Value
                       };
        }

        /// <summary>
        /// Выборка из нескольких источников
        /// </summary>
        public static void ManyInData()
        {
            Dictionary<string, int> dic = new()
            {
                ["user1"] = 1,
                ["user2"] = 2,
            };

            List<string> l = new()
            {
                "qwerty",
                "asdfgh",
            };

            // при выборке из двух источников каждый элемент первого источника будет сопоставлен
            // с каждым элементом из второго источника
            var userPass = from user in dic
                           from data in l
                           select new { Name = user.Key, Data = data };

            foreach (var p in userPass)
            {
                Console.WriteLine($"{p.Name} - {p.Data}");
            }
        }

        /// <summary>
        /// Методы Skip Take
        /// </summary>
        public static void SkipTake()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            // берем первые 3 элемента
            IEnumerable<int> result = num.Take(3);
            Console.WriteLine(string.Join(" ", result));

            // пропускаем первые 3 элемента
            IEnumerable<int> result2 = num.Skip(3);
            Console.WriteLine(string.Join(" ", result2));

            // получим 3 элемента начиная с 3
            IEnumerable<int> result3 = num.Skip(5).Take(3);
            Console.WriteLine(string.Join(" ", result3));

            // TakeWhile выбирает элементы начиная с первого
            // пока верно условие x < 5
            IEnumerable<int> result4 = num.TakeWhile(x => x < 5);
            Console.WriteLine(string.Join(" ", result4));

            // SkipWhile пропускает элементы начиная с первого
            // пока верно условие x < 5
            IEnumerable<int> result5 = num.SkipWhile(x => x < 5);
            Console.WriteLine(string.Join(" ", result5));
        }
    }
}