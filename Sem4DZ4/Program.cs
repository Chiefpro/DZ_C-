Console.Clear();
int z25a = Vvod("Введите число А ", "Ошибка ввода!!");
int z25b = Vvod("введите число B ", "Ошибка ввода!!");
int z25 = Zadacha25(z25a, z25b);
Print($"{z25a}, {z25b} => {z25}");
int z27a = Vvod("Введи число ", "error!");
int z27 = Zadacha27(z27a);
Print($"{z27a} => {z27}");
int z29 = Vvod("введи степень массива ", "Error!!!");
Zadacha29(z29);

#region 
static int Vvod(string text, string error)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int var))
            return var;
        Console.WriteLine(error);
    }
}
static void Print(string text)
{
    Console.WriteLine(text);
}

static int Zadacha25(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
static int Zadacha27(int a)
{
    int result = 0;
    int st = 0;
    int wr = a;
    int b = a;
    while (b != 0)
    {
        b = b / 10;
        st++;
    }
    for (int i = 0; i < st; i++)
    {
        result = result + (wr % 10);
        wr = wr / 10;
        Console.WriteLine(wr);

        //Console.WriteLine(wr);

    }
    return result;
}
static void Zadacha29(int z)
{
    int[] array = new int[z];
    for (int i = 0; i < z; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    for (int i = 0; i < z; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
#endregion