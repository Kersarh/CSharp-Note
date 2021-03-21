using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Арифметические операции:
            */

            // +  сложения (subtraction):
            int sum1 = 5;
            int sum2 = 10;
            int sum3 = sum1 + sum2;
            Console.WriteLine($"Сложение: {sum1}+{sum2}={sum3}"); // 15


            // - вычитание (subtraction):
            int sub1 = 5;
            int sub2 = 2;
            int sub3 = sub1 - sub2;
            Console.WriteLine($"Вычитание: {sub1}-{sub2}={sub3}"); // 3

            // * умножение:
            int mult1 = 5;
            int mult2 = 10;
            int mult3 = mult1 * mult2;
            Console.WriteLine($"Умножение: {mult1}*{mult2}={mult3}");

            // / деление:
            // При делении если оба числа целые, то результат будет округлен до целого числа
            int div1 = 10;
            int div2 = 3;
            int div3 = div1 / div2;
            Console.WriteLine($"Деление(int): {div1}/{div2}={div3}");

            double div4 = 10;
            double div5 = 3;
            double div6 = div4 / div5;
            Console.WriteLine($"Деление(double): {div4}/{div5}={div6}");

            // % получение остатка от деления:
            int rem_div1 = 10;
            int rem_div2 = 4;
            int rem_div3 = rem_div1 % rem_div2;
            Console.WriteLine($"Остаток от деления: {rem_div1}%{rem_div2}={rem_div3}");


            /*
            * Унарные операции:
            */

            // Инкремент(++) – это операция которая УВЕЛИЧИВАЕТ переменную на единицу
            /* Инкремент бывает префиксным и постфиксным.
            * Префиксный;
            * ++x значение переменной x увеличивается на 1,
            * а потом ее значение возвращается в качестве результата операции.
            */

            int inc1 = 4;
            int inc2 = ++inc1;
            Console.WriteLine($"{inc1} - {inc2} "); //5 - 5

            /* Постфиксный инкремент:
            * x++ значение переменной x возвращается в качестве результата операции,
            * а затем к нему прибавляется 1.
            */
            int inc3 = 5;
            int inc4 = inc3++;
            Console.WriteLine($"{inc3} - {inc4}"); // 6 - 5


            // Декремент(--) – это операция которая УМЕНЬШАЕТ переменную на единицу
            /* Существует префиксная форма декремента (--x) и постфиксная (x--),
            * Аналогичный в работе префиксной и постфиксной формам инкремента
            */
            int dec1 = 5;
            int dec2 = --dec1;
            Console.WriteLine($"{dec1} - {dec2} "); // 4 - 4

            int dec3 = 5;
            int dec4 = dec3--;
            Console.WriteLine($"{dec3} - {dec4} "); // 5 - 4

            /*
            * Операции присваивания
            */

            /*
            * int a = 10;
            * a += 10; // a = a + 10
            * a -= 5; // a = a - 5
            * a *= 2; //a = a * 2
            * a /= 2; // a = a / 2
            */

            /*
            * Условные выражения
            */

            /* Операции сравнения
            * В операциях сравнения сравниваются два операнда и возвращается значение типа bool
            * true если выражение верно, и false, если выражение неверно.
            */


            // == равно
            // Возвращает true, если операнды равны, и false если не равны.

            int num1 = 10;
            int num2 = 4;


            bool num3 = num1 == num2; // false
            Console.WriteLine($"== {num3}");


            // != НЕ равно
            // Возвращает true, если операнды НЕ равны, и false если равны.

            bool num4 = num1 != num2;    // true
            Console.WriteLine($"!= {num4}");


            // < "меньше чем" и > "больше чем"
            bool num5 = num1 < num2; // false
            bool num6 = num1 > num2; // true
            Console.WriteLine($"< {num5}");
            Console.WriteLine($"> {num6}");

            // <= "меньше или равно" и >= "больше или равно"
            bool num7 = num1 <= num2; // false
            bool num8 = num1 >= num2; // true
            Console.WriteLine($"<= {num7}");
            Console.WriteLine($">= {num8}");

            /*
             * Логические операции
             * Логические операторы, которые также возвращают значение типа bool.
             * В качестве операндов они принимают значения типа bool.
             * Как правило, применяются к отношениям и объединяют несколько операций сравнения.
             */

            // | логическое ИЛИ (логическое сложение)
            // Возвращает true, если хотя бы один из операндов возвращает true.
            bool log1 = true | false; // true
            Console.WriteLine($"true | false = {log1}");

            // & операция логического умножения или логическое И.
            // Возвращает true, если ОБА операнда одновременно равны true.
            bool log2 = true & false; // false
            Console.WriteLine($"true & false = {log2}");

            // || Операция логического сложения.
            // Возвращает true, если хотя бы один из операндов возвращает true.


            bool log3 = true || false; // true
            Console.WriteLine($"true || false = {log3}");

            // && Операция логического умножения.
            // Возвращает true, если оба операнда одновременно равны true.
            bool log4 = true && false; // true
            Console.WriteLine($"true && false = {log4}");

            // В выражении z = x | y; вычисляются оба значения x и y.
            // В выражении z = x || y; сначала вычисляется значение x,
            // и если оно равно true, то значения y не вычисляется,
            // так как в любом случае z будет равно true.
            // Аналогично для & и &&

            // ! Операция логического отрицания.
            // Производится над одним операндом и возвращает true, если операнд равен false.
            bool log5 = !true; // false
            Console.WriteLine($"!true = {log5}");

            // ^ Операция исключающего ИЛИ.
            // Возвращает true, если либо первый, либо второй операнд но НЕ ОДНОВРЕМЕННО равны true, иначе возвращает false
            bool log6 = true ^ false;
            Console.WriteLine($"true ^ false = {log6}");
        }
    }
}
