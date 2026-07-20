/*
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement
 */

 using System;

class DoWhileCommand
{
    public static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.Write($"{i}, ");
            i++;
        } while (i <= 10);
    }
}