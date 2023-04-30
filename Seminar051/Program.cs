int longcikl = Vvod("Введи длину массива ", "Не правильно ввел");
int[] arr35 = NewArray(longcikl, 0, 500);
PrintArray(arr35);
int z35 = Zadacha35(arr35);
Console.WriteLine($"Колличество совпадений {z35}");

int[] arr37 = NewArray(5, 1, 9);
PrintArray(arr37);
int[] z37 = Zadacha37(arr37);
Console.WriteLine($"  {z37}");
PrintArray(z37);


#region 
static int[] Zadacha37(int[] arr)
{
    int ll = arr.Length;
    int i = 0;
    int jj = ll - 1;
    if (ll % 2 != 0)
    {
        i = ll / 2 + 1;

    }
    else
    {
        i = ll / 2;

    }
    int[] arrt = new int[i];
    if (ll % 2 != 0)
    {
        int gf = i - 1;
        for (int j = 0; j < i-1; j++)
        {

            arrt[j] = arr[j] * arr[jj];
            jj--;
        }
        arrt[gf] = arr[gf];
    }
    else
    {
        for (int j = 0; j < i; j++)
        {

            arrt[j] = arr[j] * arr[jj];
            jj--;
        }
    }


    return arrt;
}


static int Zadacha35(int[] arr)
{
    int i = 0;
    foreach (int var in arr)
    {
        if (var > 9 && var < 100)
            i++;
    }
    return i;
}

static int[] NewArray(int dlinamassiva, int min, int max)
{
    int[] array = new int[dlinamassiva];
    for (int i = 0; i < dlinamassiva; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

static int Vvod(string text, string error)
{
    while (true)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out int var))
            return var;
        Console.WriteLine(error);
    }
}

static void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}





#endregion