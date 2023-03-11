/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

            m + 1                   при n == 0
A(n,m) =    A(n - 1, 1)             при n!=0 и m == 0
            A(n - 1, A(n, m - 1))   при n > 0 и m > 0
*/

Console.Write("Введите первое положительное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе положительное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(!CheckArguments(firstNumber, secondNumber)) return;

Console.WriteLine($"m = {firstNumber}, n = {secondNumber} -> " +  
                  $"A(m,n) = {FunctionAkkermana(firstNumber, secondNumber)}");

/// <summary>
/// Определяет значение согласно функции Аккермана
/// </summary>
/// <param name="first">первый аргумент функции</param>
/// <param name="second">второй аргумент функции</param>
/// <returns>результат функции Аккермана</returns>
int FunctionAkkermana(int first, int second)
{
    if(first == 0) return second + 1;
    else
        if(second == 0) return FunctionAkkermana(first - 1, 1);
    else
        return FunctionAkkermana(first - 1, FunctionAkkermana(first, second - 1));
}

/// <summary>
/// Проверка введённых аргументов
/// </summary>
/// <param name="first">первое число функции Аккермана</param>
/// <param name="second">второе число функции Аккермана</param>
/// <returns>возвращает ложь при числах < 0 и значениях, приводящих к переполнению стека. Иначе true</returns>
bool CheckArguments(int first, int second)
{
    bool result = false;
    string message = "При таких аргументах высока вероятность переполнения стека. Введите меньшие значения.";

    if(firstNumber < 0 || secondNumber < 0)
    {
        Console.WriteLine("Введены недопустимые значения. Повторите ввод");
    }
    else
        if(firstNumber > 3 || secondNumber > 13) Console.WriteLine(message);
    else
        result = true;
   
    return result;
}