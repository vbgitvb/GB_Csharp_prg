/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт
таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

string? errorMsg = "Введено не корректное значение";
Console.Write("Введите число, желательно не очень большое: ");
string? str = Console.ReadLine();

if (string.IsNullOrEmpty(str))
{
    Console.WriteLine(errorMsg);
    return;
}

int num = 0;
if (!int.TryParse(str, out num ))
{
    Console.WriteLine(errorMsg);
    return;
}
//Число может быть отрицательным, тогда дорисуем знак -
char sign = ' ';
if (num < 0)
{
    sign = '-';
    num = num * -1;
}

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{sign}{i}^3 ={sign}{Math.Pow(i, 3)}");
}
