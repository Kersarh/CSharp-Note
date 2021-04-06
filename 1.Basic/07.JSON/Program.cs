using System;
using System.Text.Json;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
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
             */

            User usr = new() { Username = "User", Password = "qwerty" };
            string json = JsonSerializer.Serialize<User>(usr);
            Console.WriteLine(json);

            User resUser = JsonSerializer.Deserialize<User>(json);
            Console.WriteLine($"Пользователь: {resUser.Username}, Пароль: {resUser.Password}");

        }
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
