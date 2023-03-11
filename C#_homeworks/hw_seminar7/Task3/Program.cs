/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] InitRandomArray(int rows, int columns)
{
    int[,] arrayRandom = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayRandom[i,j] = new Random().Next(99);
        }
    }
return arrayRandom;
}

//Подчеркивание номеров столбцов, аля таблица
void PrintLine(int count)
{
    for (int i = 0; i <= count; i++) Console.Write($"--\t");
        Console.WriteLine();
}

void PrintMatrix(int[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int columns = inputMatrix.GetLength(1);

    Console.Write("\t");
    //Вывод на экран номеров столбцов
    for (int i = 1; i <= columns; i++)
    {
         Console.Write($"{i}\t");
    }
    Console.WriteLine();
    PrintLine(columns);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{i+1}|\t"); //Вывод на экран номеров строк
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{inputMatrix[i,j]}\t");
        }
        Console.WriteLine();
    }
    PrintLine(columns);
}

// Печатает среднее арифметическое столбцов массива
void PrintAverage(int[,] inputArray)
{
    int numRows = inputArray.GetLength(0);
    int numColumns = inputArray.GetLength(1);
    
    for (int j = 0; j < numColumns; j++)
    {
        double sum = 0;
        for (int i = 0; i < numRows; i++) sum += inputArray[i,j]; //Сумма столбцов
        Console.Write($"\t{Math.Round(( sum / numRows), 2)}");    //Среднее арифметическое
    }
    Console.WriteLine();
}

int rows = 3;
int columns = 4;
int[,] matrix = InitRandomArray(rows, columns);
PrintMatrix(matrix);
PrintAverage(matrix);
