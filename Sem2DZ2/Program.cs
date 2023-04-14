Console.Clear();
Zadacha10();
Console.WriteLine();
Zadacha13();
Console.WriteLine();
Zadacha15();


int VvodZadach10()
{
    int var1;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var1) && var1 < 1000 && var1 > 99)
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return var1;
}
void Zadacha10()
{
    Console.Write("Введите трехзначное число ");
    int a = VvodZadach10();
    int b = a / 10 % 10;
    Console.WriteLine($"Вторая цифра => {b}");
}

void Zadacha13()
{
    int var2;
    int aa = 0;
    Console.Write("введите число ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var2))
            break;
        Console.WriteLine("Ошибка ввола!");
    }
    if (var2 < 100)
    {
        Console.WriteLine("третьей цифры нету");
    }
    else
    {
        while (var2 > 999)
        {
            var2 = var2 / 10;
        }
        aa = var2 % 10;
    }
    Console.WriteLine($"третья цифра {aa}");
}
void Zadacha15()
{
    int var3;
    Console.Write("Введите день недели числом ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var3) && var3 <= 7 && var3 > 0)
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    if (var3 == 6 || var3 == 7)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("будни");
    }
}