using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Класс ObservableCollection похож на список (List)
             * за исключением того что выдает уведомления при
             * добавлении и удалении, а также при обновлении элементов коллекции.
             * ObservableCollection определяет событие CollectionChanged 
             * подписавшись на которое, мы можем обработать любые изменения коллекции.
             */

            // Создаем коллекцию
            ObservableCollection<int> mydata = new() { 1, 2, 3, 4, 5 };

            // Подписываем обработчик события
            mydata.CollectionChanged += Collect_handler;

            mydata.Add(6);
            mydata.RemoveAt(1);
            mydata[0] = 10;

            foreach (int num in mydata)
            {
                Console.WriteLine(num);
            }

            Console.Read();

        }

        /* Collect_handler обработчик события для CollectionChanged.
        * Своим аргументом принимает NotifyCollectionChangedAction e,
        * который используется для получения подробной информации о событии.
        * Его свойство Action позволяет узнать какое именно событие произошло,
        * возвращая его как NotifyCollectionChangedAction.тип_события
        */
        private static void Collect_handler(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // добавление
                    Console.WriteLine($"Add: {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove: // удаление
                    Console.WriteLine($"Remove: {e.OldItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Replace: // замена
                    Console.WriteLine($"Replace: {e.OldItems[0]} на {e.NewItems[0]}");
                    break;
            }
        }
    }
}
