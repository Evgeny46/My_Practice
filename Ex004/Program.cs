// Используя цикл for выведите в 2 переменные, которые будут выводить значения в обратном порядке и от меньшего к большему

Console.WriteLine("Введите значение первой переменной: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение второй переменной");
int j = int.Parse(Console.ReadLine());

for (; i <= j && j>=i; i++, j--)
{
    Console.WriteLine("переменная i: " + i);
    Console.WriteLine("переменная j: " + j);
}
