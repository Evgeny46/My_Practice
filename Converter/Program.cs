Console.Clear();

double USDtoRUB = 60.47;
double USDtoCNY = 6.92;
double USD;

Console.Write("Введите сумму в USD: ");

USD = double.Parse(Console.ReadLine());

Console.WriteLine(USD + " USD в RUB = " + USD * USDtoRUB);
Console.WriteLine(USD + " USD в CNY = " + USD * USDtoCNY);

