using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class FileWorker
    {
        /* Пара классов File и FileInfo.
         * FileInfo:
         * CopyTo(path): копирует файл в новое место по указанному пути path
         * Create(): создает файл
         * Delete(): удаляет файл
         * MoveTo(destFileName): перемещает файл в новое место
         * Свойство Directory: получает родительский каталог в виде объекта DirectoryInfo
         * Свойство DirectoryName: получает полный путь к родительскому каталогу
         * Свойство Exists: указывает, существует ли файл
         * Свойство Length: получает размер файла
         * Свойство Extension: получает расширение файла
         * Свойство Name: получает имя файла
         * Свойство FullName: получает полное имя файла
         * 
         * File (Статические методы):
         * Copy(): копирует файл в новое место
         * Create(): создает файл
         * Delete(): удаляет файл
         * Move: перемещает файл в новое место
         * Exists(file): определяет, существует ли файл
         */
        // Создание файла
        public static void FileCreate()
        {
            string path = @"MyFile.txt";
            FileInfo fileInfo = new(path);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            
        }


        // Информация о файле
        public static void FileInfo()
        {
            string path = @"MyFile.txt";
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
            {
                Console.WriteLine("Имя: {0}", fileInfo.Name);
                Console.WriteLine("Путь: {0}", fileInfo.FullName);
                Console.WriteLine("Время создания: {0}", fileInfo.CreationTime);
                Console.WriteLine("Размер: {0}", fileInfo.Length);
            }
        }

        public static void CopyFile()
        {
            string path = @"MyFile.txt";
            string newpath = @"MyFileCopy.txt";
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
            {
                fileInfo.CopyTo(newpath, true);
                // File.Copy(path, newPath, true);
            }
        }

        // Перемещение
        public static void MoveFile()
        {
            string path = @"MyFile.txt";
            string newpath = @"MyFileMove.txt";
            FileInfo fileInfo = new(path);
            if (fileInfo.Exists)
            {
                fileInfo.MoveTo(newpath);
                // File.Move(path, newPath);
            }
        }

        // Удаление
        public static void FileDel()
        {
            List<string> listdel = new();
            listdel.Add(@"MyFileMove.txt");
            listdel.Add(@"MyFileCopy.txt");

            foreach (string path in listdel)
            {
                FileInfo fileInfo = new(path);
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                    // File.Delete(path);
                }
            }
        }

    }
}
