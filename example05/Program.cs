Console.Write("Как вас зовут? ");
string username = Console.ReadLine();
if (username.ToLower() == "вася")
    {
        Console.WriteLine("Привет Васек!!!!");
    }
    else
    {
        Console.WriteLine("привет " + username);
    }