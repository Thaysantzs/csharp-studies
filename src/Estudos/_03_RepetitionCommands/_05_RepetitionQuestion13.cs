/*
 * 13. Read an integer number with any length and reverse it's digits.
    e.g
    Input = 12345
    Output = 54321
*/

using System;

class RepetitionQuestion13
{
    public static void Main(string[] args)
    {
        Console.Write("Number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        int numberAux = number;
        int numberInverted = 0;

        while (numberAux != 0)
        {
            int lastDigit = numberAux % 10;
            numberInverted = numberInverted * 10 + lastDigit;
            numberAux /= 10;
        }
        Console.Write($"The inverse of {number} is {numberInverted}");
    }
}