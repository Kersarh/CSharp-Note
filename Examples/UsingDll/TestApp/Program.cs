using System;
using MyDll;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 user = new("admin", "qwerty") {RoleId = 10 };
            user.Show();
        }
    }
}
