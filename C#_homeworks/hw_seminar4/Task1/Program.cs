/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int degree(int osnovanie, int stepen)
{
    int result = 1;
    for (int i = 0; i < stepen; i++)
    {
        result = result * osnovanie;
    }
    return result;
}

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

string? ErrorMsg = "Введено значение не соответствующее условию. Повторите ввод.";

Console.Write("Введите основание: ");
string? tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int x = Convert.ToInt32(tempStr);

Console.Write("Введите степень: ");
tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int y = Convert.ToInt32(tempStr);
Console.WriteLine($"{x} ^ {y} = {degree(x,y)}");
