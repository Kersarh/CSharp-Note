using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Индексаторы позволяют индексировать объекты и обращаться к данным по индексу.
            * C помощью индексаторов мы можем работать с объектами как с массивами.
            * В отличие от свойств индексатор не имеет названия, 
            * вместо него указывается ключевое слово this,
            * после которого в квадратных скобках идут параметры.
            * Индексатор должен иметь как минимум один параметр.
            */

            User usr = new User();
            usr["name"] = "admin";
            usr["email"] = "1@2.ru";

            Console.WriteLine(usr["name"]); // admin
        }
    }

    class User
    {
        string name;
        string email;
        string phone;

        // индексатор
        public string this[string indexname]
        {
            get
            {
                switch (indexname)
                {
                    case "name": return name;
                    case "email": return email;
                    case "phone": return phone;
                    default: return null;
                }
            }
            set
            {
                switch (indexname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }

    }
}