



//int value = rnd.Next(0, 10);


int[] array = new int[8];
int i=0;
Random rnd = new Random();

for ( i = 0; i < 8; i++)
{
    array[i] = rnd.Next(0, 2);
}

for ( i = 0; i < 8; i++)
{
    Console.Write($"{array[i]}  ");
}
