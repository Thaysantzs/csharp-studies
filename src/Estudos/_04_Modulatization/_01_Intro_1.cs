using System;
//namespace company.domain.project.module;
class ModularizationIntro1
{
    /*
    * Module, sub-routine,
    * - Functions
    * - Procedures
    */

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world of sub-routines");
        Procedure1();
        Console.WriteLine(addTwoInterges(1, 2));
        Console.WriteLine(addTwoInterges(3, 7));
        Console.WriteLine(addTwoInterges(15, -5));
        Console.WriteLine(addTwoInterges(8, 12));
    }

    public static void Procedure1()
    {
        Console.WriteLine("I am the procedure 1");
        Procedure2();
    }

    public static void Procedure2()
    {
        Console.WriteLine("I am the procedure 2");
        Procedure3();
    }

    public static void Procedure3()
    {
        Console.WriteLine("I am the procedure 3");
    }

    public static int addTwoInterges(int number1, int number2)
    {
        return number1 + number2;
    }
} 