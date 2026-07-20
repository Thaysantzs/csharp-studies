/*
 * 02. Read two integers numbers and print the one with highest value.
    If the values are equal, print "EQUALS".
 */

 
using System;

class SelectionQuestion02
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number One: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Two: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 == n2)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine($"The highest number is: {Math.Max(n1, n2)}");
        }
    }
}