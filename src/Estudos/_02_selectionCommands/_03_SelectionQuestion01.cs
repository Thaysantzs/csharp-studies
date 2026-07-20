/*
 * 01. Read two integers numbers and print the one with highest value.
    Assume the values are not the same
*/


using System;

class SelectionQuestion01
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number One: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Two: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine(n1);
        }
        else
        {
            Console.WriteLine(n2);
        }
    }
}