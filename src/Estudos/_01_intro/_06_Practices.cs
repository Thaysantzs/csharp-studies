using System;
using System.Text.Json.Serialization;

class Practices
{
    public static void Main(string[] args)
    {
        // 01 - Read a value in miles  and  convert to Kilometers: 1 Mile = 1.6KM

        // Console.Write("Enter a value in miles: ");
        // double miles = Convert.ToDouble(Console.ReadLine());
        // double valorKilometers = miles * 1.60934;
        // Console.WriteLine("Value in Kilometers: " + valorKilometers);

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 02 - Read an interge number and print the three predecessors an successors

        // Console.Write("Type an interge number: ");
        // int num = Convert.ToInt16(Console.ReadLine());
        // Console.WriteLine($"Predecessors: {num - 3}, {num - 2}, {num - 1}");
        // Console.WriteLine($"Successors: {num + 1}, {num + 2}, {num + 3}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 03 - Read two interger numbers A and B and print the result of all Arithmetic operations you know for A and B. Operations: + - * / %

        // Console.Write("A = ");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("b = ");
        // int b = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"A + B = {a + b}");
        // Console.WriteLine($"A - B = {a - b}");
        // Console.WriteLine($"A * B = {a * b}");
        // Console.WriteLine($"A / B = {a / b} (interger)");
        // Console.WriteLine($"A / B = {a / (double)b} (double)");
        // Console.WriteLine($"A % B = {a % b}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 04 - Read three interge numbers and calculate the average

        // Console.Write("Enter a number interge: ");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter other number interge: ");
        // int b = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter more a number interge: ");
        // int c = Convert.ToInt32(Console.ReadLine());
        // double average = (a + b + c) / 3;

        // Console.WriteLine($"The averege is: {average}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 05 - Read The base and length of a rectangle and calculate it's area.

        // Console.Write("Base: ");
        // double baseValue = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Length: ");
        // double lengthValue = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine($"Area = {baseValue * lengthValue}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 06 - Read an interge  and print  True if number is Even and False it is odd

        // Console.Write("Enter a number: ");
        // int num = Convert.ToInt16(Console.ReadLine());

        // int rest = num % 2;

        // Console.Write("The number is Even: ");
        // Console.Write(rest == 0);

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 07 - Read the temperature in celsius and  convert to Fharenheit: F = C * 1.8 + 32

        // Console.Write("Enter the temperature to converter to Fharenheit: ");
        // double c = Convert.ToInt32(Console.ReadLine());

        // double f = (c * 1.8) + 32;
        // Console.WriteLine("The temperature in Fharenheit is: " + f);

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // Read the buying price (cost), the disered profit percentage and calculate the sales price of a product

        // Console.Write("Enter The buying price: ");
        // double buyingPrice = Convert.ToDouble(Console.ReadLine());

        // Console.Write("Enter The disered profit percentage: ");
        // double diseredProfit = Convert.ToDouble(Console.ReadLine());

        // double salesPrice = buyingPrice + (buyingPrice * (diseredProfit / 100));
        // Console.WriteLine("Sales price is: R$" + salesPrice);

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 09 - Read the buying price (cost), the desired profit percentage and the sales tax % and calculate the final sales price of a product.

        // Console.Write("Buying Price: ");
        // double buyingPrice = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Profit: ");
        // double profit = Convert.ToDouble(Console.ReadLine());
        // Console.Write("tax: ");
        // double tax = Convert.ToDouble(Console.ReadLine()); ;

        // double newTax = buyingPrice * (tax / 100);
        // double value = buyingPrice + newTax + (buyingPrice * (profit / 100));

        // Console.Write($"Value: ${value}, Value of tax: ${newTax.ToString("F2")}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 10 - Read the name, salary and salary increase percentage and print the name and  the new salary.

        // Console.Write("Name: ");
        // string? name = Console.ReadLine();
        // Console.Write("Salary: ");
        // double salary = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Salary Increase % : ");
        // double salaryIncreasePercentege = Convert.ToDouble(Console.ReadLine());

        // double salaryIncrease = salary * (salaryIncreasePercentege / 100);
        // double newSalary = salary + salaryIncrease;

        // Console.WriteLine($"Name: {name}; New Salary: {newSalary}; Salary increase: {salaryIncrease}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 11 - Read the name, salary, years of experience and the numbers of kids of a employee and calculate the name and the new salary using the following formula: 0.5% per year of experience|2% per kid

        // Console.Write("Type your name: ");
        // string? name = Console.ReadLine();
        // Console.Write("Type your Salary: ");
        // double salary = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Years of experience: ");
        // double experience = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Type the number of children: ");
        // double children = Convert.ToDouble(Console.ReadLine());

        // double yearsExperience = experience * 0.5;
        // double numberKids = children * 0.02;
        // double newSalary = salary + (salary * ((yearsExperience + numberKids) / 100));

        // Console.WriteLine($"Name: {name}, Number of kids: {children}, Years of experience: {experience}");
        // Console.WriteLine($"New salary : ${newSalary}\nIncrease percentage: ${newSalary - salary}");



        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------

        // 12 - Read two integer numbers and swap the variables content

        // Console.Write("Enter the number One: ");
        // double numberOne = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Enter the number Two: ");
        // double numberTwo = Convert.ToDouble(Console.ReadLine());

        // double axu = numberOne;
        // numberOne = numberTwo;
        // numberTwo = axu;

        // Console.WriteLine($"number One = {numberOne} and number Two: {numberTwo}");
        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 13 - Read the duration of an experiment in seconds and calculate the duration in Hours, Minutes and Seconds

        // Console.Write("Enter tho number in seconds: ");
        // double number = Convert.ToDouble(Console.ReadLine());

        // int hours = (int)(number / 3600);
        // int minutes = (int)(60 * ((number % 3600) / 3600));
        // int seconds = (int)(number % 60);

        // Console.WriteLine($"\n{number} seconds in Hours --> {hours}:{minutes}:{seconds}");
        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------


        // 14 - Read an integer number with 6 digits and separate it into two integers with 3 digits each

        // Console.Write("Enter Whit 6 integer numbers: ");
        // int intergerNumber = Convert.ToInt32(Console.ReadLine());

        // int firstNumbers = intergerNumber / 1000;
        // int secondsNumber = intergerNumber % 1000;

        // Console.Write($"{firstNumbers} and {secondsNumber}");

        // Console.Write("\nPress any key to close...");
        // Console.ReadKey();
        //--------------------------------------------------------------------------------

        // 15 - Read an integer number with 6 digits and generate a new number with the digits in reverse order

        Console.Write("Enter whit 6 integer numbers: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int lastNumber = number % 10;
        int divisorNumber = number / 10;

        int newNumber = lastNumber * 10;
        number = divisorNumber;

        lastNumber = number % 10;
        divisorNumber = number / 10;

        newNumber += lastNumber;
        newNumber = newNumber * 10;

        number = divisorNumber;

        lastNumber = number % 10;
        divisorNumber = number / 10;

        newNumber += lastNumber;
        newNumber = newNumber * 10;

        number = divisorNumber;

        lastNumber = number % 10;
        divisorNumber = number / 10;

        newNumber += lastNumber;
        newNumber = newNumber * 10;

        number = divisorNumber;

        lastNumber = number % 10;
        divisorNumber = number / 10;

        newNumber += lastNumber;
        newNumber = newNumber * 10;

        number = divisorNumber;

        lastNumber = number % 10;
        divisorNumber = number / 10;

        newNumber += lastNumber;
        Console.Write($"The reverse number is: {newNumber}");
        Console.ReadKey();
        //--------------------------------------------------------------------------------
    }
}  