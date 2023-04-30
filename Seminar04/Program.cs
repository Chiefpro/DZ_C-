Console.Clear();
int z24 = Vvod("Введите целое число ", "Не корректно введено число!!!");
Zadacha24(z24);
int z26 = Vvod("введи число ", "Error1");
Zadacha26(z26);
int z28 = Vvod("vvedi ", "errore");
Zadacha28(z28);
Zadacha30();

#region 
static int Vvod(string text, string error)
{
    int w;
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out w))
            break;
        Console.WriteLine(error);
    }
    return w;
}

static void Zadacha24(int chislo)
{
    int res = 0;
    for (int i = 0; i <= chislo; i++)
    {
        res = res + i;
    }
    Console.WriteLine(res);
}

static void Zadacha26(int chiclo)
{
    int i = 0;
    while (true)
    {
        chiclo = chiclo / 10;
        i++;
        if (chiclo == 0) break;
    }
    Console.WriteLine(i);
}

static void Zadacha28(int chislo)
{
    int f = 1;
    for (int i = 1; i <= chislo; i++)
    {
        f *= i;
    }
    Console.WriteLine(f);
}

static void Zadacha30()
{
    int[] arr = new int[8];
    for (int i = 1; i < 8; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    for(int i = 0; i<8; i++)
    Console.Write($"{arr[i]} ");
}
#endregion