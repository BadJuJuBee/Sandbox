using System.Collections;
using System.ComponentModel;

namespace ControlFlow.App;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Control Flow Assignment");

        // Example usage
        Console.WriteLine("Enter a animal:");
        string animal = Console.ReadLine();

        Console.WriteLine("Is the animal a dog? " + IsDog(animal));
        Console.WriteLine("The sound of the animal is: " + GetAnimalSound(animal));
        PrintAnimalSound10Times(GetAnimalSound(animal));
    }

    // Method to check if a number is even
    public static bool IsDog(string animal)
    {
        if (animal.ToLower() == "dog")
        {
            return true;
        }
        return false;
    }

    // Method to get the animal sound for a dog, cat, cow, or sheep
    public static string GetAnimalSound(string animal)
    {   switch (animal.ToLower())
    {
        case "dog":
        {
            return "bark";
        }
        case "cat":
        {
            return "meow";
        }
        case "cow":
        {
            return "moo";
        }
        case "sheep":
        {
            return "baa";
        }
        default:
        {
            return "unknown sound";
        }
    }
        // if (animal.ToLower() == "dog")
        // {
        //     return "bark";
        // }
        // else if (animal.ToLower() == "cat")
        // {
        //     return "meow";
        // }
        // else if (animal.ToLower() == "cow")
        // {
        //     return "moo";
        // }
        // else if (animal.ToLower() == "sheep")
        // {
        //     return "baa";
        // }
        // return "unknown sound";
    }

    // Method to print the animal sound 10 times
    public static void PrintAnimalSound10Times(string sound)
    {
        int index = 0;
        do
        {
            Console.WriteLine(sound);
            index = index + 1;
        }  while(index < 10);
    }

}
