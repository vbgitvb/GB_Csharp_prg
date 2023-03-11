/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] matrix = InitRandomMatrix(3,4,1,9);
PrintMatrix(matrix);
SortLineMatrixMaxMin(matrix);
PrintMatrix(matrix);

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

/// <summary>
/// Выполняет сортировку элементов массива в строке от Мах до Мин
/// </summary>
/// <param name="inputArray">массив для сортировки</param>
void SortLineMatrixMaxMin(int[,] inputArray)
{
    int countRows = inputArray.GetLength(0);
    int countColumns = inputArray.GetLength(1);
    int maxIndex = 0;
    int tmpValue = 0;
    
    for (int row = 0; row < countRows; row++)
    {
        if(countColumns >= 1)
        {
            for (int i = 0; i < countColumns-1; i++)
            {
                maxIndex = i;
                for (int j = i+1; j < countColumns; j++)
                {
                    if(inputArray[row,maxIndex] < inputArray[row,j])
                    {
                        maxIndex = j;
                    }
                }
                tmpValue = inputArray[row,i];
                inputArray[row,i] = inputArray[row,maxIndex];
                inputArray[row,maxIndex] = tmpValue;
            }
        }
    }
}
