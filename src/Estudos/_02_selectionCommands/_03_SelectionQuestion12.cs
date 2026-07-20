/*
 * 12. Read a single digit number and print the description (name).
*/

using System;

class SelectionQuestion12
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a single digit number: ");
        int number = Convert.ToInt16(Console.ReadLine());

        string? name;

        if (number < 0 || number > 9)
        {
            Console.WriteLine("Invalid Digit");
        }
        else
        { 
            if (number == 0)
            {
                name = "Zero";
            }
            else if (number == 1)
            {
                name = "One";
            }
            else if (number == 2)
            {
                name = "Two";
            }
            else if (number == 3)
            {
                name = "Three";
            }
            else if (number == 4)
            {
                name = "Four";
            }
            else if (number == 5)
            {
                name = "Five";
            }
            else if (number == 6)
            {
                name = "Six";
            }
            else if (number == 7)
            {
                name = "Seven";
            }
            else if (number == 8)
            {
                name = "Height";
            }
            else
            {
                name = "Nine";
            }

            Console.WriteLine(name);   
        }
    }
}