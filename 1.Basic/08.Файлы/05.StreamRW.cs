using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class StreamRW
    {
        /* Для более удобной работы с текстовыми файлами в пространстве System.IO
        * определены классы: StreamReader и StreamWriter.
        * 
        * Запись в файл StreamWriter конструктор:
        * StreamWriter(string): передает путь к файлу
        * StreamWriter(string, bool): bool запись данных в начало(false)
        * или в конец(true) файла.
        * StreamWriter(string, bool, Encoding): encoding кодировка
        * 
        * StreamWriter методы:
        * int Close(): закрывает файл и освобождает ресурсы
        * void Flush(): записывает в файл оставшиеся в буфере данные и очищает буфер.
        * Task FlushAsync(): асинхронная версия Flush
        * void Write(data): записывает в файл данные.
        * Task WriteAsync(data): асинхронная версия Write
        * void WriteLine(data): после записи добавляет символ окончания строки
        * Task WriteLineAsync(string value): асинхронная версия WriteLine
        * 
        * Чтение из файла
        * StreamReader конструктор
        * StreamReader(string): путь к файлу
        * StreamReader(string, Encoding): encoding кодировка файла
        * 
        * StreamReader методы:
        * void Close(): закрывает файл и освобождает ресурсы
        * int Peek(): следующий доступный символ, если нет то возвращает -1
        * int Read(): считывает и возвращает следующий символ
        * Task<int> ReadAsync(): асинхронная версия Read
        * string ReadLine(): считывает одну строку
        * string ReadLineAsync(): асинхронная версия ReadLine
        * string ReadToEnd(): считывает весь текст из файла
        * string ReadToEndAsync(): асинхронная версия ReadToEnd
        */

        public static void WriteText()
        {
            // запись
            string writePath = @"MyFile.txt";

            string text = "Привет мир!\nПока мир...";
            try
            {
                // Запись в файл
                using (StreamWriter sw = new(writePath, false, Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                // Запись в конец файла
                using (StreamWriter sw = new(writePath, true, Encoding.Default))
                {
                    sw.WriteLine("Допишем в конец файла");
                    sw.Write(10);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Асинхронная запись
        public static async void AsyncWriteText()
        {
            string writePath = @"MyFileAsync.txt";

            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new(writePath, false, Encoding.Default))
                {
                    await sw.WriteLineAsync(text);
                    await sw.WriteAsync("bonus data");
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        // Чтение

        //Считаем весь текст сразу
        public static async void ReadFile()
        {
            string path = @"MyFile.txt";

            try
            {
                using (StreamReader sr = new(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                // асинхронное чтение
                using (StreamReader sr = new(path))
                {
                    Console.WriteLine(await sr.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Считаем текст построчно
        public static async void ReadFileStr()
        {
            string path = @"MyFile.txt";

            using (StreamReader sr = new(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // асинхронное чтение
            using (StreamReader sr = new(path, Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
