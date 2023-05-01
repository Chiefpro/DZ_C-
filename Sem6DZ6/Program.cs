Console.Clear();
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int d41 = Vvod("Ввевдите количество цифр ", "Error!!!");
int[] array41 = VvodArray(d41);
Console.WriteLine(String.Join(" ", array41));
Console.WriteLine($"Число положительных чисел => {FindPolozhitelnie(array41)}");
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int b1 = Vvod("Введи b1 => ", "Error!!");
int k1 = Vvod("Введи k1 => ", "Error!!");
int b2 = Vvod("Введи b2 => ", "Error!!");
int k2 = Vvod("Введи k2 => ", "Error!!");
Fider(b1, k1, b2, k2);






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
static int[] VvodArray(int dlina)
{
    int[] arr = new int[dlina];
    //int p = 0;
    for (int i = 0; i < arr.Length; i++)
        while (true)
        {
            Console.Write($"Введи {i + 1}ое число => ");
            if (int.TryParse(Console.ReadLine(), out arr[i]))
                break;
            Console.WriteLine("Error!!!");
        }
    return arr;
}
static int FindPolozhitelnie(int[] arr)
{
    int i = 0;
    foreach (int el in arr)
    {
        if (el > 0) i++;
    }
    return i;
}
static void Fider(int b1, int k1, int b2, int k2)
{
    float x, y;
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"X = {x} <=>  Y = {y}");
    }
}
#endregion