﻿namespace Collections.App;

public class Program
{
    static void Main(string[] args)
    {
        // 1. Generate an array of 10 random numbers and print it
        int[] randomNumbers = GenerateRandomNumbers(10);
        Console.WriteLine("Array of Random Numbers:");
        PrintArray(randomNumbers);

        // 2. Create a list of names and print it
        List<string> names = CreateNameList();
        Console.WriteLine("\nList of Names:");
        PrintList(names);

        // 3. Create a dictionary of names and ages and print it
        Dictionary<string, int> nameAgeDictionary = CreateNameAgeDictionary();
        Console.WriteLine("\nDictionary of Names and Ages:");
        PrintDictionary(nameAgeDictionary);

        // 4. Find the oldest person in the dictionary and print their name and age
        var oldestPerson = FindOldestPerson(nameAgeDictionary);
        Console.WriteLine($"\nThe oldest person is {oldestPerson.Key} with an age of {oldestPerson.Value}.");

        // 5. Calculate and print the average of the random numbers
        double average = CalculateAverage(randomNumbers);
        Console.WriteLine($"\nThe average of the random numbers is: {average:F2}");

        // 6. Remove a name from the list and print the updated list
        names.Remove("Charlie");
        Console.WriteLine("\nList of Names after removing 'Charlie':");
        PrintList(names);
    }

    public static int[] GenerateRandomNumbers(int length)
    {
        Random rand = new Random();
        int[] numbers = new int[length];
        // TODO: Populate the array with random numbers between 1 and 100
        return numbers;
    }

    public static void PrintArray(int[] array)
    {
        // TODO: Print each element in the array
    }

    public static List<string> CreateNameList()
    {
        // TODO: Create a list of 5 names
        List<string> names = new List<string>();
        return names;
    }

    public static void PrintList(List<string> list)
    {
        // TODO: Print each name in the list
    }

    public static Dictionary<string, int> CreateNameAgeDictionary()
    {
        // TODO: Create a dictionary of names and ages
        Dictionary<string, int> nameAgeDictionary = new Dictionary<string, int>();
        return nameAgeDictionary;
    }

    public static void PrintDictionary(Dictionary<string, int> dictionary)
    {
        // TODO: Print each key-value pair in the dictionary
    }

    public static KeyValuePair<string, int> FindOldestPerson(Dictionary<string, int> dictionary)
    {
        string oldestName = null;
        int maxAge = int.MinValue;

        // TODO: Find the name and age of the oldest person in the dictionary

        return new KeyValuePair<string, int>(oldestName, maxAge);
    }

    public static double CalculateAverage(int[] numbers)
    {
        double sum = 0;
        // TODO: Calculate the sum of the numbers
        return sum / numbers.Length;
    }
}
