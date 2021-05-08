using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupMethod();
        }

        /// <summary>
        /// Группировка элементов
        /// </summary>
        public static void GroupMethod()
        {
            Dictionary<string, int> dic = new()
            {
                ["user1"] = 1,
                ["user2"] = 3,
                ["user3"] = 2,
                ["user4"] = 1,
                ["user5"] = 3,
                ["user6"] = 3,
            };

            var group = from i in dic
                              group i by i.Value;
            
            // Аналогично
            var group2 = dic.GroupBy(i => i.Value);

            foreach (var item in group)
            {
                Console.WriteLine(string.Join(" ", item));
                //foreach (var i in item) Console.WriteLine($"{i.Key} - {i.Value} ");

            }
        }
    }
}
