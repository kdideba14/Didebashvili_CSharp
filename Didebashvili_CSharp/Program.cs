using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Your name: ");
        string name = Console.ReadLine();

        if (name == "Vyacheslav")
        {
            Console.WriteLine("Hello, Vyacheslav");
        }
        else
        {
            Console.WriteLine("No such name");
        }

        Console.WriteLine("Please press enter to exit application");

        Console.ReadLine();
    }
}