using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Disk
    {
        /* Для представления диска в пространстве имен System.IO имеется класс DriveInfo.
        * Этот класс имеет метод GetDrives возвращающий имена всех логических дисков.
        * Также он предоставляет ряд свойств:
        * AvailableFreeSpace: возвращает объем доступного свободного места на диске в байтах
        * TotalFreeSpace: общий объем свободного места на диске в байтах
        * DriveFormat: Файловая система
        * Name: имя диска
        * VolumeLabel: метка тома (получаем или устанавливает)
        * DriveType: тип диска
        * IsReady: готовность диска
        * TotalSize: размер диска в байтах
        */

        public static void DiskWorker()
        {
            DriveInfo[] drives = DriveInfo.GetDrives(); // получаем данные о дисках

            // Через цикл получаем данные о каждом конкретном диске
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Диск: {drive.Name}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Файловая система: {drive.DriveFormat}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                    Console.WriteLine($"Объем: {drive.TotalSize}, Свободно: {drive.TotalFreeSpace}");
                }
                Console.WriteLine();
            }
        }
    }
}
