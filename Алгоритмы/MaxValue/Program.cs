using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 45, 77, 45, 99, 105, 3, 1, 7, 8, 2 };
            int max = data[0]; // Начальное значение
            int max_index = 0; // индекс макс элемента
            for (int i = 1; i < data.Length; i++)
                if (data[i] > max) // Если число больше текущего max
                {
                    max = data[i]; // присвоим его в max
                    max_index = i; // и сохраним его индекс
                }
            Console.WriteLine($"Максимальное число: {max}, его индекс в массиве: {max_index}");
        }
    }
}
