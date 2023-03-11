/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

string? inputNumber = string.Empty;
int maxSizeArray = 0;
int numberFromString = 0;

Console.Write("Сколько чисел будет введено с клавиатуры? ");
inputNumber = Console.ReadLine();

//Проверка, что ввели число
if (ComplianceCheck(inputNumber)) maxSizeArray = numberFromString;

int[] userArray = new int[maxSizeArray];

if(FillArray(userArray)) 
{
    Console.WriteLine($"В массиве [{String.Join("; ", userArray)}]");
    Console.WriteLine($"положительных чисел - {CountNumber(userArray)}");
}
else
{
    Console.WriteLine("Введены ошибочные данные. Повторите ввод.");    
}



//Возвращает кол-во положительных чисел в массиве
int CountNumber(int[] arrayToSearch)
{
    int countNumber = 0;
    int len = arrayToSearch.Length;

    for (int i = 0; i < len; i++)
    {
        if (arrayToSearch[i] > 0) countNumber++;
        
    }
    return countNumber;
}

//Заполнение массива с клавиатуры
// Возвращает true если введены числа, иначе возвращает false
bool FillArray(int[] arrayToFill)
{
    int len = arrayToFill.Length;    
    
    for (int i = 0;  i<len; i++)
    {
        Console.Write($"Введите {i+1} число из {len}: ");
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
    else if (!int.TryParse(str, out numberFromString))
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
