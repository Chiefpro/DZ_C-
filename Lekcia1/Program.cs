//-----example 1---------
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
//-----example 2---------
Console.Write ("Введите ваше имя ");
string username = Console.ReadLine() ?? "";
Console.WriteLine ("Hello ");
Console.WriteLine (username);
//-----example 3--------
int num1 = new Random().Next(1, 10);
Console.WriteLine(num1);
int num2 = new Random().Next(1, 10);
Console.WriteLine(num2);
int sum = num1 + num2;
Console.WriteLine(sum);
//-----examle 4--------
double num1 = 12;
double num2 = 5;
Console.WriteLine(num1 / num2);
//-----example 5--------
Console.Write("Как вас зовут? ");
string username = Console.ReadLine() ?? "";
if (username.ToLower() == "вася")
{
    Console.WriteLine("Привет Васек!!!!");
}
else
{
    Console.WriteLine("привет " + username);
}
//-----example 6---------
int a = 4;
int b = 3;
int c = 7;
int d = 8;
int e = 1;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.WriteLine(max);
//-----example 7--------
Console.Clear();
int xa = 30, ya = 1,
    xb = 1, yb = 25,
    xc = 60, yc = 25;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.Write("+");

int x = xa, y = ya;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}