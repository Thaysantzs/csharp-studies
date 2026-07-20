/*
 * 14. Read an integer number and determine if it is a prime number or not.
*/

using System;

class RepetitionQuestion14
{
    public static void Main(string[] args)
    {
        Console.Write("Number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }

        }

        if (isPrime == true && number != 1)
        {
            Console.Write($"The number {number} is Prime");
        }
        else
        {
            Console.Write($"The number {number} is not 2Prime");
        }
    }
}