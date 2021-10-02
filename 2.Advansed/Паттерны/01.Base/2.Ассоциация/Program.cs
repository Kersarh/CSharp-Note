using System;

namespace MyProgram
{
    //Ассоциация - отношение при котором объекты одного типа связаны с объектами другого типа.
    // Например когда объект одного типа содержит объект другого типа.
    internal class Program
    {
        private static void Main(string[] args)
        {
            People pl = new();
            pl.Sity = new Sity() { SityName = "Moscow" };
            Console.WriteLine(pl.Sity.SityName);
        }
    }

    internal class Sity // Например мы имеем город
    {
        public string SityName { get; set; }
    }

    internal class People // и человека который находится в городе
    {
        public Sity Sity { get; set; }
    }
}