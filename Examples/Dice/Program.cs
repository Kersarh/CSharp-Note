using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бесконечно запрашиваем набор данных пока не будет введена пустая строка
            while (true)
            {
                Console.WriteLine("Набор:");
                string data = Console.ReadLine();
                if (data == "")
                {
                    return;
                }
                int res = Round(data);
                Console.WriteLine(res);
            }
        }

        /// <summary>
        /// Криптографически стойкая генерация случайного числа.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static int GetRandomNum(int minValue, int maxValue)
        {
            System.Security.Cryptography.RNGCryptoServiceProvider rnd = new System.Security.Cryptography.RNGCryptoServiceProvider();

            //Получаем наш случайный байт
            byte[] randombyte = new byte[1];
            rnd.GetBytes(randombyte);
            //превращаем его в число от 0 до 1
            double random_multiplyer = (randombyte[0] / 255d);
            //получаем разницу между минимальным и максимальным значением 
            int difference = maxValue - minValue + 1;
            //прибавляем к минимальному значение число от 0 до difference
            int result = (int)(minValue + Math.Floor(random_multiplyer * difference));
            return result;
        }

        /// <summary>
        /// Определяет результат броска однотипных костей
        /// Пример: 2d6
        /// </summary>
        /// <param name="in_data"></param>
        /// <returns></returns>
        static int Dise(string in_data)
        {
            string[] data = in_data.Split("d");
            int summ = 0;
            for (int i = 0; i < Convert.ToInt32(data[0]); i++)
            {
                int num = GetRandomNum(1, Convert.ToInt32(data[1]));
                summ += num;
            }
            return summ;
        }

        /// <summary>
        /// Принимает набор костей для броска
        /// Например: 2d6 1d3
        /// </summary>
        /// <param name="in_data"></param>
        /// <returns></returns>
        static int Round(string in_data)
        {
            int summ = 0;
            string[] data = in_data.Split(" ");

            foreach (string i in data)
            {
                summ += Dise(i);
            }
            return summ;
        }
    }
}
