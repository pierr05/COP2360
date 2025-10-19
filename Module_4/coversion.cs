using System;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            int result = Divide(number1, number2);
            Console.WriteLine($"The result of {number1} divided by {number2} is {result}.");
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Error: one or both of the inputs are not valid integers.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        // Added OverflowException catch block for too large/small inputs
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: one or both of the inputs are too large or too small for an Int32.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division by zero is not allowed");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit....");
        Console.ReadKey();
    }
    static int Divide(int a, int b)
    {
        return a / b;
    }
} 