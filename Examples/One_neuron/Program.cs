using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Данные для обучения
            double km = 100;
            double mil = 62.1371;

            // Инициализируем нейрон
            Neuron nr = new();

            // Обучение 
            while (true){
                if (Math.Round(nr.lasterror, 4) != nr.smoothing) // 
                {
                    nr.Train(km, mil);
                    Console.WriteLine($"Ошибка:{nr.lasterror}");
                }
                else
                {
                    Console.WriteLine($"Обучение завершено!");
                    break;
                }
            }

            // Использование обученного нейрона
            Console.WriteLine($"1км = {nr.Neur(1)}");
            Console.WriteLine($"10км = {nr.Neur(10)}");
            Console.WriteLine($"45км = {nr.Neur(45)}");
            Console.WriteLine($"85км = {nr.Neur(85)}");
            // обратное преобразование
            Console.WriteLine($"10ml = {nr.Reverse_neur(10)}");
        }
    }

    public class Neuron
    {
        public double weight = 0.5; // Вес
        public double smoothing = 0.0001; // Величина корректировки
        public double lasterror = 0; // Последняя ошибка

        // Нейрон
        public double Neur(double data) => data * weight;

        // Обратная обработка
        public double Reverse_neur(double data) => data / weight;

        // Обучение
        public void Train(double indata, double truedata)
        {
            // Текущий результат
            double actual_result = Neur(indata);

            // Расчет ошибки
            lasterror = truedata - actual_result;

            // Корректировка (изменение веса)
            weight += (lasterror / actual_result) * smoothing;
        }

    }
}
