using System.Linq;
using System.Xml.Linq;

namespace MyProgram
{
    internal class Program
    {
        private static void Main()
        {
            ShortCreateXML();

            XDocument xdoc = XDocument.Load("Users.xml");

            XElement firstRunElem = xdoc.Element("Users");

            foreach (XElement xe in firstRunElem.Elements("user").ToList())
            {
                // Если user имеет атрибут name = Alise меняем пароль
                if (xe.Attribute("name").Value == "Alise")
                {
                    xe.Element("Authorization").Element("Password").Value = "New_Password";
                }
            }

            // добавляем новый элемент
            firstRunElem.Add(new XElement("user",
                        new XAttribute("name", "Admin"),
                    new XElement("Authorization",
                        new XElement("Login", "admin_login"),
                        new XElement("Password", "zxcvbn")),
                    new XElement("ID", "0")));

            // Сохраняем изменения в файле
            xdoc.Save("Users.xml");

            System.Diagnostics.Process.Start("notepad.exe", "Users.xml");
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
    }
}