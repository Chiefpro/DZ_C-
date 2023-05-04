// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m47 = Vvod("Введите количество строк => ", "Error!!");
int n47 = Vvod("Введите количество столбцов => ", "Error!!");
double[,] zadacha47 = NewArrayDouble(m47, n47, -100, 100);
PrintArrayDouble(zadacha47);
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int m50 = new Random().Next(1, 10);
int n50 = new Random().Next(1, 10);
int[,] zadacha50 = NewArrayInt(m50, n50, 1, 100);
int i50 = Vvod("Введите номер строки => ", "Error!!");
int j50 = Vvod("Введите номер столбца => ", "Error!!");
PrintArrayInt(zadacha50);
if (CheckNumber(zadacha50, i50, j50) == true)
{
    int resalt50 = FindNumber(zadacha50, i50, j50);
    Console.WriteLine(resalt50);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m52 = new Random().Next(1, 10);
int n52 = new Random().Next(1, 10);
int[,] zadacha52 = NewArrayInt(3, 3, 1, 9);
PrintArrayInt(zadacha52);
double[] zadacha52Doudle = AverageArithmetic(zadacha52);
Console.WriteLine();
PrinArrayDoubleOne(zadacha52Doudle);




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
static int[,] NewArrayInt(int longa, int longb, int min, int max)
{
    int[,] arr = new int[longa, longb];
    for (int i = 0; i < longa; i++)
    {
        for (int j = 0; j < longb; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}
static void PrintArrayInt(int[,] arr)
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
static double[,] NewArrayDouble(int longa, int longb, int min, int max)
{
    double[,] arr = new double[longa, longb];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = min + new Random().NextDouble() * (max - min);
        }
    return arr;
}
static void PrintArrayDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(arr[i, j], 3)}    ");
        }
        Console.WriteLine();
    }
}
static void PrinArrayDoubleOne(double[] arr)
{
    Console.WriteLine(String.Join("   ", arr));
}

static bool CheckNumber(int[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) || j > arr.GetLength(1)) return false;
    else return true;
}
static int FindNumber(int[,] arr, int i, int j)
{
    int resalt = arr[i - 1, j - 1];
    return resalt;
}
static double[] AverageArithmetic(int[,] arrInt)
{
    double[] arrDoudle = new double[arrInt.GetLength(1)];
    for (int j = 0; j < arrInt.GetLength(1); j++)
        for (int i = 0; i < arrInt.GetLength(0); i++)
        {
            arrDoudle[j] += arrInt[i, j];
        }
    for (int i = 0; i < arrDoudle.Length; i++)
    {
        arrDoudle[i] = Math.Round(arrDoudle[i] / arrInt.GetLength(1), 3);
    }
    return arrDoudle;
}

#endregion