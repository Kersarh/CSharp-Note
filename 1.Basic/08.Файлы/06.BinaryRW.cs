using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    // Создадим структуру
    struct User
    {
        public string username;
        public string password;

        public User(string u, string p)
        {
            username = u;
            password = p;
        }
    }


    class BinaryRW
    {
        public static void BinRW()
        {
            User[] usr = new User[2];
            usr[0] = new User("user", "qwerty");
            usr[1] = new User("admin", "ytrewq");

            string path = @"User.bin";

            try
            {
                // создаем объект BinaryWriter
                using (BinaryWriter writer = new(File.Open(path, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    // В каком порядке записываются данные
                    // в таком же порядке они будут в файле.
                    foreach (User u in usr)
                    {
                        writer.Write(u.username);
                        writer.Write(u.password);
                    }
                }

                // создаем объект BinaryReader
                using BinaryReader reader = new(File.Open(path, FileMode.Open));
                // PeekChar()считывает следующий символ.
                // Если символа нет то вернет - 1
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    string pwd = reader.ReadString();

                    Console.WriteLine($"Пользователь: {name}, Пароль: {pwd}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


/* BinaryWriter
 * Close(): закрывает поток и освобождает ресурсы
 * Flush(): очищает буфер, дописывая оставшиеся данные
 * Seek(): устанавливает позицию
 * Write(): записывает данные
 * 
 * BinaryReader
 * Close(): закрывает поток и освобождает ресурсы
 * ReadByte(): считывает байт и перемещает указатель на один байт
 * ReadChar(): считывает один символ, перемещает указатель на столько байтов
 * ReadDecimal(): считывает decimal и перемещает указатель на 16 байт
 * ReadDouble(): считывает double и перемещает указатель на 8 байт
 * ReadInt16(): считывает short и перемещает указатель на 2 байта
 * ReadInt32(): считывает int и перемещает указатель на 4 байта
 * ReadInt64(): считывает long и перемещает указатель на 8 байт
 * ReadSingle(): считывает float и перемещает указатель на 4 байта
 * ReadString(): считывает значение string
 * строка начинается значением длины строки(7-битное целое число)
 */
