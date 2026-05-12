/*
 * 08. Read an age and print "Minor" if the age is smaller than 18 and 
    "ADULT" otherwise
*/

using System;

class SelectionQuestion08
{
    public static void Main(string[] args)
    {
        Console.Write("Write your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine("Minor");
        }
        else
        { 
            Console.WriteLine("Adult");
        }

    }
}