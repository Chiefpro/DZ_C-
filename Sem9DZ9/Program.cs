// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до M.
Console.WriteLine("----------------------------Задача 64:-----------------------------------");

while (true)
{
    int m64 = Vvod("Введите начальную цифру M => ", "Error!!!");
    int n64 = Vvod("Введите конечную цифру N => ", "Error!!!");
    if (m64 < n64)
    {
        string resalt64 = Integers(m64, n64);
        Console.WriteLine(resalt64);
        break;
    }
    else
        Console.WriteLine("Вы ввели неверно начало и конец диапозона, попробуйте ещё раз!)");
}

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("----------------------------Задача 66:-----------------------------------");

while (true)
{
    int m66 = Vvod("Введите начальную цифру M => ", "Error!!!");
    int n66 = Vvod("Введите конечную цифру N => ", "Error!!!");
    if (m66 < n66)
    {
        Console.WriteLine(SumIntegers(m66, n66));
        break;
    }
    else
        Console.WriteLine("Вы ввели неверно начало и конец диапозона, попробуйте ещё раз!)");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine("----------------------------Задача 68:-----------------------------------");

while (true)
{
    int m68 = Vvod("Введите неотрицательное число M => ", "Error!!!");
    int n68 = Vvod("Введите неотрицательное число N => ", "Error!!!");
    if (m68 > 0 && n68 > 0)
    {
        int resalt68 = Akkerman(m68, n68);
        Console.WriteLine($"A(M,N) = {resalt68}");
        break;
    }
    else
        Console.WriteLine("Вы ввели отрицательные числа, попробуйте ещё раз!)");
}

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
static string Integers(int a, int b)
{
    if (a == b)
        return b.ToString();
    else
        return b + " " + Integers(a, b - 1);
}
static int SumIntegers(int a, int b)
{
    if (b == a)
        return a;
    return a = a + SumIntegers(a + 1, b);
}
static int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

#endregion
