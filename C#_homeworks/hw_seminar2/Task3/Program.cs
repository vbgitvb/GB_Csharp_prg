/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да

7 -> да

1 -> нет
*/

Console.Write("Введите цифру, обозначающуюю день недели [1..7] ");
//int num = Convert.ToInt32(Console.ReadLine());

//тут бы на символы проверить, а не только цифры
string? strNum = Console.ReadLine();

//Проверка на пустую строку
if (String.IsNullOrEmpty(strNum))
{
   System.Console.WriteLine("Введена пустая строка");
   return;
}

//Проверка - введено число?
int num = 0;
if (! int.TryParse(strNum, out num))
{
    System.Console.WriteLine("Введено не число");
    return;
}

if ((num < 1) || (num > 7))
{
    Console.WriteLine($"Введено не корректное число - {num} ");
}
else
{
    if ( (num == 6) || (num == 7))
    {
        Console.WriteLine($"Введеное число {num} - это выходной день");
    }
    else
    {
        Console.WriteLine($"Введеное число {num} - это будни");
    }
}
