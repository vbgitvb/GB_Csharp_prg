/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int i;
int maxCount = 3;
int [] numbers = new int[maxCount];
int max;

//Ввод 3-х чисел
for (i = 0; i < maxCount; i++)
{
    Console.Write("Введите " + (i + 1) + " число ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

max = numbers[0];

//Ищем максимум
for ( i = 0; i < maxCount; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine("Из введенных чисел - максимальное: " + max );

