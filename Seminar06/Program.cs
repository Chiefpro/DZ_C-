Console.Clear();
//-----------------Задача 39--------------------------
int d39 = Vvod("Vvedi dliny massiva ", "Error!!!");
int[] arr39 = NewArray(d39, 0, 10);
PrintArray(arr39);
int[] arr39r = ReversArray(arr39);
PrintArray(arr39r);
int[] arr39rr = ReversArray2(arr39);
PrintArray(arr39rr);
//-------------------Задача 40---------------------------
Console.WriteLine(Zadacha40(4, 6, 3));
//-------------------Задача 42---------------------------
Console.WriteLine(Zadacha42(45));
//-------------------Задача 44---------------------------


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
static int[] NewArray(int d, int min, int max)
{
    int[] arr = new int[d];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
static void PrintArray(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
}
static int[] ReversArray(int[] arr)
{
    int l = arr.Length;
    int[] arrtemp = new int[l];
    for (int i = 0; i < arr.Length; i++)

    {
        arrtemp[i] = arr[l - 1];
        l = l - 1;
    }
    return arrtemp;
}
static int[] ReversArray2(int[] arr)
{
    int l = arr.Length;
    //Console.WriteLine(l);
    int temp;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[l - 1];
        arr[l - 1] = temp;
        l = l - 1;
    }
    return arr;
}
static bool Zadacha40(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}
static int Zadacha42(int num)
{
    int resalt = 0;
    for (int p = 0; num > 0; p++)
    {
        resalt = resalt + num % 2 * (int)Math.Pow(10, p);
        num = num / 2;
    }
    return resalt;
}



#endregion