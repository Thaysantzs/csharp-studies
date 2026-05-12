/*
 * 05. Read 3 integers and print them in ascending order. (non descending)
 */

using System;

class SelectionQuestion05
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number One: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Two: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number Third: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 <= n2 && n1 <= n3)// n1 is smaller
        { 
            if (n2 <= n3)
            {
                Console.WriteLine($"{n1}, {n2}, {n3}");
            }
            else
            {
                Console.WriteLine($"{n1}, {n3}, {n2}");
            }
        }
        else if (n2 <= n1 && n2 <= n3)// n2 is smaller
        {
            if (n1 <= n3)
            {
                Console.WriteLine($"{n2}, {n1}, {n3}");
            }
            else
            {
                Console.WriteLine($"{n2}, {n3}, {n1}");
            }
        }
        else // n3 is smaller
        { 
            if (n1 <= n2)
            {
                Console.WriteLine($"{n3}, {n1}, {n2}");
            }
            else
            {
                Console.WriteLine($"{n3}, {n2}, {n1}");
            }
        }
    }
}