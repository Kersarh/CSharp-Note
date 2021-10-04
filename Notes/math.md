Для выполнения различных математических операций существует класс **Math**. 

- `Abs(double value)`: возвращает абсолютное значение для аргумента value

  ```c#
  double result = Math.Abs(-10.5); // 10.5
  ```

- `Acos(double value)`: возвращает арккосинус. value должен иметь значение от -1 до 1

  ```c#
  double result = Math.Acos(1); // 0
  ```

- `Asin(double value)`: возвращает арксинус. value должен иметь значение от -1 до 1

- `Atan(double value)`: возвращает арктангенс.

- `BigMul(int x, int y)`: возвращает произведение x * y в виде объекта long

  ```c#
  double result = Math.BigMul(100, 9340);// 934000
  ```

- `Ceiling(double value)`: возвращает наименьшее целое число с плавающей точкой, которое не меньше value

  ```c#
  double result = Math.Ceiling(2.34); // 3
  ```

- `Cos(double d)`: возвращает косинус угла d

- `Cosh(double d)`: возвращает гиперболический косинус угла d

- `DivRem(int a, int b, out int result)`: возвращает результат от деления a/b, а остаток помещается в параметр result

  ```c#
  int result;
  int div = Math.DivRem(14, 5, out result);
  ```
```
  
- `Exp(double d)`: возвращает основание натурального логарифма, возведенное в степень d

- `Floor(decimal d)`: возвращает наибольшее целое число, которое не больше d

  ```c#
  double result = Math.Floor(2.56);// 2
```

- `IEEERemainder(double a, double b)`: возвращает остаток от деления a на b

  ```c#
  double` `result = Math.IEEERemainder(26, 4); ``// 2 = 26-24
  ```

- `Log(double d)`: возвращает натуральный логарифм числа d

- `Log(double a, double newBase)`: возвращает логарифм числа a по основанию newBase

- `Log10(double d)`: возвращает десятичный логарифм числа d

- `Max(double a, double b)`: возвращает максимальное число из a и b

- `Min(double a, double b)`: возвращает минимальное число из a и b

- `Pow(double a, double b)`: возвращает число a, возведенное в степень b

- `Round(double d)`: возвращает число d, округленное до ближайшего целого числа

  ```c#
  double result1 = Math.Round(20.56);// 21
  double result2 = Math.Round(20.46); //20
  ```

- `Round(double a, round b)`: возвращает число a, округленное до определенного количества знаков после запятой, представленного параметром b

  ```c#
  double result1 = Math.Round(20.567, 2);// 20,57
  double result2 = Math.Round(20.463, 1);//20,5
  ```

- `Sign(double value)`: возвращает число 1, если число value положительное, и -1, если значение value отрицательное. Если value равно 0, то возвращает 0

  ```c#
  int result1 = Math.Sign(15); // 1
  int result2 = Math.Sign(-5);  //-1
  ```

- `Sin(double value)`: возвращает синус угла value

- `Sinh(double value)`: возвращает гиперболический синус угла value

- `Sqrt(double value)`: возвращает квадратный корень числа value

  ```c#
  double result1 = Math.Sqrt(16); // 4
  ```

- `Tan(double value)`: возвращает тангенс угла value

- `Tanh(double value)`: возвращает гиперболический тангенс угла value

- `Truncate(double value)`: отбрасывает дробную часть числа value, возвращая лишь целое значение

  ```c#
  double result = Math.Truncate(16.89); // 16
  ```

Также класс Math определяет две константы: `Math.E` и `Math.PI`. Например, вычислим площадь круга:

```c#
Console.WriteLine(``"Введите радиус круга"``);
double radius = Double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);
```