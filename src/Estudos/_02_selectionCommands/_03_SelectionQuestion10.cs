/*
 * 10. Read two numbers, desired operation (+, -, *, /) and print an string representing the operation with the result
*/

using System;

class SelectionQuestion10
{
    public static void Main(string[] args)
    {
        Console.Write("Chosse a operation (+, -, *, /): ");
        string? operation = Console.ReadLine();
        Console.Write("Write number One: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Write number Two: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        if (operation == "+")
        {
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }
        else if (operation == "-")
        {
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        }
        else if (operation == "*")
        {
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        }
        else if (operation == "/")
        {
            if (number2 == 0)
            {
                Console.WriteLine("Invalid operation:  Division by Zero");
            }
            else
            { 
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            }
        }
        else
        { 
            Console.WriteLine($"Invalid operation");
        }
    }
}