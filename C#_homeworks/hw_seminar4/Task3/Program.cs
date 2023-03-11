/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

//глобальные переменные
int size = 8;
int[] array = new int[size];

//основное тело программы (аля main в c)
if (!FillArray()) return;

PrintArray(array,'.');

Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");



//Методы, используемы в основной программе

//проверка на соответствие водимого значения
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


//заполнение числами массива с клавиатуры
bool FillArray()
{
    var result = true;
    string? ErrorMsg = "Введено значение не соответствующее условию. Повторите ввод.";
    string? tempStr = string.Empty;

    Console.WriteLine("Заполните массив из 8 элементов числами");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} из {size} число ");
        tempStr = Console.ReadLine();
        if (!testInput(tempStr))
        {
            Console.WriteLine(ErrorMsg);
            result = false;
            break;
        }
        array[i] = Convert.ToInt32(tempStr);
    }
    return result;
}

void PrintArray(int[] mas, char c)
{
    int len = mas.Length;
    Console.Write("Массив: [ ");
    for (int i = 0; i < len - 1; i++)
    {
      Console.Write($"{mas[i]}{c} ");
    }
    Console.WriteLine($"{mas[len-1]} ]");
}
