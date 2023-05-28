// Задача 63: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от 1 до N.
// int m63 = Vvod("Введи начальное число M => ", "Error!!!");
// int n63 = Vvod("Введи конечное число N => ", "Error!!!");
// Natural(m63, n63);

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Console.WriteLine();
// int n67 = Vvod("Введи число => ", "Error!!!");
// int res67 = Sum(n67);
// Console.WriteLine(res67);

// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
int a69 = Vvod("Введи число А => ", "Error!!!");
int b69 = Vvod("Введи число B => ", "Error!!!");
Console.WriteLine(Proizvedie(a69, b69));

#region

static int Vvod(string text, string error)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int var))
            return var;
        else
            Console.WriteLine(error);
    }
}
static void Natural(int m, int n)
{
    if (n >= m)
    {
        Console.Write($"{m}\t");
        m++;
        Natural(m, n);
    }
}
static int Sum(int n)
{
    if (n % 10 == 0)
        return 0;
    return n % 10 + Sum(n / 10);
}
static int Proizvedie(int a, int b)
{
    if (b == 0)
        return 1;
    if (b == 1)
        return a;
    return a * Proizvedie(a, b - 1);
}

#endregion
