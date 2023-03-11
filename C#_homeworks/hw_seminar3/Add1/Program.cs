/*
Доп. задание №1:

Представим банк, в котором алгоритм начисления процента по вкладу 
зависит от суммы вклада. На вход будет подаваться число (сумма вклада).
При значении меньше 100, будет начислено 5 %, если значение находится 
в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
Отработав, программа должна вывести общую сумму с начисленными процентами. 
*/

string? errorMsg = "Введено не корректное значение";
Console.Write("Введите размер вклада: ");
string? str = Console.ReadLine();
//int [] procent = {};

if (string.IsNullOrEmpty(str))
{
    Console.WriteLine(errorMsg);
    return;
}

double num = 0;
if (!double.TryParse(str, out num ))
{
    Console.WriteLine(errorMsg);
    return;
}

if (num < 0)
{
    Console.WriteLine(errorMsg);
    return;
}

if (num <100)
{
    num = num * 1.05;
}
else if ((num >= 100) && (num <= 200))
{
    num = num * 1.07;
}
else
{
    num = num * 1.1;
}
Console.WriteLine($"Размер вклада c процентами составляет: {num:f2}");
