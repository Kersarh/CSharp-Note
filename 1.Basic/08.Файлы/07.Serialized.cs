using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Serial
    {
        public static void BinSerial()
        {
            // объект для сериализации
            Person person = new("User", "qwerty", 100);

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new();
            string file = @"User.bin";

            // записываем сериализованный объект
            using (FileStream fs = new(file, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
            }

            // десериализация
            using (FileStream fs = new(file, FileMode.OpenOrCreate))
            {
                Person DesPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine($"Имя: {DesPerson.Name}, Пароль: {DesPerson.Password}");
                Console.WriteLine($"NotSerial = {DesPerson.NotSerial}"); // Принимает значение по умолчанию
                
            }
        }
    }

    // Чтобы объект можно было сериализовать
    // Необходимо пометить его атрибутом [Serializable]
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public string Password { get; set; }

        // [NonSerialized] запрещает сериализацию
        [NonSerialized]
        public int NotSerial;

        public Person(string name, string pwd, int ns)
        {
            Name = name;
            Password = pwd;
            NotSerial = ns;
        }
    }
}
