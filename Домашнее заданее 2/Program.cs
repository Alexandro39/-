//Дано четырех значное число. Найти: 
//а) сумму его цифр;
//б) произведение его цифр.
//a
try
{
    Console.Write("введите четырехзначное число:");
int n = int.Parse(Console.ReadLine());
int a = n % 10;
int b = n / 10 % 10;
int c = n / 100;
int d = n / 1000;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(d);
Console.WriteLine(d);
Console.WriteLine($"{a + b + c + d}");
}
catch
{
    Console.Write("Введите корекное число!");
}
//b
try
{
    Console.Write("ВВедите черырехзначное число:");
int n = int.Parse(Console.ReadLine());
int a = n % 10;
int b = n / 10 % 10;
int c = n / 100;
int d = n / 1000;
Console.WriteLine($"{a * b * c * d}");
}
catch 
{
    Console.Write("Введите коректное число!");
}