/*
 * 04. Read 5 integer numbers and print the biggest one.
*/

using System;

class SelectionQuestion04
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number One: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Two: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Third: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Fourth: ");
        int n4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Fifth: ");
        int n5 = Convert.ToInt32(Console.ReadLine());

        int highest = n1;
        if (n2 > highest)
        {
            highest = n2;
        }

        if (n3 > highest)
        {
            highest = n3;
        }

        if (n4 > highest)
        {
            highest = n4;
        }

        if (n5 > highest)
        {
            highest = n5;
        }

        Console.WriteLine($"The highest number is {highest}");
    }
}