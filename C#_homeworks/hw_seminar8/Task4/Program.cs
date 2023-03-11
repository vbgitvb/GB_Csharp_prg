/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] xyzArray = InitRandom(2, 2, 2, 10);
Print3DArray(xyzArray);

/// <summary>
/// Печать 3-х мерного массива
/// </summary>
/// <param name="inputArray">массив для вывода в консоль</param>
void Print3DArray(int[,,] inputArray)
{
    int maxX = inputArray.GetLength(0);
    int maxY = inputArray.GetLength(1);
    int maxZ = inputArray.GetLength(2);

    Console.WriteLine($"Массив размером {maxX} x {maxY} x {maxZ}:");
    for (int i = 0; i < maxX; i++)
    {
        for (int j = 0; j < maxY; j++)
        {
            for (int k = 0; k < maxZ; k++)
            {
                Console.Write($"Array[{i}, {j}, {k}] = {inputArray[i,j,k]}\t");
            }
            Console.WriteLine();
        }
    }
}

/// <summary>
/// Заполняет 3-хмерный массив
/// </summary>
/// <param name="rows">кол-во строк</param>
/// <param name="columns">кол-во столбцов</param>
/// <param name="depth">кол-во ячеек по 3 оси</param>
/// <param name="minValue">начальная цифра заполнения</param>
/// <returns>заполненный 3-х мерный массив</returns>
int[,,] InitRandom(int rows, int columns, int depth, int minValue)
{
    int[,,] place = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                place[i, j, k] = minValue++;
            }
        }
    }
    return place;
}
