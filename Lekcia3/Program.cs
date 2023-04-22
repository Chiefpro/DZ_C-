using System;
class Lekcia3
{
    static void Main()
    {
        string tt = "Привет, этот текс нужно поменять на что-то. что хз";
        int[] arr = { 9, 3, 1, 2, 7, 5, 8, 6, 4 };
        Zadacha2(arr);
       string newtt =  Zadacha1(tt, ' ', '*');
       Console.WriteLine(newtt);
    }
    static void Zadacha2(int[] array)
    {

        int max;
        int temp = array[0];


        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            max = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[max])
                {
                    max = j;
                }
            }
            temp = array[i];
            array[i] = array[max];
            array[max] = temp;
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

    }
    static string Zadacha1(string ss, char s, char n)
    {
        string res = String.Empty;
        int len = ss.Length;
        for (int i = 0; i < len; i++)
        {
                if (ss[i] == s) res = res + $"{n}";
                else res = res + $"{ss[i]}";
        }



        return res;
    }
}
