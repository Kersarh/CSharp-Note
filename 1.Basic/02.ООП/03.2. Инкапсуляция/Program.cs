using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Инкапсуляция — это связывание код и данные в оболочку, и сохраняет их в безопасности
            * как от изменения извне так и от ошибочного использования.
            * В ООП в роли оболочки выступают классы:
            * они собирают данные и методы в одном месте,
            * а также защищают их от изменения извне(сокрытие).
            * 
            * Сокрытие является элементом инкапсуляции и обеспечивает
            * ограничение доступа к данным и методам,
            * что делает некоторые компоненты доступными только внутри класса.
            */

            PublicClass obj = new();

            // obj.myVar = 1; // Ошибка private
            // obj.privateVar = 1; // Ошибка private
            // obj.protectedPrivateVar = 5; // Ошибка protected private
            // obj.protectedVar = 1; // Ошибка protected

            obj.internalVar = 1;
            obj.protectedInternalVar = 1;
            obj.publicVar = 5;

            // ограничения аналогичны полям класса
            obj.internalMethod();
            obj.protectedInternalMethod();
            obj.publicMethod();


            // --- Static --- 
            //Статические поля, методы, свойства относятся ко всему классу
            // для обращения к ним необязательно создавать экземпляр класса.
            int i = MyStatic.i; // Также будет вызван статический конструктор если есть
            Console.WriteLine(i);
            MyStatic.Fun();

        }
    }

    public class PublicClass
    {
        // по умолчанию модификатор private
        int myVar;

        // доступен в текущем классе
        private int privateVar;

        // доступно в текущем классе и производных классах, в этом же проекте
        protected private int protectedPrivateVar;

        // доступно из текущего класса и производных
        protected int protectedVar;

        // доступно в любом месте текущего проекта
        internal int internalVar;

        // доступно в любом месте текущего проекта и в классах-наследниках в том числе в других проектах
        protected internal int protectedInternalVar;

        // доступно в любом месте, а также для других программ и сборок
        public int publicVar;

        // ------------------------------------

        // по умолчанию модификатор private
        void defaultMethod() => Console.WriteLine($"defaultVar = {myVar}");

        // доступен в текущем классе
        private void privateMethod() => Console.WriteLine($"privateVar = {privateVar}");

        // доступен в текущем классе и производных классах, в этом же проекте
        protected private void protectedPrivateMethod() => Console.WriteLine($"protectedPrivateVar = {protectedPrivateVar}");

        // доступен в текущем классе и производных классах
        protected void protectedMethod() => Console.WriteLine($"protectedVar = {protectedVar}");

        // доступен в любом месте текущего проекта
        internal void internalMethod() => Console.WriteLine($"internalVar = {internalVar}");

        // доступен в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal void protectedInternalMethod() => Console.WriteLine($"protectedInternalVar = {protectedInternalVar}");

        // доступен в любом месте, а также для других программах и сбороках
        public void publicMethod() => Console.WriteLine($"publicVar = {publicVar}");

    }

    // Статические классы могут содержать только статические поля, свойства и методы.
    class MyStatic
    {
        public static int i;

        static MyStatic()
        {
            Console.WriteLine("Статический конструктор");
            i=55;
        }

        // Статические методы могут обращаться только к статическим членам класса.
        public static void Fun()
        {
            Console.WriteLine("Статический метод");
        }
    }
}
