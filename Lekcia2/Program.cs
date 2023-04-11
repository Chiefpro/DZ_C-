int Max(int arg1, int arg2, int arg3)
{
    int rezaltt = arg1;
    if (arg2 > rezaltt)
    { rezaltt = arg2; }
    if (arg3 > rezaltt) { rezaltt = arg3; }
    return rezaltt;
}
/*
int a1 = 3, b1 = 5, c1 = 7;
int a2 = 666, b2 = 76, c2 = 0;
int a3 = 4, b3 = 8414, c3 = -6;
int fin = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));
Console.WriteLine(fin);
*/
int[] ar = { 43, 66, 24, 9555, 84, 9772, 98, 1, 6 };
int fin2 = Max(Max(ar[0], ar[1], ar[2]), Max(ar[3], ar[4], ar[5]), Max(ar[6], ar[7], ar[8]));
Console.WriteLine(fin2);
//---------------------------------------------------------------
void FillArray(int[] ar1)
{
    int n = ar1.Length;
    int ind = 0;
    while (ind < n)
    {
        ar1[ind] = new Random().Next(1, 10);
        ind++;
    }
}
void PrintArray(int[] ar2)
{
    int nn = ar2.Length;
    int indd = 0;
    while (indd < nn)
    {
        Console.Write(ar2[indd] + " ");
        indd++;
    }
}
int FindNum(int[] ar3, int ff)
{
    int nnn = ar3.Length;
    int inde = 0;
    int nummm = -1;
    while (inde < nnn)
    {
        if (ar3[inde]==ff)
        {
            nummm=inde;
            break;
        }
        inde++;
    }
    return nummm;
}


int[] masss = new int[12];
FillArray(masss);
PrintArray(masss);
int ss = FindNum(masss, 3);
Console.WriteLine();
Console.WriteLine(ss);
