Console.Clear();
Zadacha019();
Zadacha021();
Zadacha023();



void Vvod(string message)
{
    int A;
    while (true)
    {
        try
        {
            Console.Write(message);
            A = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Не корректно введено число! {exc.Message}");
        }
    }
}

static int VvodOld(string message)
{
    Console.Write(message);
    int var;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var))
            break;
        Console.WriteLine("Не корретно введено число");
    }
    return var;
}


static void Zadacha019()
{
    int a = 0;
    while (true)
    {
        a = VvodOld("Введите пятизначное число ");
        if (a < 100000 && a > 10000 || a > -100000 && a < -10000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Не корретно введено число");
        }
    }
    Console.WriteLine(a);

    int a1, a2, a3, a4, a5;
    a1 = a / 10000;
    a2 = a / 1000 % 10;
    a3 = a / 100 % 10;
    a4 = a / 10 % 10;
    a5 = a % 10;
    //Console.WriteLine($"{a1}  {a2}  {a3}  {a4}  {a5}");
    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine("Число палиндромом");
    }
    else
    {
        Console.WriteLine("Число не полиндром");
    }
}

static void Zadacha021()
{
    int x1 = VvodOld("Введиде координаты X первой точки ");
    int y1 = VvodOld("Введиде координаты Y первой точки ");
    int z1 = VvodOld("Введиде координаты Z первой точки ");
    int x2 = VvodOld("Введиде координаты X второй точки ");
    int y2 = VvodOld("Введиде координаты Y второй точки ");
    int z2 = VvodOld("Введиде координаты Z второй точки ");
    double rezalt = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"{rezalt:f3}");
}

static void Zadacha023()
{
    int num = VvodOld("Введите число N ");
    Console.Write($"Куб числа {num} => ");
    for (int i = 1; i <= num; i++)
    {
        int rez = (int)Math.Pow(i, 3);
        Console.Write($" {rez} ");
    }
}
