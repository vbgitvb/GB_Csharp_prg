/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

string? ErrorMsg = "Введено значение не соответствующее условию. Повторите ввод.";
int start=0; 
//середина строки из 5 цифр (от 0 до 4)
int middleStr = 2;
//учитывается знак числа
int sign = 1;

Console.Write("Введите 5-ти значное число: ");
string? str = Console.ReadLine();

if (String.IsNullOrEmpty(str))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int len = str.Length;

if (((str[0] == '-') && (len != 6)) || ((str[0] != '-') && (len != 5)))
{
    Console.WriteLine(ErrorMsg);
    return;
}

if (!int.TryParse(str, out _ ))
{
    Console.WriteLine(ErrorMsg);
    return;
}

bool result = true;
//Если число отрицательное, надо сдвинуть проверку на 1 символ слева
if (str[0] == '-')
{
    start=1;
    middleStr = 3;
    sign = 0;
}

for (int i = start; i < middleStr; i++)
{
  if (str[i] != str[len-sign-i])
 {
    result = false;
    break;
 }
}

if (result)
{
 Console.WriteLine($"Число {str} является палиндромом.");
}
else
{
 Console.WriteLine($"Число {str} НЕ является палиндромом.");
}