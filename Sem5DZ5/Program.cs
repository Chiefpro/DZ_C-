//---------------- Задача 34 --------------------------
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int d34 = Vvod("Задача 34. Введи длину массива ", "Ошибка ввода!!");
int[] array34 = NewArray(d34, 100, 1000);
PrintArray(array34);
int z34 = Zadacha34(array34);
Console.WriteLine($" => {z34}");

// ---------------- Задача 36 --------------------------
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int d36 = Vvod("Задача 36. Введи длину массива ", "Ошибка ввода!!");
int[] array36 = NewArray(d36, -99, 100);
PrintArray(array36);
int z36 = Zadacha36(array36);
Console.WriteLine($" => {z36}");

//---------------- Задача 38 --------------------------
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
int d38 = Vvod("Задача 38. Введи длину массива ", "Ошибка ввода!!");
double[] array38 = NewArrayDouble(d38);
PrintArrayDouble(array38);
double min38 = Findmin(array38);
double max38 = Findmax(array38);
double resalt38 = Difference38(min38, max38);
Console.WriteLine($" => {resalt38}");




#region 
static int Zadacha34(int[] arr)
{
    int i = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) i++;
    }
    return i;
}

static int Zadacha36(int[] arr)
{
    int resalt = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        resalt += arr[i];
    }

    return resalt;
}

static int Zadacha38(int[] arr)
{
    int resalt = 0;



    return resalt;
}
static double Findmin(double[] arr)
{
    double min = arr[0];
    foreach(double el in arr)
    {
        if(el<min) min = el;
    }
    return min;
}
static double Findmax(double[] arr)
{
    double max = arr[0];
    foreach(double el in arr)
    {
        if(el>max) max = el;
    }
    return max;
}
static double Difference38(double min, double max)
{
    double resalt = max - min;
    return resalt;
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
static int[] NewArray(int longarray, int minarray, int maxarray)
{
    int[] arr = new int[longarray];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(minarray, maxarray + 1);
    return arr;
}

static double[] NewArrayDouble(int longarray)
{
    double[] arrd = new double[longarray];
    Random rd = new Random();
    for (int i = 0; i < arrd.Length; i++)
        arrd[i] = (double)rd.NextDouble() * 100;
    return arrd;
}

static void PrintArray(int[] arr)
{
    Console.Write(String.Join(" ", arr));
}

static void PrintArrayDouble(double[] arr)
{
    Console.Write(String.Join(" ", arr));
}


#endregion