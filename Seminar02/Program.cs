Console.Clear();
NumFind13();
Console.WriteLine();
Zadacha2();
Console.WriteLine();
Zadacha3();
Console.WriteLine();
Zadacha4();


void NumFind13()
{
    int num1 = new Random().Next(100, 1000);
    int a1 = num1 / 100;
    int c1 = num1 % 10;
    int d1 = a1 * 10 + c1;
    Console.WriteLine($"загадано {num1}, первая и третья цифра => {d1}");
}
void Zadacha2()
{
    int num1 = new Random().Next(1, 1001);
    int num2 = new Random().Next(1, 11);
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"кратно, {num1} {num2}");
    }
    else
    {
        int c = num1 % num2;
        Console.WriteLine($"не кратно, {num1} {num2} => остаток {c}");
    }
}
int Vvod()
{
    int var1;
    while (true)
    {
        //  Console.WriteLine("Введите чисоо ");
        if (int.TryParse(Console.ReadLine(), out var1))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return var1;
}
void Zadacha3()
{
    Console.Write("Введите число ");
    int df = Vvod();
    if (df % 7 == 0 && df % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
void Zadacha4()
{
    Console.Write("введите первое число ");
    int a1 = Vvod();
    Console.Write("введите второе число ");
    int b2 = Vvod();
    if (a1 * a1 == b2)
    {
        Console.WriteLine("DA");
    }
    else
    {
        Console.WriteLine("Net");
    }

}
