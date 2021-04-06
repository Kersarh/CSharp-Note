using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class CatWorker
    {
        /* Для работы с каталогами в пространстве имен System.IO предназначены классы:
        * Directory и DirectoryInfo
        */

        // Получение каталогов и файлов в заданной директории
        public static void ListFolder()
        {
            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                //Получение каталогов
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                //Получение списка файлов
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }

        // Создадим каталог
        public static void CreateFolder()
        {
            // При указании директории используется или двойной слеш: "C:\\",
            // или одинарный со знаком @: @"C:\Program Files"

            string path = @"C:\MyFolder";
            string subpath = @"new\folder";

            DirectoryInfo dirInfo = new(path);

            // Проверяем существует ли такая директория
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            else
            {
                Console.WriteLine("Директория уже существует");
            }

            // Создаем подкаталоги
            dirInfo.CreateSubdirectory(subpath);
        }

        // Получение информации о каталоге
        public static void FolderInfo()
        {
            string dirName = @"C:\Program Files";

            DirectoryInfo dirInfo = new(dirName);

            Console.WriteLine($"Название: {dirInfo.Name}");
            Console.WriteLine($"Путь: {dirInfo.FullName}");
            Console.WriteLine($"Дата создания: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
        }


        // Перемещение каталога
        public static void FolderMove()
        {
            string oldPath = @"C:\MyFolder";
            string newPath = @"C:\MyFolderNew";
            DirectoryInfo dirInfo = new(oldPath);
            if (dirInfo.Exists && Directory.Exists(newPath) == false)
            {
                dirInfo.MoveTo(newPath);
            }
        }

        // Удаление каталога
        public static void FolderDel()
        {
            string dirName = @"C:\MyFolderNew";

            try
            {
                DirectoryInfo dirInfo = new(dirName);
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Или 
            //Directory.Delete(dirName, true);
        }

    }
}

/* Класс Directory
 * Класс Directory предоставляет статические методы для работы с каталогами.
 * CreateDirectory(path): создает каталог
 * Delete(path): удаляет каталог
 * Exists(path): существует ли каталог по указанному пути
 * GetDirectories(path): получает список каталогов
 * GetFiles(path): получает список файлов
 * Move(sourceDirName, destDirName): перемещает каталог
 * GetParent(path): получение родительского каталога
 */

/* Класс DirectoryInfo
 * Create(): создает каталог
 * CreateSubdirectory(path): создает подкаталог по указанному пути path
 * Delete(): удаляет каталог
 * Свойство Exists: определяет, существует ли каталог
 * GetDirectories(): получает список каталогов
 * GetFiles(): получает список файлов
 * MoveTo(destDirName): перемещает каталог
 * Свойство Parent: получение родительского каталога
 * Свойство Root: получение корневого каталога
 */