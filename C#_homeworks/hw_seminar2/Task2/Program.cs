/*
Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

78 -> третьей цифры нет

3267900 -> 6

ДОП: цифра третья может быть как с левой стороны, так и с правой
------------------------------------------------------------------------------------------------------
*/
/*
Входные данные:

1 число  - ограничено 18 цифрами, положительое или отрицательное

2 число - какую цифру введённого числа 1, отсчитывая по порядку слева отобразить, от 1 до 18

3 число - какую цифру введённого числа 1, отсчитывая по порядку справа отобразить, от 1 до 18
*/

//переменная цикла
int i=0;
//Флаг наличия минуса в числе. Учитывается при поиске левого числа
int sign = 0;

//Сообщения об ошибках
string[] errorMsg = {"Введена пустая строка" , 
                     "Введенное число не соответствует условию"};

//максимальная длина числа. По условию задачи 7, но можно сделать больше или меньше
//возьмем тип double и ограничимся - 18 цифр, для простоты определения границ max и min
//если надо больше, то понадобятся дополнительные телодвижения
int maxLenght = 18;

//Цифра, отображаемая слева от числа. По условию = 3  
//Но может быть = [1..maxLenght] т.к. по условию задачи мах число 7. Улучшим исходные данные
int left = 3;

//Цифра, отображаемая справа от числа. По условию задачи мах число 7. Улучшим исходные данные
//Но может быть = [1..maxLenght] т.к. по условию мах число - семизначное
int right = 3;

System.Console.Write($"Введите число, состоящее максимум из {maxLenght} цифр ");
string? num = System.Console.ReadLine();

//Проверка на пустую строку
if (String.IsNullOrEmpty(num))
{
   System.Console.WriteLine(errorMsg[0]);
   return;
}

//Определим длину строки
int numLenght = num.Length;

//Проверим наличие минуса
if ( num[0] == '-' ) 
{ 
    i = 1;
    sign = 1;   //число отрицательное, учтем это при поиске левой цифры
}
// Проверка на длину, избегаем ошибки переполнения в int32
if (((i == 0) && (numLenght > maxLenght)) || ((i == 1) && (numLenght > maxLenght+1)))
{
    System.Console.WriteLine(errorMsg[1]);
    return;
}

//Проверим если в строке НЕ цифры. i = 0 если число положительное.
//Если первый символ "-", то i = 1
//Эту проверку можно вынести в отдельный метод аля IsDigits
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
double number = System.Convert.ToDouble(num);

//Определяем какие цифры слева и справа отображать
System.Console.Write($"Какую цифру числа, отсчитывая слева по порядку, отобразить [1..{maxLenght}] ");
left = Convert.ToInt32(System.Console.ReadLine());

if ((left < 1) || (left > maxLenght))
{
    System.Console.WriteLine($"{errorMsg[1]} - {left}");
    return;
}

System.Console.Write($"Какую цифру числа, отсчитывая справа по порядку, отобразить [1..{maxLenght}] ");
right = Convert.ToInt32(System.Console.ReadLine());
if ((right < 1) || (right > maxLenght))
{
    System.Console.WriteLine($"{errorMsg[1]} - {right}");
    return;
}

//Номер цифры слева и справа могут не совпадать, например показать слева 2 цифру, а справа 5
//Поэтому проверяем на наличие нужных цифр для лева и права раздельно
    if (numLenght < left )
    {
        System.Console.WriteLine($"В числе {number} {left} цифра слева отсутствует");    
    }
    else
    {
        double resultLeft = Convert.ToDouble(Math.Truncate(number / Math.Pow(10, numLenght-left-sign))) % 10;
        System.Console.WriteLine($"{left} цифра слева числа {string.Format("{0:f0}", number)} это: {Math.Abs(resultLeft)}");
    }
//Проверяем справа
    if (numLenght < right )
    {
        System.Console.WriteLine($"В числе {number} {right} цифра справа отсутствует");    
    }
    else
    {
        double resultRight = Convert.ToDouble(Math.Truncate(number / Math.Pow(10, right-1))) % 10;
        System.Console.WriteLine($"{right} цифра справа числа {string.Format("{0:f0}", number)} это: {Math.Abs(resultRight)}");
    }
