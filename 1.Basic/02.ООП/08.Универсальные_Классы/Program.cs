using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Обобщения(generics) означает параметризованный тип данных.
            * Параметризованные типы данных позволяют создавать
            * классы, структуры, интерфейсы, методы и делегаты,
            * в которых обрабатываемые типы данных указываются в виде параметра.
            * 
            * Угловые скобки в описании class MyClass<T> указывают,
            * что класс является обобщенным, а тип T в угловых скобках
            * может быть любым типом.
            * Необязательно использовать именно букву T,
            * это может быть и любая другая буква или набор символов.
            */

            MyClass<string> obj = new(); // ожидаемый тип строка
            obj.name = "User"; 

            MyClass<int> obj2 = new(); // ожидаемый тип число
            obj2.name = 123;

            Acc<string, int> acc = new();
            acc.Username = "string";
            acc.Password = 123;


        }
    }

    public class MyClass<T>
    {
        public T name;

        public void Method()
        {
            Console.WriteLine(name);
        }

    }


    public class Acc<T, V>
    {
        public T Username { get; set; }
        public V Password { get; set; }

    }
}
