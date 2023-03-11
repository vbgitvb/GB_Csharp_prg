/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int i=0;
string[] errorMsg = {"Введена пустая строка" , 
                     "Введено не 3-х значное число"};


//Написал System.Console вместо Console, потому как отображало cs0103 ошибку
System.Console.Write("Введите трехзначное число ( число состоит из 3-х цифр) ");

string? num = System.Console.ReadLine();

//Проверка на пустую строку
if (String.IsNullOrEmpty(num))
{
    System.Console.WriteLine(errorMsg[0]);
   return;
}

// Если длина строки больше 4 (первым может быть -, а так бы было 3)
// то введено точно не 3-х значное число
if (num.Length > 4)
{
    System.Console.WriteLine(errorMsg[1]);
   return;
}

//Число отрицательное или положительное
if (num[0] == '-') 
{ 
    i = 1;
}

//Проверим если в строке НЕ цифры. i = 0 или 1 если первый символ минус
//Эту проверку можно вынести в отдельный метод аля IsDigits
//или воспользоваться TryParse
while (i < num.Length)
{
    if ((num[i] < '0') || (num[i] > '9'))
    {

        System.Console.WriteLine(errorMsg[1]);
        return;
    }
    i++;
}

//можно конвертировать строку в циферки
int number = System.Convert.ToInt32(num);

//Проверка на трехзначность, а то можно и 005 ввести
if (((number < 100) || (number > 999)) && ((number < -999) || (number > -100)))
{
    System.Console.WriteLine($"{errorMsg[1]} - {number}");
}
else    //Собственно то, что требовалось сделать по условию задачи. 
{
    System.Console.WriteLine($"Вторая цифра числа {number} это: {number/10%10}");
}
