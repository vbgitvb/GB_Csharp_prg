/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

int[,] matrix = InitRandomMatrix(4,4,1,9);
PrintMatrix(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой: {FindMinSum(matrix)}");

/// <summary>
/// Поск строки с наименьшей суммой в 2-мерном массиве
/// </summary>
/// <param name="inputMatrix">где ищем</param>
/// <returns>номер строки с мин суммой</returns>
int FindMinSum(int[,] inputMatrix)
{
    int numRow = inputMatrix.GetLength(0);
    int numCol = inputMatrix.GetLength(1);
    int minSumm = int.MaxValue;
    int minSummRow = 0;

    for (int i = 0; i < numRow; i++)
    {
        int nextSumm = 0;
        for (int j = 0; j < numCol; j++) nextSumm += inputMatrix[i,j];
        if(nextSumm < minSumm) 
        {
            minSumm = nextSumm;
            minSummRow = i;
        }
    }
return minSummRow+1;
}

/// <summary>
/// Создает двумерный массив и наполняет случайными числами.
/// Минимальное и максимальное значения указываются в аргументах метода.
/// </summary>
/// <param name="rows">Размер массива, количество строк</param>
/// <param name="columns">Размер массива, количество столбцов</param>
/// <param name="minValue">Заполнение массива, минимальное случайное число</param>
/// <param name="maxValue">Заполнение массива, максимальное случайное число</param>
/// <returns>двумерный массив, заполненный случайными числами</returns>
int[,] InitRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] randomMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomMatrix[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return randomMatrix;
}

/// <summary>
/// Вывод на экран через табуляцию 2-х символов -
/// </summary>
/// <param name="count">сколько раз отобразить</param>
void PrintLine(int count)
{
    for (int i = 0; i <= count; i++) Console.Write($"--\t");
        Console.WriteLine();
}

/// <summary>
/// печать в консоле элементы двумерного массива
/// </summary>
/// <param name="inputMatrix">выводить элементы из этого массива</param>
void PrintMatrix(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int columns = inputMatrix.GetLength(1);

    Console.Write("\t");
    //Вывод на экран номеров столбцов
    for (int i = 1; i <= columns; i++) Console.Write($"{i}\t");
    Console.WriteLine();
    PrintLine(columns);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{i+1}|\t"); //Вывод на экран номеров строк
        for (int j = 0; j < columns; j++) Console.Write($"{inputMatrix[i,j]}\t");
        Console.WriteLine();
    }
    PrintLine(columns);
    Console.WriteLine();
}
