//Нарисовать квадрат

Console.WriteLine("Введите высоту фигуры: ");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("Введите ширину фигуры: ");
int width = int.Parse(Console.ReadLine());

for (int i = 0; i<=height; i++)
{
    for(int j = 0; j<=width; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
