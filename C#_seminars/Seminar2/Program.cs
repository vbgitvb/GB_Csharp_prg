/*
int number = new Random().Next(10, 100);

Console.WriteLine(number);

int n1 = number%10;
int n2 = number/10%10;
Console.WriteLine(n1);
Console.WriteLine(n2);
*/

//Задача 2
/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
/*
int number = new Random().Next(100, 1000);

int result = number/100*10 + number%10;

Console.WriteLine("1 и 2 цифра в числе: " + number + " это " + result);

string str  = Convert.ToString(number);
Console.WriteLine(str);
Console.Write(str[0]);
Console.WriteLine(str[2]);
*/

/*Задача 12
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
/*
Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber == 0)
{
    Console.WriteLine("Делить на 0 нельзя");
    return;
}

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine("Число краное. Остаток от деления = 0");
}
else
{
    //Console.WriteLine("Число не краное. Остаток от деления = " + firstNumber % secondNumber);
    Console.WriteLine($"Число не краное. Остаток от деления {firstNumber} на {secondNumber} = {firstNumber % secondNumber}");
}

Console.WriteLine($"Число не краное. \t Остаток");
*/

/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/*
Console.Write("Введите первое число ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 7 == 0 && Number % 23 == 0) 
{
    Console.WriteLine(" число  кратно 7 и 23");
}
else 
{
    Console.WriteLine($" число  НЕ кратно 7 и 23 - остаток {Number % 7} и {Number % 23}");
}
*/
