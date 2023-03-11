/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
//проверка, что ввели число типа int
bool testInput(string str)
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

//Первая точка А (x1, y1, z1) 
Console.Write("Введите координату точки A по оси Х: ");
string? tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int x1 = Convert.ToInt32(tempStr);

Console.Write("Введите координату точки  A по оси Y: ");
tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int y1 = Convert.ToInt32(tempStr);

Console.Write("Введите координату точки  A по оси Z: ");
tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int z1 = Convert.ToInt32(tempStr);

//Вторая точка B (x2, y2, z2)
Console.Write("Введите координату точки B по оси Х: ");
tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int x2 = Convert.ToInt32(tempStr);

Console.Write("Введите координату точки  B по оси Y: ");
tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int y2 = Convert.ToInt32(tempStr);

Console.Write("Введите координату точки  B по оси Z: ");
tempStr = Console.ReadLine();
if (!testInput(tempStr))
{
    Console.WriteLine(ErrorMsg);
    return;
}
int z2 = Convert.ToInt32(tempStr);

//AB = √(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)
var lenAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine($"Результат: {lenAB:f2}"); 
