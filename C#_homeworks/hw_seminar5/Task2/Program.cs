/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] GetRndFillArray(int len)
{
    int[] a = new int[len];

    for (int i = 0; i < len; i++)
    {
        a[i] = new Random().Next(10);
    }
    return a;
}
int GetSumNotEvenPos(int[] mas)
{   
    int len = mas.Length;
    int sum = 0;
    for (int i = 1;  i < len; i+=2)
    {
        sum += mas[i];
    }

return sum;
}

int size = 8;
int[] array = GetRndFillArray(size);
Console.WriteLine($"Rnd array = {String.Join(", ", array)}");
Console.WriteLine($"Сумма чисел на не чётных позициях = {GetSumNotEvenPos(array)}");
