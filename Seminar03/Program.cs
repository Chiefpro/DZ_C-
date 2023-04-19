Console.Clear();
zad1();


int vvod()
{
    int var1;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var1) && var1 != 0)
            break;
        Console.WriteLine("Не корректно введены координаты");
    }
    return var1;
}

void zad1()
{
    Console.Write("Ввседите координату X ");
    int x = vvod();
    Console.Write("Введите координату Y ");
    int y = vvod();
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Плоскость 1");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("плоскость 2");
    }
    else if(x<0&&y<0)
    {
        Console.WriteLine("Плоскость 3");
    }
    else
    {
        Console.WriteLine("Плоскость 4");
    }
}
    

