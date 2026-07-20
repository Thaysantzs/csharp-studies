/* 
7. Read an age and print "Minor" if the age is smaller than 18
*/

using System;

class SelectionQuestion07
{
    public static void Main(string[] args)
    {
        Console.Write("Write your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age > 0)
        {
            if (age < 18)
            {
                Console.WriteLine("Age is smaller than 18");
            }
            else
            {
                Console.WriteLine("Age is highest than 18");
            }
        }
        else
        {
            Console.WriteLine("Idade invalida!");
        }

    }
}