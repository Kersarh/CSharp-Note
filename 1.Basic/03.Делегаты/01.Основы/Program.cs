using System;

namespace MyProgram
{
    class Program
    {
        public delegate void MyDelegate(string data); // Создадим делегат

        static void Main(string[] args)
        {
            /* Делегат — это тип, который представляет ссылки на методы
             * с определенным списком параметров и типом возвращаемого значения.
             * При создании экземпляра делегата этот экземпляр можно связать
             * с любым методом с совместимой сигнатурой и типом возвращаемого значения.
             * Метод можно вызвать с помощью экземпляра делегата.
             * 
             * Наиболее сильная сторона делегатов состоит в том,
             * что они позволяют делегировать выполнение некоторому коду извне.
             * На момент написания программы мы можем не знать, что это будет за код.
             */

            // Теперь экземпляр делегата handler указывает на метод Message1
            MyDelegate handler = Message1;
            handler("Hello World!!!");

            // Передача делегата в виде параметра
            Method("Новые данные", handler);


            Myclass obj = new();
            // Передаем делегату ссылку на метод
            // реализующий сигнатуру делегата
            // а делегат передается в качестве параметра методу RegHandler
            obj.RegHandler(new Myclass.MyHandler(Method2));
            obj.RegHandler(new Myclass.MyHandler(Method3));

            obj.DataMethod();

        }

        public static void Message1(string a)
        {
            Console.WriteLine(a);
        }

        public static void Method(string param1, MyDelegate callback)
        {
            callback("Method: " + (param1).ToString());
        }


        public static void Method2(string s)
        {
            Console.WriteLine($"Ура, {s}");
        }

        public static void Method3(string s)
        {
            Console.WriteLine($"А еще делегат указывает сюда!!!");
        }
    }

    public class Myclass
    {
        // Объявляем делегат
        public delegate void MyHandler(string message);
        MyHandler hndl1;

        // Регистрируем делегат
        public void RegHandler(MyHandler hnd)
        {
            hndl1 += hnd; // делегат может вызывать сразу несколько методов
        }

        public void DataMethod()
        {
            // Теперь при вызове метода мы проверяем имеет делегат ссылку
            // на метод (иначе он null).
            // Если метод установлен то вызываем его.
            if (hndl1 != null)
            {
                hndl1($"данные переданные через MyHandler!");
            }
            else
            {
                Console.WriteLine("Нет MyHandler");
            }
        }


    }


}
