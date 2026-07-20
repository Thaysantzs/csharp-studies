/*
 * 13. Read an letter and print if it is a consonant or vowel
*/

using System;

class SelectionQuestion13
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a letter: ");
        string? letter = Console.ReadLine();

        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Console.Write($"The letter '{letter}' is a Vowel");
        }
        else
        { 
            Console.Write($"The letter '{letter}' is a Consonant");
        }
    }
}


