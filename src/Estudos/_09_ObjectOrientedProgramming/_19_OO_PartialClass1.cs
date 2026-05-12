using System;

namespace OurCompany.LearnCoding.OOP.PartialClass;

public class PartialClassApp
{
    public static void Main(string[] args)
    {
        Customer person = new Customer("TRF22", "Thiago Rodrigues");
        Console.WriteLine(person);
    }
}

public partial class Customer
{
    public string? ID { get; set; }

    public Customer(string id, string name)
    {
        ID= id;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {ID}; Name: {Name}";
    }
}