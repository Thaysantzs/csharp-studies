
/*
 * 07. Read integer numbers (flag = empty) and print the smallest value and it's frequency.
*/

using System;

class RepetitionQuestion07
{
    public static void Main(string[] args)
    {
        string? numberStr;
        int number;
        int? lowest = null;
        int lowestFrequency = 0;

        do
        {
            Console.Write("Number: ");
            numberStr = Console.ReadLine();

            if (numberStr != string.Empty)
            {
                number = Convert.ToInt32(numberStr);
                if ((!lowest.HasValue) || number < lowest)
                {
                    lowest = number;
                    lowestFrequency = 1;
                }
                else if (number == lowest)
                {
                    lowestFrequency++;
                }
            }
        } while (numberStr != string.Empty);

        if (lowest.HasValue)
        {
            Console.Write($"Lowest = {lowest}; Frequency = {lowestFrequency}");
        }
        else
        {
            Console.Write("No values provied");
        }
    }
}