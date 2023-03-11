/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrixA = InitRandomMatrix(3, 2, 1, 9);
int[,] matrixB = InitRandomMatrix(2, 2, 1, 9);

if(matrixA.GetLength(1) != matrixB.GetLength(0)) 
    {
        Console.WriteLine("Данные матрицы не перемножаются");
        return;
    }

PrintMatrix(matrixA);
PrintMatrix(matrixB);
Console.WriteLine("Результат умножения:");
PrintMatrix(MultiplyMatrix(matrixA, matrixB));


/// <summary>
/// Умножение двух матриц
/// </summary>
/// <param name="matrixA">первая матрица</param>
/// <param name="matrixB">вторая матрица</param>
/// <returns>результат перемножения</returns>
int[,] MultiplyMatrix(int[,] inputA, int[,] inputB)
{
    //mA[numRowAC, numRowColAC]
    //mb[numRowColAB, numColBC]
    //mC[numRowAC, numColBC]
    int numRowAC = inputA.GetLength(0);
    int numRowColAB = inputA.GetLength(1);
    int numColBC =  inputB.GetLength(1);
    int[,] result = new int[numRowAC, numColBC];

    for (int i = 0; i < numRowAC; i++)
    {
        for (int j = 0; j < numColBC; j++)
        {
            result[i,j] = 0;
            for (int k = 0; k < numRowColAB; k++)
            {
                result[i,j] = result[i,j] + inputA[i,k] * inputB[k,j];
            }
        }
    }
    return result;
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
