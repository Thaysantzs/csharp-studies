/*
 * 14. Read an age and print the age classification using the table below
 *   - unborn      = 0
 *   - Infant:     < 1
 *   - Child:      1 to 12 years
 *   - Adolescent: 13 to 17
 *   - Adult:      18 to 55
 *   - Senior:     56 to 75
 *   - Elderly:    76+
*/



using System;

class SelectionQuestion14
{
    public static void Main(string[] args)
    {
        Console.Write("Enter with your age: ");
        double age = Convert.ToDouble(Console.ReadLine());

        string classification;

        if (age == 0)
        {
            classification = "Unborn";
        }
        else if (age < 1)
        {
            classification = "Infant";
        }
        else if (age <= 12)
        {
            classification = "Child";
        }
        else if (age <= 17)
        {
            classification = "Adolescent";
        }
        else if (age <= 55)
        {
            classification = "Adult";
        }
        else if (age <= 75)
        {
            classification = "Senior";
        }
        else
        {
            classification = "Elderly";
        }
        Console.WriteLine($"The age {age} is {classification}");
    }
}