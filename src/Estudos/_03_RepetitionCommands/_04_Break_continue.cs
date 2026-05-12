/*
 https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements
 */

using System;

class BreakandContinue
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 9; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.Write($"{i}, ");
        }

        
        for (int i = 0; i < 9; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.Write($"{i}, ");
        }
    }
}