using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 8, 1, 8, 5, 1, 7, 1, 09, 2, 0, 45, 67};
            int r = SearchSimple(a, 0);
            Console.WriteLine(r);
        }

        static int SearchSimple(int[] a, int x)
        {
            int Len = a.Length;
            int i = 0;
            // Пока a[i] не равно искомому x, или i меньше длинны массива
            while (a[i] != x && i < Len) 
            {
                i++;
            }

            if (i < Len)
                // если элемент найден, возвращаем его индекс
                return i;
            else
                // если элемент не найден, возвращаем -1 
                return -1;
        }
    }
}
