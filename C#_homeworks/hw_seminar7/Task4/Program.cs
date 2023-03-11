/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/
int[,] InitRandomArray(int rows, int columns, int min, int max)
{
    int[,] arrayRandom = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayRandom[i,j] = new Random().Next(min, max+1);
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
}

int SumDiagonal(int[,] inputArray)
{
    int numRows = inputArray.GetLength(0);
    int numColumns = inputArray.GetLength(1);
    int sum = 0;
    int count = numRows;
    if (numColumns < numRows) count = numColumns;
    for (int i = 0; i < count; i++) sum += inputArray[i,i]; //Сумма диагонали

return sum;
}



int rows = 3;
int columns = 4;
int[,] matrix = InitRandomArray(rows, columns, 0, 99);
PrintMatrix(matrix);
Console.WriteLine($"Сумма элементов главной диагонали = {SumDiagonal(matrix)}");
