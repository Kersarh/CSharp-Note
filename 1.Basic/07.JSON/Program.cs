using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /* Класс JsonSerializer который позволяет сериализовать объект в json и
             * десериализовать json в объект.
             * 
             * Для сохранения объекта в json в классе JsonSerializer определен статический метод Serialize():
             * string Serialize(Object obj, Type type, JsonSerializerOptions options): сериализует объект obj
             * типа type и возвращает код json в виде строки.
             * options позволяет задать дополнительные опции
             * 
             * string Serialize<T>(T obj, JsonSerializerOptions options): типизированная версия
             * сериализует объект obj типа T и возвращает код json в виде строки.
             * 
             * object Deserialize(string json, Type type, JsonSerializerOptions options): десериализует строку json
             * в объект типа type и возвращает десериализованный объект.
             * 
             * T Deserialize<T>(string json, JsonSerializerOptions options): десериализует строку json
             * в объект типа T и возвращает его.
             * 
             * Сериализуются только публичные свойства (public).
             */

            // опции сериализации
            JsonSerializerOptions options = new() { WriteIndented = true };

            User usr = new() { Username = "User", Password = "qwerty" };
            string json = JsonSerializer.Serialize<User>(usr, options);
            Console.WriteLine(json);

            User resUser = JsonSerializer.Deserialize<User>(json);
            Console.WriteLine($"Пользователь: {resUser.Username}, Пароль: {resUser.Password}");


            await AsyncJson();
        }

        static async Task AsyncJson()
        {
            // сохранение данных
            using (FileStream fs = new("user.json", FileMode.OpenOrCreate))
            {
                User usr = new() { Username = "Admin", Password = "ytrewq" };
                await JsonSerializer.SerializeAsync<User>(fs, usr);
            }

            // чтение данных
            using (FileStream fs = new("user.json", FileMode.OpenOrCreate))
            {
                User resUser = await JsonSerializer.DeserializeAsync<User>(fs);
                Console.WriteLine($"Пользователь: {resUser.Username}, Пароль: {resUser.Password}");
            }
        }

    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

/* Настройка сериализации с помощью JsonSerializerOptions
 * С помощью параметра типа JsonSerializerOptions можно настроить механизм сериализации/десериализации.
 * 
 * AllowTrailingCommas: надо ли добавлять после последнего элемента в json запятую.
 * 
 * IgnoreNullValues: будут ли сериализоваться объекты со значением null
 * 
 * IgnoreReadOnlyProperties: будут ли сериализоваться свойства только для чтения
 * 
 * WriteIndented: будут ли добавляться пробелы.
 */