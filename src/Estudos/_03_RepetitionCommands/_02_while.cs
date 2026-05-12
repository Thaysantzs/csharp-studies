/*
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/statements#1392-the-while-statement
 */

using System;

class WhileCommand
{
    public static void Main(string[] args)
    {
        // int n = 0;
        // while (n < 3)
        // {
        //     Console.Write(n);
        //     n++;
        // }


        // Read number until the user gives the number 0
        // int num = 1;
        // while (num != 0)
        // {
        //     Console.Write("Number: ");
        //     num = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine($"Number = {num}");
        // }


        // Read interge number until the user provides 0
        // and prints the sum of all number
        Console.Write("Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num != 0)
        {
            Console.Write("Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }
        Console.Write($"The sum of all numbers is {sum}");
    }
}