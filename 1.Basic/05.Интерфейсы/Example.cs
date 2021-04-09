using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Example
    {
        public void Method()
        {
            Authenticator aut = new();
            aut.User = new AdminUser();
            // Возможность передать разные классы реализующие интерфейс (upcast)
            // Все что не указано в интерфейсе получить модификатор private

            Authenticator aut2 = new();
            aut2.User = new DemoUser();

        }
    }

    // Зададим наш и интерфейс
    interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Display()
        {
            Console.WriteLine(Username);
        }

    }

    // Класс принимающий одним из полей наш интерфейс
    class Authenticator
    {
        public IUser User { get; set; }

        public void Print()
        {
            Console.WriteLine($"{User.Username} - {User.Password}");
        }
    }

    // Классы реализующие интерфейс
    class AdminUser : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    class DemoUser : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Time { get; set; }
    }
}
