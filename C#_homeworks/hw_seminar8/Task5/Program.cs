/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] map = new int[4,4];

GoAround(map);
PrintMatrix(map);


/// <summary>
/// Заполняет по кругу к центру массив
/// </summary>
/// <param name="inputMap">массив для заполнения</param>
void GoAround(int[,] inputMap)
{
    int numRows = inputMap.GetLength(0);
    int numCounts = inputMap.GetLength(1);
    int startI = 0;     //начало движения с 0,0
    int endI = numRows;
    int startJ = 0;
    int endJ = numCounts;
    int fill = 1;
    int i = startI;
    int j = startJ;
    
    while (fill<= numRows * numCounts)
    {
        i = startI;
        //вправо
        for ( j = startJ; j < endJ; j++) inputMap[i,j] = fill++;
        startI++; j--;
        if(startI == endI) return;
    
        //вниз
        for ( i = startI; i < endI; i++) inputMap[i,j] = fill++;
        endJ--; i--;
        if(startJ == endJ) return;
    
        //влево
        for ( j = endJ-1; j >= startJ; j--) inputMap[i,j] = fill++;
        endI--; j++;
        if(startI == endI) return;
    
        //вверх
        for ( i = endI-1; i >= startI; i--) inputMap[i,j] = fill++;
        startJ++;
        if(startI == endI) return;
    }
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
