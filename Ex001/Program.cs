// Напишиет программу, проверяющую число на четность

double a;
a = double.Parse(Console.ReadLine());

if(a%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}