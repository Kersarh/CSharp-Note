using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Особенность абстрактных классов в том,что их можно
            * использовать только как родительский класс (не возможно создать экземпляр класса)
            * Для объявления используется ключевое слово abstract.
            * 
            * Абстрактные классы могут быть полезны чтобы объединить реализацию схожих классов.
            * Например Вы пишите программы в которой работают как пользователи так и сотрудники фирмы.
            * Пусть страницы входа для пользователя и сотрудника различны.
            * Но у них есть и общие данные: логин, пароль и должны пройти авторизацию.
            * Чтобы не писать все это для каждого типа пользователей можно
            * вынести схожие черты абстрактный класс,
            * от которого будут наследоваться и пользователи и сотрудники.
            */

            //Person pers = new(); // ошибка

            Moder mod = new();
            mod.login = "Moder"; // зададим логин
            mod.password = "qwerty"; // и пароль
            mod.Welcome();

            User usr = new();
            usr.login = "User";
            usr.password = "123";
            usr.Welcome(); // Доступ запрещен!

            /* Несмотря на очень упрощенную реализацию 
            * часть общей логики мы вынесли в класс Person
            * от которого наследуются как user так и moder.
            */

        }
    }

    public abstract class Person
    {
        public string login;
        public string password;

        public bool Authorization()
        {
            if (password == "qwerty") // qwerty в нашем случае правильный пароль ))
            {
                Console.WriteLine("Авторизация успешна");
                return true;
            }

            Console.WriteLine("Доступ запрещен!");
            return false;
        }
    }

    public class Moder : Person
    {
        public string Login { get; set; }
        public void Welcome()
        {
            if (Authorization())
            {
                Console.WriteLine($"{Login} Ваша роль модератор");
            }
        }
    }

    public class User : Person
    {
        public void Welcome()
        {
            if (Authorization())
            {
                Console.WriteLine($"{login} Ваша роль пользователь");
            }
        }
    }
}
