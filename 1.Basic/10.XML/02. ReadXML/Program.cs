using System;
using System.Linq;
using System.Xml.Linq;

namespace MyProgram
{
    internal class Program
    {
        private static void Main()
        {
            ShortCreateXML();  // Создадим файл XML для дальнейшей работы

            ReadXML(); // читаем файл XML и выводим в консоль

            ReadXMtoLINQL(); // поиск по файлу при помощи LINQ запроса
        }

        private static void ShortCreateXML()
        {
            XDocument xdoc = new(
            new XElement("Users",
                new XElement("user",
                    new XAttribute("name", "Alise"),
                    new XElement("Authorization",
                        new XElement("Login", "Alise_login"),
                        new XElement("Password", "qwerty")),
                    new XElement("ID", "1")),
                new XElement("user",
                    new XAttribute("name", "Bob"),
                    new XElement("Authorization",
                        new XElement("Login", "Bob_login"),
                        new XElement("Password", "asdfg")),
                    new XElement("ID", "2"))));
            xdoc.Save("Users.xml");
        }

        private static void ReadXML()
        {
            XElement password = null;
            XElement login = null;
            XDocument xdoc = XDocument.Load("Users.xml"); // Загружаем наш файл
            foreach (XElement firstRunElem in xdoc.Element("Users").Elements("user"))
            {
                XAttribute attribName = firstRunElem.Attribute("name"); // вложенный в user
                XElement authElem = firstRunElem.Element("Authorization");

                if (authElem != null) // Проверка что есть значение
                {
                    login = authElem.Element("Login"); // вложенный в Authorization
                    password = authElem.Element("Password");
                }
                XElement idElem = firstRunElem.Element("ID");

                // Выведем в консоль
                Console.WriteLine($"User: {attribName.Value}");
                Console.WriteLine($"Login: {login.Value}");
                Console.WriteLine($"Password: {password.Value}");
                Console.WriteLine($"ID: {idElem.Value}");
            }
        }

        private static void ReadXMtoLINQL()
        {
            Console.WriteLine($"Search \"Alise_login\"...");

            XDocument xdoc = XDocument.Load("Users.xml");
            // формируем запрос LINQ
            var items = from xe in xdoc.Element("Users").Elements("user")
                        where xe.Element("Authorization").Element("Login").Value == "Alise_login"
                        select new User
                        {
                            Login = xe.Element("Authorization").Element("Login").Value,
                            Password = xe.Element("Authorization").Element("Password").Value
                        };

            foreach (var item in items)
            {
                Console.WriteLine($"Login: {item.Login} - Password: {item.Password}");
            }
        }
    }

    internal class User // Для удобного хранения данных
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}