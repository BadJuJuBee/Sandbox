using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Collections.App;

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
        for(int i = 0;i < length;i++)
        {
            var num = rand.Next();
            numbers[i] = num;
        }
        return numbers;
    }

    public static void PrintArray(int[] array)
    {
        // TODO: Print each element in the array
        for(int i = 0;i < array.Length;i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static List<string> CreateNameList()
    {
        // TODO: Create a list of 5 names
        List<string> names = new List<string>
        {
            "Jan", "Charlie", "Lenore", "Harry", "Robert"
        };
        return names;
    }

    public static void PrintList(List<string> list)
    {
        // TODO: Print each name in the list
        foreach(var name in list)
        {
            Console.WriteLine(name);
        }
    }

    public static Dictionary<string, int> CreateNameAgeDictionary()
    {
        // TODO: Create a dictionary of names and ages
        Dictionary<string, int> nameAgeDictionary = new Dictionary<string, int>
        {
        {"Billy Bob", 59},
        {"Mary Jane", 51},
        {"Jasmine Jones", 2},
        {"Aladdin Jones", 3},
        };
        return nameAgeDictionary;
    }

    public static void PrintDictionary(Dictionary<string, int> nameAgeDictionary)
    {
        // TODO: Print each key-value pair in the dictionary
        foreach(var kvp in nameAgeDictionary)
        {
            Console.WriteLine($"{kvp.Key} is {kvp.Value}");
        }
    }

    public static KeyValuePair<string, int> FindOldestPerson(Dictionary<string, int> nameAgeDictionary)
    {
        var maxKVP = nameAgeDictionary.MaxBy(kvp => kvp.Value);
        var oldestName = maxKVP.Key;
        var maxAge = maxKVP.Value;
        // TODO: Find the name and age of the oldest person in the dictionary

        return new KeyValuePair<string, int>(oldestName, maxAge);
    }

    public static double CalculateAverage(int[] numbers)
    {
        double sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        // TODO: Calculate the sum of the numbers
        return sum / numbers.Length;
    }
}
