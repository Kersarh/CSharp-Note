using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* В C# строки представляет тип string,
             * Вся функциональность работы сосредоточена в классе System.String.
             * string по сути является псевдонимом для класса System.String.
             * Строки представляют текст как последовательность символов Unicode.
             * Максимальный размер в памяти 2 ГБ.        
            */

            // Инициализация используя переменную типа string
            string s1 = "hello";
            string s2 = null; // отсутствующее значение
            Console.WriteLine($"{s1} - {s2}.");

            // Инициализация через конструктор класса
            string s3 = new('-', 10); // Результат: ----------
            Console.WriteLine(s3);

            string s4 = new(new char[] { 'w', 'o', 'r', 'l', 'd' }); // world
            Console.WriteLine(s4);

            // Обращение к строке по индексу
            char c1 = s1[1]; // символ 'e'
            Console.WriteLine($"{c1}");
            Console.WriteLine($"Длинна строки: {s1.Length}"); // Длинна строки
            Console.WriteLine("Компания \"Рога и копыта\""); // Экранирование кавычек

            /*
            * Конкатенация - сложение(объединение) строк.
            * Объединение может производиться с помощью операции + или метода Concat:
            */
            string s5 = "Hello";
            string s6 = "world";

            // +
            string s7 = s5 + " " + s6 + "!"; // Hello world
            Console.WriteLine($"Через +: {s7}");
            // Concat
            string s8 = string.Concat(s5, " ", s6, "!");
            Console.WriteLine($"Через Concat: {s8}");
            // Join
            string[] s9 = new string[] { s5, s6};
            string s10 = string.Join(" ", s9); // разделитель " ", s9 массив строк
            Console.WriteLine($"Через Join: {s10}");

            /* Сравнение Compare
            * Если первая строка по алфавиту стоит выше второй,
            * то возвращается число меньше нуля.
            * Иначе возвращается число больше нуля.
            * Если строки равны возвращается 0.
            */

            int result = string.Compare(s5, s6);
            if (result < 0)
            {
                Console.WriteLine("Первая строка выше второй");
            }
            else if (result > 0)
            {
                Console.WriteLine("Первая строка ниже второй");
            }
            else
            {
                Console.WriteLine("Строки равны");
            }

            /*
            * Замена Replace
            */
            string s11 = "Hello World";
            s11 = s11.Replace("World", "Мир!");
            Console.WriteLine(s11);

            s11 = s11.Replace("H", ""); // ello Мир!
            Console.WriteLine(s11);

            /* Разделение(Split)
            * Split позволяет разделить строку на массив подстрок.
            * В качестве параметра Split принимает массив символов или строк,
            * по которым будет разделена строка.
            */
            string s12 = "Тестовая строка с разными словами";
            string[] words = s12.Split(" ");

            int i = 0;
            foreach (string s in words)
            {
                i++;
                Console.WriteLine($"Слово {i}: {s}");
            }

            // Параметр StringSplitOptions.RemoveEmptyEntries говорит, что надо удалить все пустые подстроки.
            words = s12.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            /*
            * Удаление символов Trim Remove 
            */

            string s13 = " Hello world! ";
            s13 = s13.Trim(); // "Hello world!"
            s13 = s13.Trim('H'); // ello world!
            Console.WriteLine(s13);
            // Remove удаляет все символы и текущей позиции и до конца
            s13 = s13.Remove(9); // ello worl
            // вырезаем первые два символа
            s13 = s13.Remove(0, 2); // lo worl
            Console.WriteLine(s13);

            /*
            * Substring - Обрезка строк
            */
            string s14 = "Hello World";
            // обрезаем начиная до второго символа
            s14 = s14.Substring(1); // ello World

            // обрезаем последний символ
            s14 = s14.Substring(0, s14.Length - 1); // ello Worl
            Console.WriteLine(s14);

            /*
            * Поиск в строке
            */
            // IndexOf вернет индекс ПЕРВОГО вхождения
            int indexOfChar = s1.IndexOf("o"); // 4

            // LastIndexOf вернет индекс ПОСЛЕДНЕГО вхождения
            indexOfChar = s1.LastIndexOf("o"); // 7

            // StartsWith и EndsWith позволяет узнать начинается или заканчивается
            // строка на определенную подстроку.
            // Начинается на Hel
            bool b1 = s1.StartsWith("Hel"); // True
            // Заканчивается на d!
            bool b2 = s1.EndsWith("d!"); // True
        }
    }
}
