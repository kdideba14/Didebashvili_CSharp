using System;

static class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please, enter number: ");
        string userInput = Console.ReadLine();
        decimal num;
        num = Convert.ToDecimal(userInput);
     

        if (NumIsMoreThanSeven(num))
        {
            Console.WriteLine("Hello");
        }

        Console.WriteLine("Please press enter to exit application");
        Console.ReadLine();

    }

    static bool NumIsMoreThanSeven(decimal a)
    {
        if (a > 7)
        {
            return true;
        }
        return false;
    }
}


