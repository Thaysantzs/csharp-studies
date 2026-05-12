/*
 * Customer
   Attributes
   * First Name
   * Last Name
   * Phone Number
   * Email
   * Username
   * Password
   * Address
     * Street #
     * Street Name
     * Apt #
     * Postalcode
     * State
     * Country
   * Driver's License #
   * Dependents
   * ...
   Operations
   * Registration
   * Send Email
   * Charge Payment
   * Send Invoice
   * ... 
 */

/*
 * Customer
   Attributes
   * First Name
   * Last Name
   * Phone Number
   * Email
   * Username
   * Password
 */

 using System;

public class Customer
{
    private string? firstName;
    private string? lastName;

    public Customer(string firstName, string lastName)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
    }

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string? GetFirstName()
    {
        return firstName;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string? GetLastName()
    {
        return lastName;
    }

    public string? GetFullName()
    {
        return $"{GetFirstName()} {GetLastName()}";
    }
}


public class OO_Class_App
{
    public static void Main(string[] args)
    {
        Customer customerA = new Customer("Thiago", "Santiago");
        Console.WriteLine($"FullName: {customerA.GetFullName()}");
    }
}