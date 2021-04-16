Обычная DLL (C type)
```csharp
namespace ConsoleApplication1
{
    using System;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            var DLL = Assembly.LoadFile(@"MyDLL.dll");
    
            foreach(Type type in DLL.GetExportedTypes())
            {
                var c = Activator.CreateInstance(type);
                type.InvokeMember("Output", BindingFlags.InvokeMethod, null, c, new object[] {@"Hello"});
            }
    
            Console.ReadLine();
        }
    }
}
```

.net dll
```csharp
namespace ConsoleApplication1
{
    using System;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            var DLL = Assembly.LoadFile(@"MyDLL.dll");
    
            foreach(Type type in DLL.GetExportedTypes())
            {
                dynamic c = Activator.CreateInstance(type);
                c.Output(@"Hello");
            }
            Console.ReadLine();
        }
    }
}
```

или
```csharp
class Program
{
    static void Main(string[] args)
    {
        var DLL = Assembly.LoadFile(@"MyDLL.dll");
        var theType = DLL.GetType("DLL.Class1");
        var c = Activator.CreateInstance(theType);
        var method = theType.GetMethod("Output");
        method.Invoke(c, new object[]{@"Hello"});
        Console.ReadLine();
    }
}
```

код dll в .net
```csharp
namespace DLL
{
    using System;

    public class Class1
    {
        public void Output(string s)
        {
            Console.WriteLine(s);
        }
    }
}
```