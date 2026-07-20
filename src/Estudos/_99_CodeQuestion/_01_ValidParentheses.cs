using System;
using DataStructures.Stack;
namespace CodeQuestion.Stack;

public class ValidParenthesesApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ValidParenthesesApp.IsValid("{([])}") == true);
        Console.WriteLine(ValidParenthesesApp.IsValid("()") == true);
        Console.WriteLine(ValidParenthesesApp.IsValid("}") == false);
        Console.WriteLine(ValidParenthesesApp.IsValid("{([])})") == false);
        Console.WriteLine(ValidParenthesesApp.IsValid("{([])}{[") == false);
        Console.WriteLine(ValidParenthesesApp.IsValid("([)]") == false);
    }

    private static bool IsValid(string s)
    {
        string OpenBrackest = "[{(";
        string CloseBrackest = "]})";

        var stack = new Stack<char>();

        foreach(var c in s)
        {
            int OpenIndex = OpenBrackest.IndexOf(c);
            int CloseIndex = CloseBrackest.IndexOf(c);

            if(OpenIndex != -1) // if find caracter in string 
            {
                stack.Push(c);
            }
            else // if not found carcter in string
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char lastOpen = stack.Pop();

                if(lastOpen != OpenBrackest[CloseIndex])
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}

