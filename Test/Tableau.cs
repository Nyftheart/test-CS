

public class Tableau
{
    public static void Table()
    {
        int[] array1 = { 0, 1, 3, 3, 3, 3, 3, 1, 0 };
        int[] array2 = { 1, 2, 1, 3, 1, 4, 1, 5, 1 };
        int[] array3 = { 1, 1, 1, 3, 3, 3, 1, 1, 1, 5, 5, 5, 1, 1 };
        int[] array4 = { 9, 9, 9, 9, 9, 9, 9, 9, 8 };
        int[] array5 = { 9, 9, 9, 9, 9, 9, 9, 9, 9 };

        Console.WriteLine("chiffre array1: " + mostAppear(array1));
        Console.WriteLine("chiffre array2: " + mostAppear(array2));
        Console.WriteLine("chiffre array3: " + mostAppear(array3));
        Console.WriteLine("chiffre array4: " + mostAppear(array4));
        Console.WriteLine("chiffre array5: " + mostAppear(array5));

        Console.ReadLine();
    }

    public static int mostAppear(int[] array)
    {
        Dictionary<int, int> numberCount = new Dictionary<int, int>();

        foreach (int number in array)
        {
            if (numberCount.ContainsKey(number))
            {
                numberCount[number]++;
            }
            else
            {
                numberCount[number] = 1;
            }
        }

        int maxCount = numberCount.Values.Max();
        int mostFrequentNumber = numberCount.FirstOrDefault(x => x.Value == maxCount).Key;

        return mostFrequentNumber;
    }
}