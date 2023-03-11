/*
Доп. задание №2:

Назовем число интересным, если в нем разность максимальной и минимальной 
цифры равняется средней по величине цифре. Напишите программу, которая определяет
интересное число или нет. Если число интересное, следует вывести – «Число интересное» 
иначе «Число неинтересное».

-> 954 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4.
Средняя цифра - цифра(962-6, 23456 - средняя 4) 
*/
string? errorMsg = "Введено не корректное значение";
Console.Write("Введите число: ");
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

int len = str.Length;
int indexMin = 0;
int indexMax = 0;
int start = 0;
int sign = 0;

//Если число < 0 - первый символ минус. Игнорируем его
if (num < 0)
{
    start=1;
    sign = 1;
    indexMin = 1;
    indexMax = 1;
}

//При наличии средней цифры - число состоит из нечетного числа цифр
//игнорируем число из одной цифры [0..9]
if (((len-sign) % 2) == 0 || (len-sign == 1))
{
    Console.WriteLine($"В числе {num} нет средней цифры.");
    return;
}


for (int i = start; i < len; i++)
{
    if (str[i] < str[indexMin])
    {
        indexMin = i;
    }
    else if (str[i] > str[indexMax])
    {
        indexMax = i;
    }
}

int Min = (int) str[indexMin] - '0';
int Max = (int) str[indexMax] - '0';
int Middle = (int) str[len/2] - '0';

if ((Max-Min) == Middle)
{
    Console.WriteLine($"{Max} - {Min} = {Middle}");
    Console.WriteLine($"Число интересное");
}
else
{
    Console.WriteLine($"{Max} - {Min} != {Middle}");
    Console.WriteLine($"Число НЕ интересное");
}
