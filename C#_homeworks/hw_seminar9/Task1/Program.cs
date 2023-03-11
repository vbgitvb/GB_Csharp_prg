/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Write("Введите положительное число, желательно меньше 500: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N>5000) 
{
    Console.WriteLine("Введено большое число, результат ожидать крайде долго");
    return;
}

Console.WriteLine($"N = {N} -> \"{PrintNumbers(N)}\"");

/// <summary>
/// Рекурсивное нахождение чисел от N до 1
/// </summary>
/// <param name="inputNum">начальное значение</param>
/// <returns>строку с числами, разделёнными запятой</returns>
string PrintNumbers(int inputNum)
{
    if(inputNum == 1) return inputNum.ToString();

    return inputNum + ", " + PrintNumbers(inputNum - 1);
}
