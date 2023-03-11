/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1(строчка) 7 (столбец) -> такого числа в массиве нет
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


int rows = 3;
int columns = 4;
int[,] matrix = InitRandomArray(rows, columns);

Console.Write("Введите номер строки: ");
int inputRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int inputColumn = Convert.ToInt32(Console.ReadLine());

PrintMatrix(matrix);

if (inputRow > rows)
{
    Console.WriteLine($"Указанный элемент массива [{inputRow},{inputColumn}] отсутствует. "+ 
                      $"Мах число строк - {rows}");
    return;
}

if (inputColumn > columns)
{
    Console.WriteLine($"Указанный элемент массива [{inputRow},{inputColumn}] отсутствует. "+
                      $"Мах число столбцов - {columns}");
    return;
}

Console.WriteLine($"Элемент массива в строке: {inputRow}, столбце: {inputColumn} = "+
                  $"{matrix[inputRow-1, inputColumn-1]}");
