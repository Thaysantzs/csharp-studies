/*
 * 03. Read two integer numbers representing an interval and print all even numbers inside the interval.
*/
using System;

class RepetitionQuestion03
{
    public static void Main(string[] args)
    {
        Console.Write("Write a integer number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write another integer number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 < n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0)
                { 
                    Console.Write($"{i}, ");
                }
            }
        }
        else
        { 
            for (int i = n1; i >= n2; i--)
            {
                if (i % 2 == 0)
                { 
                    Console.Write($"{i}, ");
                }
            }
        }

    }
}