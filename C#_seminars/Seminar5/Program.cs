

/*
int i= 6;
while (i>0)
{

    Console.Write($"{i%2}");
    i=i/2;
    
}
*/

int number = 6;
int a = 0;

string result = string.Empty;

while (number >=1)
{
    a = number % 2;
    number = number /2;
    result = Convert.ToString(a)+result;
}

Console.WriteLine(result);
