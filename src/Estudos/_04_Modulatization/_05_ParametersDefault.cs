using System;
using Ourcompany;

public class Parametersdefault
{
    public static void Main(string[] args)
    {
        int number1 = Library.ReadInterge("Number 1" , ":");
        int number2 = Library.ReadInterge("Number 2", "=");
        int number3 = Library.ReadInterge("Number 3", "=>");
        int number4 = Library.ReadInterge("Number 4");
        int number5 = Library.ReadInterge("Number 5");
        int number6 = Library.ReadInterge();
    }
}