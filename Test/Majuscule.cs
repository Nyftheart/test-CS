using System;

public class Majuscule
{
    public static void maj()
    {
        Console.WriteLine("texte :");
        string userInput = Console.ReadLine();
        
        string upperCaseText = ConvertToUpper(userInput);
        
        Console.WriteLine("majuscule : " + upperCaseText);
        Console.ReadLine();
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}