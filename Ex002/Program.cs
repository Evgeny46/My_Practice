// Написать программу, которая выполняет функцию калькулятора

/* Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());


Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Выберите операцию из списка: +, -, *, /");

string c = Console.ReadLine();

if(c == "+")
{
    double sum = a + b;
    Console.WriteLine(sum);
}


if(c == "-")
{
    double sub = a - b;
    Console.WriteLine("Ответ: " + sub);

}

if(c == "*")
{
    double mult = a * b;
    Console.WriteLine("Ответ: " + mult);

}

if(c == "/")
{
    double div = a / b;
    Console.WriteLine("Ответ: " + div);


*/
Console.Clear();
Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Выберите операцию из списка: +, -, *, /");
string operation = Console.ReadLine(); 

switch (operation)
{
    case "+":
            double sum = a + b;
            Console.WriteLine("Ответ: " + sum);  
        break;

    case "-":
            double sub = a - b;
            Console.WriteLine("Ответ: " + sub);
        break;

    case "*":
            double mult = a * b;
            Console.WriteLine("Ответ: " + mult);
        break;

    case "/":
            if(b == 0)
                Console.WriteLine(0);
            else
            {
            double div = a / b;
            Console.WriteLine("Ответ: " + div);
            }
        break;
    
    default:
            Console.WriteLine("Ошибка! Неизвестное действие");
            break;
} 



