/*
 * 09. Read an integer number and print if the number is Even or Odd 
*/

using System;

class SelectionQuestion09
{
    public static void Main(string[] args)
    {
        Console.Write("Write a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.Write($"The number {number} is Even");
        }
        else
        {
            Console.Write($"The number {number} is Odd");
        }
    }
}