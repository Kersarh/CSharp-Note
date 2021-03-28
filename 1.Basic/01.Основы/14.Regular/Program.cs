using System;
using System.Text.RegularExpressions;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Регулярные выражения предоставляют мощный, гибкий и
             * эффективный способ обработки текста.
             * Комплексная нотация сопоставления шаблонов регулярных выражений
             * позволяет быстро анализировать большие объемы текста.
             * Главный компонент обработки текста с помощью регулярных выражений 
             * представлен объектом System.Text.RegularExpressions.Regex
             * Синтаксис:
             * Regex(Выражение, Параметры);
             * Составление регулярных выражений:
             * https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expression-language-quick-reference
             */

            string s = "Регулярные выражения эффективный способ обработки текста";

            // Создаем регулярное выражение
            string re_str = @"выр(\w*)";
            Regex regex = new Regex(re_str, RegexOptions.Compiled);

            // Поиск на основе регулярного выражения
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений нет");
            }

            /*
            * Параметры Regex

            * Compiled: регулярное выражение компилируется в сборку для большего быстродействия
            * CultureInvariant: игнорировать региональные различия
            * IgnoreCase: игнорировать регистр
            * IgnorePatternWhitespace: удаляет пробелы и разрешает комментарии со знака #
            * Multiline: многострочный режим. Символы "^", "$" начало и конец строки
            * Singleline: однострочный режим. Весь текст как одна строка
            * Пример:
            * Regex regex = new Regex(@"туп(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            */

        }
    }
}
