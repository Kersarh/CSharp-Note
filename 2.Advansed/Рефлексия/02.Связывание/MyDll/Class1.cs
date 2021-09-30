using System;

namespace MyDll
{
    public class Class1
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Class1()
        {
            Name = "user";
            Password = "qwerty";
        }

        public string SendLoginPassword(string sep)
        {
            return Name + sep + Password;
        }

        static void MyStaticMethod()
        {
            Console.WriteLine("MyStaticMethod");
        } 
    }
}
