using System;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter the numbers you want to check separated by comma symbol (,) ");
        Console.WriteLine("Example input: 6,35,66,3");
        Console.Write("Your input: ");

        string strInput = Console.ReadLine();
       
        string[] arrayOfStrings = strInput.Split(",");
        Console.WriteLine("The following numbers are multiples of three: ");
        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            if(IsMultipleOfThree( Convert.ToInt32( arrayOfStrings[i]) ) )
            {
                Console.WriteLine(arrayOfStrings[i]);
            }
        }

        Console.WriteLine("Please press enter to exit application");
        Console.ReadLine();

    }

    static bool IsMultipleOfThree(int num) 
    {
        if (num % 3 == 0)
        {
            return true;
        }
        return false;
    }

}