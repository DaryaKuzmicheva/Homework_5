/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    {
    array[i] = rand.Next(100, 1000);
    }
Console.WriteLine(string.Join(", " , array));
int quantity = 0;
 for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) quantity++;
    }
 Console.WriteLine(quantity);

