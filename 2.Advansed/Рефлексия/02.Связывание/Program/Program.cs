using System;
using System.Reflection;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Загружаем нашу DLL
            Assembly asm = Assembly.LoadFrom("MyDll.dll");
            Console.WriteLine(asm.FullName);

            Type[] types = asm.GetTypes();
            foreach (Type t1 in types)
            {
                Console.WriteLine(t1.Name);
            }


            // Позднее связывание

            Type t = asm.GetType("MyDll.Class1", true, true);

            // создаем экземпляр класса MyDll.Class1
            object obj = Activator.CreateInstance(t);

            // получаем метод SendLoginPassword
            MethodInfo method = t.GetMethod("SendLoginPassword");

            // вызываем метод с параметрами
            object result = method.Invoke(obj, new object[] { " - " }); // method.Invoke(obj, null) -  если нет параметров
            Console.WriteLine(result);

        }
    }
}
