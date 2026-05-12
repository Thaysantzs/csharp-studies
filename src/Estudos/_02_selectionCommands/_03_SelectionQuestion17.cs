/*
 * 17. Read an year and print if it is a Leap Year or Not
    https://learn.microsoft.com/en-us/office/troubleshoot/excel/determine-a-leap-year
    To determine whether a year is a leap year, follow these steps:
      1. If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
      2. If the year is evenly divisible by 100, go to step 3. Otherwise, go to step 4.
      3. If the year is evenly divisible by 400, go to step 4. Otherwise, go to step 5.
      4. The year is a leap year (it has 366 days).
      5. The year is not a leap year (it has 365 days).  
*/

using System;

class SelectionQuestion17
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
            Console.WriteLine($"{year} is a leap year");
        }else{
            Console.WriteLine($"{year} isn't a leap year");
        }
    }
}