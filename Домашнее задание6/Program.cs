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




try
{
    Console.WriteLine("Введите ваше имя" +
        "\n Введите ваш пол:" +
        "\n Введите ваш год рождения:" +
        "\n Введите ваш рост:" +
        "\n Сколько вам полных лет?:");
    char name = char.Parse(Console.ReadLine());
    char floor = char.Parse(Console.ReadLine());
    int year = int.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    int fullYears = int.Parse(Console.ReadLine());
    Console.WriteLine($"{name}" +
        $"\n {floor}" +
        $"\n {year}" +
        $"\n {height}" +
        $"\n {fullYears}");
}
catch 
{
    Console.WriteLine("Введите коректное значение:");
}

