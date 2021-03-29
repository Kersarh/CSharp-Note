using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для работы с датой и временем предназначена структура DateTime.
             * Которая представляет дату и время от 00:00:00 1 января 0001 года
             * до 23:59:59 31 декабря 9999 года.
             * Для создания нового объекта DateTime можно использовать конструктор.
             * Пустой конструктор создает начальную дату
             * TimeSpan - представляет интервал времени.
             */

            DateTime date1 = new();
            Console.WriteLine(date1); // 01.01.0001 0:00:00
            // что равнозначно DateTime.MinValue);

            //Возможно указать заданную дату
            // год, месяц, день
            DateTime date2 = new(2010, 5, 15); // 15.05.2010 0:00:00

            // год, месяц, день, час, минута, секунда
            DateTime date3 = new(2010, 5, 15, 10, 15, 30); // 15.05.2010 10:15:30

            //Если необходимо получить текущую время и дату, то можно использовать ряд свойств DateTime:
            Console.WriteLine($"Now: {DateTime.Now}");
            Console.WriteLine($"Today: {DateTime.Today}");
            Console.WriteLine($"UtcNow: {DateTime.UtcNow}");


            /*Операции с DateTime
            * Add(TimeSpan value): добавляет значение TimeSpan
            * AddMonths(int value): добавляет месяц
            * AddYears(int value): добавляет годы
            * AddDays(double value): добавляет дни
            * AddHours(double value): добавляет часы
            * AddMinutes(double value): добавляет минуты
            */

            //добавим к заданной дате 3 часа:
            DateTime date4 = new(2010, 5, 15, 10, 15, 30); // 15.05.2010 10:15:30
            date4 = date4.AddHours(3); // 15.05.2010 13:15:30


            //Для вычитания используется метод Substract(DateTime date):
            DateTime date5 = new DateTime(2010, 5, 15, 10, 15, 30); 
            DateTime date6 = new DateTime(2010, 5, 15, 5, 15, 30); 
            Console.WriteLine(date5.Subtract(date6)); // 05:00:00 

            // вычтем три часа
            DateTime date7 = new(2010, 5, 15, 10, 15, 30); 
            Console.WriteLine(date7.AddHours(-3)); // передаем отрицательное значение для вычитания

            //Кроме операций сложения и вычитания еще есть ряд методов форматирования дат:

            DateTime date8 = new(2010, 5, 15, 10, 15, 30);
            Console.WriteLine(date8.ToLocalTime()); // 15.05.2010 14:15:30
            Console.WriteLine(date8.ToUniversalTime()); // 15.05.2010 6:15:30
            Console.WriteLine(date8.ToLongDateString()); // 15 мая 2010 г.
            Console.WriteLine(date8.ToShortDateString()); // 15.05.2010
            Console.WriteLine(date8.ToLongTimeString()); // 10:15:30
            Console.WriteLine(date8.ToShortTimeString()); // 10:15

            /* Метод ToLocalTime() преобразует время UTC в локальное время.
            * Метод ToUniversalTime() преобразует локальное время во время UTC.
            */


            /*
            * Форматирования вывода даты и времени:
            * D - Поный формат даты. 15 мая 2010 г
            * d - Краткий формат даты. 15.06.2010
            * F - Полный формат даты и времени. 15 мая 2010 г. 10:15:30
            * f - Полный формат даты и краткий времени. 15 мая 2010 г. 10:15
            * G - Краткий формат даты и полный формат времени. Например, 15.06.2010 10:15:30
            * g - Краткий формат даты и времени. Например, 15.06.2010 10:15
            * T - Полный формат времени.
            * t - Краткий формат времени.
            * M, m - Формат дней месяца. 15 мая
            * O, o - Формат обратного преобразования даты и времени.
            *      Вывод даты и времени в соответствии со стандартом ISO 8601 в формате
            *      "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffzzz".
            * R, r - Время по Гринвичу.
            * s - Сортируемый формат даты и времени.
            * U - Полный универсальный полный формат даты и времени.
            * u Краткий универсальный полный формат даты и времени.
            * Y, y - Формат года. Например, Июль 2015
            */

            DateTime now = DateTime.Now;
            Console.WriteLine("D: " + now.ToString("D"));
            Console.WriteLine("d: " + now.ToString("d"));
            Console.WriteLine("F: " + now.ToString("F"));
            Console.WriteLine("f: {0:f}", now);
            Console.WriteLine("G: {0:G}", now);
            Console.WriteLine("g: {0:g}", now);
            Console.WriteLine("M: {0:M}", now);
            Console.WriteLine("O: {0:O}", now);
            Console.WriteLine("o: {0:o}", now);
            Console.WriteLine("R: {0:R}", now);
            Console.WriteLine("s: {0:s}", now);
            Console.WriteLine("T: {0:T}", now);
            Console.WriteLine("t: {0:t}", now);
            Console.WriteLine("U: {0:U}", now);
            Console.WriteLine("u: {0:u}", now);
            Console.WriteLine("Y: {0:Y}", now);

            /* Настройка формата времени и даты
            * d - Представляет день месяца от 1 до 31.
            * dd - Представляет день месяца от 01 до 31.
            * ddd - Сокращенное название дня недели
            * dddd - Полное название дня недели
            * f / fffffff - Миллисекунды. Количество символов f = число разрядов
            * g - Период или эру ("н. э.")
            * h - Часы в виде от 1 до 12.
            * hh - Часы в виде от 01 до 12.
            * H - Часы в виде от 0 до 23.
            * HH - Часы в виде от 00 до 23.
            * K - Часовой пояс
            * m - Минуты от 0 до 59
            * mm - Минуты от 00 до 59
            * M - Месяц в виде от 1 до 12
            * MM - Месяц в виде от 01 до 12.
            * MMM - Сокращенное название месяца
            * MMMM - Полное название месяца
            * s - Секунды от 0 до 59
            * ss - Секунды от 00 до 59
            * t - Символы в обозначениях AM и PM
            * tt - AM или PM
            * y - Год как число из одной или двух цифр.
            * yy - Представляет год как число из одной или двух цифр.
            * yyy - Год из трех цифр
            * yyyy - Год из четырех цифр
            * z/ zz - Представляет смещение в часах относительно времени UTC
            */

            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd.MM.yyyy"));
        }
    }
}
