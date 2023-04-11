// -------------- Задача 2 ------------
int a1 = 5, b1 = 7;
if (a1 > b1)
{
    Console.WriteLine("A больше чем B");
}
else
{
    Console.WriteLine("B больше чем A");
}
// -------------- Задача 4 ------------
Console.Write("Введите первое число ");
string as2 = Console.ReadLine() ?? "";
int a2 = int.Parse(as2);
Console.Write("Введите второе число ");
string bs2 = Console.ReadLine() ?? "";
int b2 = int.Parse(bs2);
Console.Write("Введите третье число ");
string cs2 = Console.ReadLine() ?? "";
int c2 = int.Parse(cs2);
if (a2 > b2 && a2 > c2)
{
    Console.WriteLine("Максималье число первое");
}
else if (b2 > a2 && b2 > c2)
{
    Console.WriteLine("Максимальер число второе");
}
else
{
    Console.WriteLine("Максимальное число третье");
}