Console.Clear();
// int[] array = Zadacha31(12, -9, 9);
// int p = Pozitiv(array);
// int n = Negativ(array);
// Console.WriteLine();
// Console.WriteLine($"сумма положительных = {p}, сумма отрицательных = {n}");
int[] arr_z31 = Zadacha31(12,-9,9);
Zadacha32(arr_z31);


#region 
static int[] Zadacha31(int dlina, int min, int max)
{
    int[] arr = new int[dlina];
    for (int i = 0; i < dlina; i++)
        arr[i] = new Random().Next(min, max+1);
    Console.WriteLine(String.Join(" ", arr));
    return arr;
}
static void Zadacha32(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
            arr[i] *= -1;
    }
    Console.WriteLine(String.Join(" ", arr));
}
static int Pozitiv(int[] arr)
{
    int res = 0;
    foreach(int i in arr)
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