using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Функции обработки исключений помогают справиться с непредвиденными ошибками в коде,
            * которые возникают при выполнении программы.
            * При обработке исключений используются ключевые слова try, catch и finally для действий, которые потенциально могут оказаться неудачными.
            * Это позволяет обрабатывать ошибки предотвращая аварийное завершение программы,
            * а также высвобождать ресурсы.
            */

            int a = 0;

            try // обязательный блок
            {
                // Код в котором может возникнуть ошибка
                int x = 5;
                int y = x / a; // деление на 0
                Console.WriteLine(y);
            }
            catch when (a == 0) // сработает только если a = 0
            {
                Console.WriteLine($"a не должно быть 0");
            }
            catch (Exception ex) // не обязателен если есть finally
            {
                // блок catch выполнится если возникнет ошибка
                Console.WriteLine($"Ошибка в программе! {ex.Message}");
            }
            finally // не обязателен если есть catch
            {
                // блок finally выполнится в любом случае
                Console.WriteLine("Блок finally");
            }


            // Использование throw
            try
            {
                // throw создаст исключение в программе
                throw new Exception("Вызов исключения!!! (throw)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
    }
}
