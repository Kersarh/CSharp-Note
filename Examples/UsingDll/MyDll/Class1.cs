using System;

namespace MyDll
{
    public class Class1
    {
        public string username;
        public string Password;
        public int RoleId;

        public Class1(string user, string pwd)
        {
            username = user;
            Password = pwd;
        }

        public void Show()
        {
            Console.WriteLine($"{username} - {Password} - {RoleId}");
        }
    }
}
