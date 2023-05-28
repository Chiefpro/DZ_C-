// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region

static int Vvod(string text, string error)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int var))
            return var;
        else
            Console.WriteLine(error);
    }
}


#endregion
