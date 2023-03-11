/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите начальное положительное число: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное положительное число: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

if(startNumber > endNumber)
{
    Console.WriteLine("Введены недопустимые значения. Повторите ввод");
    return;
}

if(startNumber < 0 || endNumber < 0)
{
    Console.WriteLine("Введены недопустимые значения. Повторите ввод");
    return;
}

Console.WriteLine($"Сумма чисел от {startNumber} до {endNumber} равна: {CalcSumm(startNumber, endNumber)}");

/// <summary>
/// Находит сумму чисел
/// </summary>
/// <param name="begin">начальное значение</param>
/// <param name="end">конечное значение</param>
/// <returns>результат сложения чисел от начального до конечного</returns>
int CalcSumm(int begin, int end)
{
    if(begin == end) return end;

    return begin + CalcSumm(begin + 1, end);
}
