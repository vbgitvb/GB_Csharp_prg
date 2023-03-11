/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
Используйте NextDouble().
*/

double[] GetRndFillArray(int len)
{
    double[] a = new double[len];

    for (int i = 0; i < len; i++)
    {
        a[i] = Math.Truncate(new Random().NextDouble()*100);
    }
    return a;
}
int[] FindIndexMaxMin(double[] mas)
{   
    int len = mas.Length;
    int indexMax = 0;
    int indexMin = 0;
//arrayMaxMin[0] = max, arrayMaxMin[1] = min
    int[] arrayMaxMin = new int[2];
    for (int i = 0;  i < len; i++)
    {
     if (mas[i] < mas[indexMin])  indexMin = i;
     else if(mas[i] > mas[indexMax])  indexMax = i;
    }
arrayMaxMin[0] = indexMax;
arrayMaxMin[1] = indexMin;
return arrayMaxMin;
}

int size = 8;
double[] array = GetRndFillArray(size);
int[] MaxMin = FindIndexMaxMin(array);
Console.WriteLine($"Rnd array = {String.Join(", ", array)}");
Console.WriteLine($"Max = {array[MaxMin[0]]} Min = {array[MaxMin[1]]}");
Console.WriteLine($"Разница между Max и Min = {array[MaxMin[0]] - array[MaxMin[1]]}");
