/*
 * 06. Read a integer number and print if it is positive or negative.
*/

using System;

class SelectionQuestion06
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number One: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if (n1 > 0)
        {
            Console.WriteLine("Number Positive");
        }
        else if (n1 < 0)
        {
            Console.WriteLine("Number Negative");
        }
    }
}