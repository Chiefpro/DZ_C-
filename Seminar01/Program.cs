Console.Write("Введите первое число: ");
string input1 = Console.ReadLine() ?? "";
int num1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine() ?? "";
int num2 = int.Parse(input2);

if (num2 * num2 == num1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

// ---------------вторая задача----------

Console.Write("Введите день недели цифрой: ");
string inp_n = Console.ReadLine() ?? "";
int dn = int.Parse(inp_n);

if (dn == 1)
{
    Console.WriteLine("понедельник");
}
else if (dn == 2)
{
    Console.WriteLine("вторник");
}
else if (dn == 3)
{
    Console.WriteLine("среда");
}
else if (dn == 4)
{
    Console.WriteLine("четверг");
}
else if (dn == 5)
{
    Console.WriteLine("пятница");
}
else if (dn == 6)
{
    Console.WriteLine("суббота");
}
else if (dn == 7)
{
    Console.WriteLine("воскресенье");
}
else
{
    Console.WriteLine("не правильно введено");
}