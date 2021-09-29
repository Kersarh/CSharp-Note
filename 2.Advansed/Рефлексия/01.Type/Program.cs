using System;
using System.Reflection;

namespace MyProgram
{
    // Рефлексия (отражение) — процесс, во время которого программа может отслеживать и модифицировать
    // собственную структуру и поведение во время выполнения.

    class Program
    {
        static void Main()
        {
            // Получение типа через typeof()
            Type myType1 = typeof(User);
            Console.WriteLine(myType1.ToString());

            // Получение типа через .GetType()
            User user = new("admin", "password");
            Type myType2 = user.GetType();
            Console.WriteLine(myType2.ToString());

            Type myType3 = Type.GetType("MyProgram.User", false, true);
            //Type myType = Type.GetType("MyProgram.User, MyLibrary", false, true); // Если в другом проекте
            Console.WriteLine(myType3.ToString());
            // Первый параметр - полное имя класса.
            // Второй параметр генерировать исключение, если класс не найден.
            // Третий параметр адо ли учитывать регистр символов в первом параметре.Значение true означает, что регистр игнорируется.

            // Таким образом мы получим ссылку на объект Type, содержащий информацию о целевом типе

            // Получаем информацию об обьекте
            foreach (MemberInfo mi in myType3.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Console.WriteLine("-------------------------------------");

            foreach (MethodInfo method in myType3.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
                //получаем все параметры
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }


        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public User(string name, string pwd)
        {
            Name = name;
            Password = pwd;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Пароль: {Password}");
        }

        static public void DisplayStaticMethod()
        {
            Console.WriteLine("Static method");
        }

    }
}


//System.Type.
//Класс System.Type представляет изучаемый тип, инкапсулируя всю информацию о нем.С помощью его свойств и методов можно получить эту информацию. Некоторые из его свойств и методов:
//Метод FindMembers() возвращает массив объектов MemberInfo данного типа
//Метод GetConstructors() возвращает все конструкторы данного типа в виде набора объектов ConstructorInfo
//Метод GetEvents() возвращает все события данного типа в виде массива объектов EventInfo
//Метод GetFields() возвращает все поля данного типа в виде массива объектов FieldInfo
//Метод GetInterfaces() получает все реализуемые данным типом интерфейсы в виде массива объектов Type
//Метод GetMembers() возвращает все члены типа в виде массива объектов MemberInfo
//Метод GetMethods() получает все методы типа в виде массива объектов MethodInfo
//Метод GetProperties() получает все свойства в виде массива объектов PropertyInfo
//Свойство Name возвращает имя типа
//Свойство Assembly возвращает название сборки, где определен тип
//Свойство Namespace возвращает название пространства имен, где определен тип
//Свойство IsArray возвращает true, если тип является массивом
//Свойство IsClass возвращает true, если тип представляет класс
//Свойство IsEnum возвращает true, если тип является перечислением
//Свойство IsInterface возвращает true, если тип представляет интерфейс


//GetMethods()
//DeclaredOnly: получает только методы непосредственно данного класса, унаследованные методы не извлекаются
//Instance: получает только методы экземпляра
//NonPublic: извлекает не публичные методы
//Public: получает только публичные методы
//Static: получает только статические методы