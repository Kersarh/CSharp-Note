using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class MyAsyncStream
    {
        public async Task MyMethod()
        {
            // для получения данных будем использовать await foreach
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }
        }

        // Создадим простейший асинхронный стрим
        // Каждую секунду мы будем возвращать число.
        public async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }



    }
}
