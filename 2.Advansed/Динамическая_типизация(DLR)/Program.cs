using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        // В C# начиная с NET 4 появилась возможность динамической типизации - среда DLR (аналогично например python)
        // В среде DLR возможно создавать динамические объекты, которые выявляются на этапе выполнения программы
        // А так же использовать их вместе с объектами статической типизации.

        //В языках со статической типизацией определение типов данных происходит на этапе компиляции.
        //В динамических языках определение типов данных происходит на этапе выполнения программы.
        static void Main()
        {
            // Динамический тип определяется через ключевой слово dynamic
            dynamic a = "hello";
            Console.WriteLine($"a = {a}, type: {a.GetType()}");
            // Динамические обекты могут менять свой тип во времы выполнения программы
            a = 10;
            Console.WriteLine($"a = {a}, type: {a.GetType()}");

            Console.WriteLine(DynamicMethod(10)); // 11
            Console.WriteLine(DynamicMethod("hello")); // hello1

            DemoExpadoObjMethod();

            Console.ReadLine();
        }

        private static void DemoExpadoObjMethod()
        {
            // Для динамического обьекта ExpandoObject возможно обьявлять несколько различных свойств
            dynamic myExpObj = new System.Dynamic.ExpandoObject();
            myExpObj.Name = "Administrator";
            myExpObj.Password = "qwerty";
            myExpObj.Role = new List<dynamic> { "admin", 10, 20, "user" };
            Console.WriteLine($"login: {myExpObj.Name} Password: {myExpObj.Password}");
            foreach (dynamic r in myExpObj.Role) // перечисление ролей
                Console.WriteLine(r);

            // объявляем метод меняющий пароль и добавляющий к нему 10
            myExpObj.ChangePassword = (Action<dynamic>)(x => myExpObj.Password = x+10);
            // ! Внимание если пароль число то будет суммирование, если строка то в конце добавится 10
            // ! Подобные ошибки часто могут приводить к непредсказуемому поведению программы
            myExpObj.ChangePassword("NewPassword"); 
            Console.WriteLine($"login: {myExpObj.Name} Password: {myExpObj.Password}");
        }

        static dynamic DynamicMethod(dynamic data)
        {
            return data + 1;
        }
    }
}
