using System;

public class Alpha
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Main()
    {
        Console.WriteLine("nom :");
        string name = Console.ReadLine();

        string convertedName = ConvertNameToIndices(name);

        Console.WriteLine("indice: " + convertedName);
        Console.ReadLine();
    }

    public static string ConvertNameToIndices(string name)
    {
        string result = "";

        foreach (char letter in name.ToLower())
        {
            int index = alphabet.IndexOf(letter);

            if (index != -1)
            {
                result += index.ToString();
            }
        }

        return result;
    }
}