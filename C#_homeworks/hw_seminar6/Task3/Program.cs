/*
Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10
*/
//введенное число с клавиатуры до преобразования
string? inputNumber = string.Empty;

//число в двоичной системе
string result = string.Empty;

//введенное число после проверки и преобразования
int number = 0;

//остаток от деления
int remainder = 0;

Console.Write("Введите десятичное число ");
inputNumber = Console.ReadLine();

//Проверка, что ввели число
if (ComplianceCheck(inputNumber)) 
{
    while (number >=1)
    {
        remainder = number % 2;
        number = number / 2;
        result = Convert.ToString(remainder) + ' ' +result;
    }
    Console.WriteLine($"Число {inputNumber} в двоичной системе = {result}");
}

//проверка входных данных
bool ComplianceCheck(string? str)
{
    bool result = false;
    //Проверка на пустую строку
    if (String.IsNullOrEmpty(str))
    {
        return result;
    }
    //является ли числом
    else if (!int.TryParse(str, out number))
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
