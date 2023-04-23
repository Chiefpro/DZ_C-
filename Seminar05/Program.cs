Console.Clear();
// int[] array = Zadacha31(12, -9, 9);
// int p = Pozitiv(array);
// int n = Negativ(array);
// Console.WriteLine();
// Console.WriteLine($"сумма положительных = {p}, сумма отрицательных = {n}");
// int[] arr_z31 = Zadacha31(12,-9,9);
// Zadacha32(arr_z31);
int[] arr_z33 = Zadacha31(12, -9, 9);
int n = Vvod("введи число для нахождения ", "Error");
Zadacha33(arr_z33, n);


#region 
static int[] Zadacha31(int dlina, int min, int max)
{
    int[] arr = new int[dlina];
    for (int i = 0; i < dlina; i++)
        arr[i] = new Random().Next(min, max + 1);
    Console.WriteLine(String.Join(" ", arr));
    return arr;
}
static void Zadacha32(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    Console.WriteLine(String.Join(" ", arr));
}
static void Zadacha33(int[] arr, int num)
{
    bool nbb = false;
    foreach (int el in arr)
    {
        if (el == num)
        {
            nbb = true;
        }
    }
    if (nbb == true) Console.WriteLine("Da");
    else Console.WriteLine("Net");
}
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
static int Pozitiv(int[] arr)
{
    int res = 0;
    foreach (int i in arr)
    {
        if (i > 0) res += i;
    }
    return res;
}
static int Negativ(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            res += arr[i];
    }
    return res;
}




#endregion