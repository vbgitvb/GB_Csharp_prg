/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

x = (b2 - b1) / (k1 - k2)
y = k1 * (b2-b1) / (k1-k2) + b1
*/

double x = 0;
double y = 0;
double numberFromString = 0;
double[] b = new double[2];
double[] k = new double[2];

if(FillArray(b,'b') && FillArray(k,'k')) 
{
    if (k[0] == k[1] ) Console.WriteLine("Прямые параллельны");
    else
    {
        x = (b[1] - b[0]) / (k[0] - k[1]);  //b2-b1 / k1-k2
        y = k[0] * x + b[0];                //k1 * x + b1
        Console.WriteLine($"Точка пересечения: x = {x.ToString("N2")}, y = {y.ToString("N2")}");
    }
}
else
{
    Console.WriteLine("Введены ошибочные данные. Повторите ввод.");    
}



//Заполнение массива с клавиатуры
// Возвращает true если введены числа, иначе возвращает false
bool FillArray(double[] arrayToFill, char name)
{
    int len = arrayToFill.Length;    
    
    for (int i = 0;  i<len; i++)
    {
        Console.Write($"Введите {name}{i+1}: ");
        //Если введено число заполняем массив, иначе завершаем ввод
        if(ComplianceCheck(Console.ReadLine())) arrayToFill[i] = numberFromString;
        else return false;
        
    }
    return true;
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
    else if (!double.TryParse(str, out numberFromString))
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
