try
{
    const double PI = 3.14;
    Console.Write("Введите радиус окружности:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine($"S = {PI * a}");
}
catch 
{
    Console.WriteLine("Введите коректное значение!");
}