/*
 * 05. Read integer numbers (flag = empty) and print the highest value.
*/

using System;

class RepetitionQuestion05
{
    public static void Main(string[] args)
    {
        Console.Write("Number = ");   
        int highestNumber = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            Console.Write("Number = ");
            string? numAsString = Console.ReadLine();

            if (numAsString == "")
            {
                break;
            }

            int number = Convert.ToInt32(numAsString);
            if (highestNumber < number)
            {
                highestNumber = number;
            }
        }

        Console.Write($"The highest number is {highestNumber}");
    }
}