Console.Clear();
int[,] arr48 = NewArray(6, 5);
PrintArray(arr48);
Console.WriteLine();
int[,] arr49 = FindNecet(arr48);
PrintArray(arr49);
int res51 = Diagolal(arr49);
Console.WriteLine($"Сумма по диагонали => {res51}");




#region 

static int[,] NewArray(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            arr[i, j] = i + j;
    return arr;
}
static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}
static int[,] FindNecet(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            if (arr[i, j] % 2 != 0)
                // arr[i, j] = arr[i, j] * arr[i, j];
                arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
    return arr;
}
static int Diagolal(int[,] arr)
{
    int resalt = 0;
    int d = 0;
    if (arr.GetLength(0) > arr.GetLength(1)) d = arr.GetLength(1);
    else d = arr.GetLength(0);
    for (int i = 0; i < d; i++)
    {
        resalt += arr[i, i];
    }
    return resalt;
}


#endregion