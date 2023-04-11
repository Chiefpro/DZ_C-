int Max(int arg1, int arg2, int arg3)
{
    int rezaltt = arg1;
    if (arg2 > rezaltt)
    { rezaltt = arg2;}
    if (arg3 > rezaltt) { rezaltt = arg3;}
    return rezaltt;
}
int a1 = 3, b1 = 5, c1 = 7;
int a2 = 666, b2 = 76, c2 = 0;
int a3 = 4, b3 = 8414, c3 = -6;
int fin = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));
Console.WriteLine(fin);