// Написать программу, проверяющую четность/нечетность числа, которую указал пользователь в консоли

Console.Clear();
Console.WriteLine("Введите первое число диапазона: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine("Введите последнее число диапазона: ");
int limit = int.Parse(Console.ReadLine());
int EvenValue = 0;
int UnevenValue = 0;
int EvenValueSum = 0;
int UnevenValueSum = 0;

while(count <= limit)
{
    if(count % 2 == 0)
    {   
        EvenValue++;
        EvenValueSum += count;
        
    }
    else
    {
        UnevenValue++;
        UnevenValueSum += count;
    }
    count++;
    
}

Console.WriteLine("Количество четных чисел " + EvenValue);
Console.WriteLine("Количество нечетных чисел " + UnevenValue);

Console.WriteLine("Сумма четных чисел: " + EvenValueSum);
Console.WriteLine("Сумма нечетных чисел: " + UnevenValueSum);


