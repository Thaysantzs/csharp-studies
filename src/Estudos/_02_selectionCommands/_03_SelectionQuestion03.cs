/*
 * 03. Read 3 integers and print the highest value.
*/

using System;

class SelectionQuestion03
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number One: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Two: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Third: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 == n2 && n2 == n3)
        {
            Console.WriteLine("The numbers is Equals");
        }
        else if (n1 > n2)
        {
            Console.WriteLine($"The highest number is: {n1}");
        }
        else
        {
            Console.WriteLine($"The highest number is: {Math.Max(n2, n3)}");
        }
    }
}