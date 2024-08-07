public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /):");
        string operation = Console.ReadLine();

        int result = 0;

        switch (operation)
        {
            case "+":
                result = Add(num1, num2);
                break;
            case "-":
                result = Subtract(num1, num2);
                break;
            case "*":
                result = Multiply(num1, num2);
                break;
            case "/":
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }

        Console.WriteLine($"The result is: {result}");
    }

    // Stub method for addition
    public static int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // Stub method for subtraction
    public static int Subtract(int a, int b)
    {
        int difference = a - b;
        return difference;
    }

    // Stub method for multiplication
    public static int Multiply(int a, int b)
    {
        int product = a * b;
        return product;
    }

    // Stub method for division
    public static int Divide(int a, int b)
    {
        int quotient = a / b;
        return quotient;
    }
}