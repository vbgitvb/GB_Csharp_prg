


string str = "-123";
double  num = 0;

bool isn = double.TryParse(str, out num);

if (isn)
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Не число");
}