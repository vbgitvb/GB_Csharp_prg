/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


//проверка входных данных
bool testInput(string? str)
{
    bool result = false;
    //Проверка на пустую строку
    if (String.IsNullOrEmpty(str))
    {
        return result;
    }
    //является ли числом
    else if (!int.TryParse(str, out _ ))
    {
        return result;
    }
    //введена цифра
    else
    {
        result = true;
    }

return result;
}

int SumDigits(int digit)
{
    int sum = 0; 
    if (digit < 0) digit *= -1;
    while (digit > 0)
    {
        sum = sum + (digit % 10);
        digit /= 10;
    }
     return sum;
}

string? ErrorMsg = "Введено значение не соответствующее условию. Повторите ввод.";

Console.Write("Введите целое число: ");
string? tempStr = Console.ReadLine();
//Проверка введённого значения
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}

int num = Convert.ToInt32(tempStr);
Console.WriteLine($"Сумма цифр числа {num} = {SumDigits(num)}");
