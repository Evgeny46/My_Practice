//Вложенные циклы
for(int i = 1; i <= 3; i++)
{
    Console.WriteLine("Цикл 1, итерация № " + i);

    for(int j = 1; j<=3; j++)
    {
        Console.WriteLine("\tЦикл 2, итерация № " + j);
    }
}