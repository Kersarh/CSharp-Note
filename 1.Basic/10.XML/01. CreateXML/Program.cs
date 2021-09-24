using System.Xml.Linq;

namespace MyProgram
{
    // System.Xml.Linq.Рассмотрим основные классы этого пространства имен:
    // XDocument: весь xml-документ
    // XElement: отдельный xml-элемент
    // XAttribute: атрибут xml-элемента
    // XComment: комментарий

    // Add(): добавляет новый атрибут или элемент
    // Attributes(): возвращает атрибуты текущего элемента
    // Elements(): возвращает дочерние элементы
    // Remove(): удаляет элемент
    // RemoveAll(): удаляет дочерние элементы и атрибуты

    class Program 
    { 
        static void Main()
        {
            CreateXML();
            //ShortCreateXML();  // Более краткая запись
        }

        private static void CreateXML()
        {
            XDocument xmldoc = new();
            // создаем корневой элемент
            XElement myXml = new("Users");

            // создаем первый элемент
            XElement user = new("user");
            // с атрибутом
            XAttribute userNameAttr = new("name", "Alise");
            // еще один уровень вложенности
            XElement userAuth = new("Authorization");
            XElement userLogin = new("Login", "Alise");
            XElement userPassword = new("Password", "qwerty");
            
            XElement userId = new("ID", "1");
            // добавляем атрибуты и элементы
            user.Add(userNameAttr); // вложенные в user
            user.Add(userAuth);
            userAuth.Add(userLogin); // вложенные в userAuth
            userAuth.Add(userPassword);
            user.Add(userId);

            // создаем второй элемент
            XElement user2 = new("User_2");
            XAttribute user2NameAttr = new("name", "Bob");
            XElement user2Password = new("Password", "1234g");
            XElement user2Id = new("ID", "2");
            user2.Add(user2NameAttr);
            user2.Add(user2Password);
            user2.Add(user2Id);

            // добавляем в корневой элемент
            myXml.Add(user);
            myXml.Add(user2);

            // добавляем корневой элемент в документ
            xmldoc.Add(myXml);
            //сохраняем документ
            xmldoc.Save("Users.xml");

            // Открываем наш файл в блокноте
            System.Diagnostics.Process.Start("notepad.exe", "Users.xml");
        }

        private static void ShortCreateXML()
        {
            // Более краткая запись
            XDocument xdoc = new(
            new XElement("Users",
                new XElement("Users",
                    new XAttribute("name", "Alise"),
                    new XElement("Authorization",
                    new XElement("Login", "Alise"),
                    new XElement("Password", "qwerty")),
                    new XElement("ID", "1")),
                new XElement("User_2",
                    new XAttribute("name", "Bob"),
                    new XElement("Password", "1234g"),
                    new XElement("ID", "2"))));
            xdoc.Save("Users.xml");
            // Открываем наш файл в блокноте
            System.Diagnostics.Process.Start("notepad.exe", "Users.xml");
        }
    }
}
