// Задача 53:  Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
int m53 = Vvod("Введите количество строк => ", "Ошибка!!!");
int n53 = Vvod("Введите количество строк => ", "Ошибка!!!");
int[,] array53 = NewArrayIntD(m53, n53, 10, 100);
PrintArrayD(array53);
Console.WriteLine();
int[,] arr53 = Zadacha53(array53);
PrintArrayD(arr53);
Console.WriteLine();
//-------------------------------------------------------------------------------------------------------
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int m55 = Vvod("Введите количество строк => ", "Ошибка!!!");
int n55 = Vvod("Введите количество строк => ", "Ошибка!!!");
int[,] array55 = NewArrayIntD(m55, n55, 10, 100);
PrintArrayD(array55);
Console.WriteLine();
int[,] arr55 = Zadacha55(array55);
PrintArrayD(arr55);




#region 
static int Vvod(string text, string error)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int var))
            return var;
        else Console.WriteLine(error);
    }
}
static int[,] NewArrayIntD(int longa, int longb, int min, int max)
{
    int[,] array = new int[longa, longb];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    return array;
}
static void PrintArrayD(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
static int[,] Zadacha53(int[,] array)
{
    int tt = 0;
    int longb = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        tt = array[0, i];
        array[0, i] = array[longb, i];
        array[longb, i] = tt;
    }
    return array;
}
static int[,] Zadacha55(int[,] array)
{
    int longa = array.GetLength(0);
    int longb = array.GetLength(1);
    int[,] arr = new int[longa, longb];
    if (longa != longb)
    {
        Console.WriteLine("Не возможно переместить местами!!!");
        return array;
        
    }
    for (int i = 0; i < longa; i++)
        for (int j = 0; j < longb; j++)
        {
            arr[i, j] = array[j, i];
        }
    return arr;
}

#endregion
