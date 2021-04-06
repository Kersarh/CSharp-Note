using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Диски
            //Disk.DiskWorker();

            //// Каталоги
            //CatWorker.ListFolder(); // Список
            //CatWorker.CreateFolder(); // Создание папки
            //CatWorker.FolderInfo(); // Информация
            //CatWorker.FolderMove(); // Перемещение
            //CatWorker.FolderDel(); // Удаление

            //// Файлы
            //FileWorker.FileCreate();
            //FileWorker.FileInfo();
            //FileWorker.CopyFile();
            //FileWorker.MoveFile();
            //FileWorker.FileDel();

            //// FileStream
            //FileRW.ReadWrite();
            //FileRW.AsyncWriteStream();
            //FileRW.AsyncReadStream();

            // StreamWriterReader
            //StreamRW.WriteText();
            //StreamRW.AsyncWriteText();
            //StreamRW.ReadFile();
            //StreamRW.ReadFileStr();

            // BinaryReaderWriter
            //BinaryRW.BinRW();

            // Сериализация
            //Serial.BinSerial();

            // Архивация
            Arhiv.ZipFunc();


        }
    }
}
