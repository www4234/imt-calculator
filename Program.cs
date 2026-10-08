Console.Write("Введите свой вес: ");
double w = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свой рост: ");
double h = Convert.ToDouble(Console.ReadLine());
double result = w / Math.Pow(h, 2);
Console.WriteLine($"ИМТ: {result}");