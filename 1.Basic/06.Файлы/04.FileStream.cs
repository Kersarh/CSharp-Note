using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class FileRW
    {
        /* Для работы с файлами используются FileStream.
         * FileStream(string filename, FileMode.mode)
         * Модификатор доступа:
         * Append: то текст добавляется в конец файл. Если файла нет, то он создается.
         * Create: создает новый файл. Если файл существует то он будет перезаписан
         * CreateNew: создает новый файл. Если файл существует то вызовет ошибку
         * Open: открывает файл. Если файла нет вызывает ошибку
         * OpenOrCreate: если файл существует то открыть, если нет - создать
         * Truncate: если файл существует, то перезаписывается.
         * 
         * Статические методы класса File:
         * FileStream File.Open(string file, FileMode.mode);
         * FileStream File.OpenRead(string file);
         * FileStream File.OpenWrite(string file);
         */

        public static void ReadWrite()
        {
            string text = "Текст для записи в файл.";
            string file = @"MyFile.txt";
            // Запись в файл
            // без using нужен fstream.Close();
            using (FileStream fstream = new(file, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = Encoding.Default.GetBytes(text);
                // запись в файл
                fstream.Write(array, 0, array.Length);
                // fstream.Write(array);
                Console.WriteLine($"Записано в файл {file}") ;
            }

            // чтение из файла
            using (FileStream fstream = File.OpenRead(file))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string data = Encoding.Default.GetString(array);
                Console.WriteLine($"Прочитано: {data}");
            }
        }

        public static async void AsyncWriteStream()
        {
            string text = "Текст для записи в файл.";
            string file = @"MyFile.txt";

            // запись в файл
            using FileStream fstream = new(file, FileMode.OpenOrCreate);
            byte[] array = Encoding.Default.GetBytes(text);
            // асинхронная запись в файл
            //await fstream.WriteAsync(array, 0, array.Length);
            await fstream.WriteAsync(array.AsMemory(0, array.Length));
        }

        public static async void AsyncReadStream()
        {
            string file = @"MyFile.txt";
            // чтение из файла
            using FileStream fstream = File.OpenRead(file);
            byte[] array = new byte[fstream.Length];
            // асинхронное чтение файла
            await fstream.ReadAsync(array.AsMemory(0, array.Length));

            string textFile = System.Text.Encoding.Default.GetString(array);
            Console.WriteLine($"Содержимое файла: {textFile}");

        }

    }
}

/* Произвольный доступ к файлам
* Бинарные файлы представляют определенную структуру зная которую
* возможно получать из файла необходимую информацию или записывать ее.
* С помощью метода Seek() мы можем управлять курсором указывая
* с какого места в файле считывать или записывать байты.
* Seek(смещение, позиция) принимает два параметра: смещение и позиция в файле.
* Позиция в файле:
* SeekOrigin.Begin: начало файла
* SeekOrigin.End: конец файла
* SeekOrigin.Current: текущая позиция в файле
* 
* Курсор смещается вперед на значение смещения относительно позиции.
* Смещение может быть как  положительным когда курсор смещается вперед,
* так и отрицательным когда курсор смещается назад.
* fstream.Seek(3, SeekOrigin.Begin); // 3 символа с начала
* fstream.Seek(-3, SeekOrigin.End); // минус 3 символа с конца
*/



