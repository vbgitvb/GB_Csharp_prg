/*Console.Write("Введите число ");

int x = Convert.ToInt32(Console.ReadLine());

int res = x*x;

Console.WriteLine("Квадрат числа " + x + " равен " + res);
*/

/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> не */

/* Задача 2
Console.Write("Введите первое число ");

int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");

int secondValue = Convert.ToInt32(Console.ReadLine());

//int result = secondValue * secondValue;


if ( firstValue == Math.Pow(secondValue, 2)) {
    
    Console.WriteLine("Первое число " + firstValue + " является квадратом первого числа " + secondValue);

}
else
{
    Console.WriteLine("Первое число " + firstValue + " НЕ является квадратом первого числа " + secondValue);
}
//-----------------------------------------------------------------------------------------
*/

/* Задача 3
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/


Console.Write("Введите число ");

int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    n = n * (-1);
}

int negative_n = n * (-1);

while ( negative_n <= n)
{
    Console.WriteLine(negative_n);
    negative_n ++;
}











