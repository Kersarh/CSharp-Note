using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Arhiv
    {
        public static void ZipFunc()
        {

            string arhFolder = "D://Arhiv/"; // что архивируем
            string myZipFile = "D://Arh.zip"; // сжатый файл
            string newFolder = "D://Arhiv_new"; // папка, куда распаковывается файл

            // Архивация папки
            // false указывает нужно ли включать саму папку в архив или только её содержимое
            ZipFile.CreateFromDirectory(arhFolder, myZipFile, CompressionLevel.Optimal, false);
            Console.WriteLine("Архив создан");

            // Извлекаем
            ZipFile.ExtractToDirectory(myZipFile, newFolder);
            Console.WriteLine("Разархивирован");


            // Добавление в новый архив
            string myZipFile2 = "D://Arh2.zip";
            using (ZipArchive zipArchive = ZipFile.Open(myZipFile2, ZipArchiveMode.Create))
            {
                // путь к добавляемому файлу
                const string pathFileToAdd = @"D://Arhiv/MyFile.txt";
                // имя добавляемого файла
                const string nameFileToAdd = "File.txt";
                // добавляем файла в архив
                zipArchive.CreateEntryFromFile(pathFileToAdd, nameFileToAdd);
            }    



            // открываем архив в режиме обновления
            using (ZipArchive zipArchive = ZipFile.Open(myZipFile, ZipArchiveMode.Update))
            {
                // путь к добавляемому файлу
                const string pathFileToAdd = @"D://Arhiv/MyFile.txt";
                // имя добавляемого файла
                const string nameFileToAdd = "File2.txt";
                // добавляем файла в архив
                zipArchive.CreateEntryFromFile(pathFileToAdd, nameFileToAdd);

            }
        }
    }
}
