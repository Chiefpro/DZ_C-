Console.Clear();
// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("----------------------------Задача 54-----------------------------------------------------");
int[,] arr54 = NewArrayTwo(5, 6, 10, 100);
PrintArrayTwo(arr54);
int[,] array54 = Sotr(arr54);
Console.WriteLine();
PrintArrayTwo(array54);
//----------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("----------------------------Задача 56-----------------------------------------------------");
int[,] arr56 = NewArrayTwo(6, 4, 1, 10);
PrintArrayTwo(arr56);
int line56 = FindMinSum(arr56);
Console.WriteLine($"Строка с наименьшей суммой => {line56 + 1}");
//----------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("----------------------------Задача 58-----------------------------------------------------");
int[,] firstArray = NewArrayTwo(4, 4, 10, 100);
PrintArrayTwo(firstArray);
Console.WriteLine();
int[,] twoArray = NewArrayTwo(4, 4, 10, 100);
PrintArrayTwo(twoArray);
Console.WriteLine();
int[,] matrix58 = SumMatrix(firstArray, twoArray);
PrintArrayTwo(matrix58);

//----------------------------------------------------------------------------------------------
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("----------------------------Задача 60-----------------------------------------------------");
int[,,] arr60 = NewArrayThree(2, 2, 2, 1, 10);
Console.WriteLine();
PrintArrayThree(arr60);
//----------------------------------------------------------------------------------------------
// Задача 62: Заполните спирально массив 4 на 4.
Console.WriteLine("----------------------------Задача 62-----------------------------------------------------");
int[,] arr62 = Spiral(4);
PrintArrayTwo(arr62);


#region 

static int[,] NewArrayTwo(int longa, int longb, int min, int max)
{
    int[,] array = new int[longa, longb];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}
static void PrintArrayTwo(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
static void PrintArrayThree(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}
static int[,] Sotr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int m = 0; m < arr.GetLength(1) - 2; m++)
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                int temp = 0;
                if (arr[i, j] < arr[i, j + 1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
    }
    return arr;
}
static int FindMinSum(int[,] arr)
{
    int minline = 0;
    int tempsum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
        tempsum += arr[0, i];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < tempsum)
        {
            minline = i;
            tempsum = sum;
        }
    }
    return minline;
}
static int[,,] NewArrayThree(int longa, int longb, int longc, int min, int max)
{
    int[,,] arr = new int[longa, longb, longc];


    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = UniqueNumber(arr, min, max, i, j, k);
            }

    return arr;
}
static int UniqueNumber(int[,,] arr, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool br = false;
        value = new Random().Next(min, max);
        for (int i1 = 0; i1 < arr.GetLength(0); i1++)
        {
            if (br)
            {
                break;
            }
            for (int j1 = 0; j1 < arr.GetLength(1); j1++)
            {
                if (br)
                {
                    break;
                }
                for (int k1 = 0; k1 < arr.GetLength(2); k1++)
                {
                    if (arr[i1, j1, k1] == value)
                    {
                        br = true;
                        break;
                    }
                    if (i1 == i && j1 == j && k1 == k)
                    {
                        exist = false;
                    }
                }
            }
        }
    }
    return value;
}
static int[,] Spiral(int longa)
{
    int[,] arr = new int[longa, longa];
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < longa * longa; e++)
    {
        int k = 0;
        do { arr[i, j++] = value++; } while (++k < longa - 1);
        for (k = 0; k < longa - 1; k++) arr[i++, j] = value++;
        for (k = 0; k < longa - 1; k++) arr[i, j--] = value++;
        for (k = 0; k < longa - 1; k++) arr[i--, j] = value++;
        ++i; ++j;
        longa = longa < 2 ? 0 : longa - 2;
    }
    return arr;
}
static int[,] SumMatrix(int[,] arr1, int[,] arr2)
{
    int[,] resalt = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < resalt.GetLength(0); i++)
    {
        for (int j = 0; j < resalt.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            resalt[i, j] = sum;
        }
    }
    return resalt;
}



#endregion