using System;

public class Pair
{
    public static void Chifre()
    {
        Console.WriteLine("nombre :");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine("nombre pair.");
        }
        else
        {
            Console.WriteLine("nombre impair.");
        }

        Console.ReadLine();
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}