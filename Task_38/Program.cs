/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.NextDouble() * 10;
Console.WriteLine($"Массив: {string.Join(", " , array)}");
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Минимальное значение:{min}");
Console.WriteLine($"Максимальное значение:{max}");
Console.WriteLine($"Разница:{max - min}");
