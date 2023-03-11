/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] InitRandomArray(int rows, int columns)
{
    double[,] arrayRandom = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayRandom[i,j] = Math.Round(new Random().NextDouble()*100,2);
        }
    }
return arrayRandom;
}

void PrintRealMatrix(double[,] inputMatrix)
{
    int rows = inputMatrix.GetLength(0);
    int columns = inputMatrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{inputMatrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] realMatrix = InitRandomArray(3,4);

PrintRealMatrix(realMatrix);

/*
-------------------------------
*/

int rows = 3;

int cols = 3;

int[,] matrix = new int[rows, cols];

int min = int.MaxValue;

int indexMinRows = 0; // Номер строчки с мин. элементом
int indexMinCols = 0; // Номер строчки с мин. элементом

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i,j] = new Random().Next(11); // 0-10
        Console.Write(matrix[i,j] + "\t");
        if (min > matrix[i,j])
        {
            min = matrix[i,j];
            indexMinRows = i;
            indexMinCols = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Мин.элемент: {min}, \t строчка: {indexMinRows}, \t cтолб: {indexMinCols}");

for (int i = 0; i < rows; i++)
{
    if(i != indexMinRows)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j != indexMinCols)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}
