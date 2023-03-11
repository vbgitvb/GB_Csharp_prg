/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] GetRndFillArray(int len)
{
    int[] a = new int[len];

    for (int i = 0; i < len; i++)
    {
        a[i] = new Random().Next(100, 1000);
    }
    return a;
}


int size = 8;
int countEven = 0;
int[] array = GetRndFillArray(size);
Console.WriteLine($"Rnd array = {String.Join(", ", array)}");

for (int i = 0; i < size; i++) if(array[i]%2 == 0) countEven++;
Console.WriteLine($"Кол-во чётных чисел = {countEven}");
