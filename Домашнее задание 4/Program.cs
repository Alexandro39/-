милиметры в сантиметры
try
{
    const float m = 0.1f;
Console.Write("Введите миллиметры:");
double mm = double.Parse(Console.ReadLine());
double res = mm * m;
Console.Write($"{mm}миллиметров {res:F0}сантиметров");
}
catch
{
    Console.WriteLine("Введите коректное значение");
}
милиметры в метры
try
{
    const float m = 0.01f;
Console.Write("Введите сантиметры:");
double me = double.Parse(Console.ReadLine());
double res = me * m;
Console.Write($"{me}сантиметров {res:F2}метров");
}
catch
{
    Console.WriteLine("Введите коректное значение");
}
метры в километры
try
{
    const float m = 0.001f;
Console.Write("Введите метры:");
double me = double.Parse(Console.ReadLine());
double res = me * m;
Console.WriteLine($"{me}метров {res:F2}километров");
}
catch
{
    Console.WriteLine("Введите коректное значение");
}

километры в мили
try
{
    const float m = 1.69f;
Console.Write("Введите километры:");
double me = double.Parse(Console.ReadLine());
double res = me / m;
Console.WriteLine($"{me}километров {res:F2}мили");
}
catch
{
    Console.WriteLine("Введите коректное значение");
}
мили в ярды
try
{
    const float m = 1.760f;
    Console.Write("Введите мили:");
    double me = double.Parse(Console.ReadLine());
    double res = me * m;
    Console.WriteLine($"{me}миль {res:F2}ярдов");
}
catch
{
    Console.WriteLine("Введите коректное значение");
}
