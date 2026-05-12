using System;
using System.IO.Pipes;

namespace OurCompany.LearningCoding.OOP.Indexers;

public class IndexersApp
{
    public static void Main(string[] args)
    {
        Customers customers = new Customers(10);

        customers.add(new Customer("batman_waynne@gmail.com", "Bruce Waynne"));
        customers.add(new Customer("super_man@gmail.com", "Karl cripto"));
        customers.add(new Customer("flash@gmail.com", "Barry Allan"));
        customers.add(new Customer("HomenAranhga@gmail.com", "Petter Park"));

        Customer? bruce = customers["batman_waynne@gmail.com"];
        Console.WriteLine(bruce);

        Customer? karl = customers["super_man@gmail.com"];
        Console.WriteLine(karl);

        Console.WriteLine(customers["flash@gmail.com"]);
        customers["flash@gmail.com"] = new Customer("flashVelocidade@gmail.com", "Barry Alan");
        Console.WriteLine(customers["flash@gmail.com"]);
        Console.WriteLine(customers["flashVelocidade@gmail.com"]);
    }
}

public class Customer
{
    public string? Email {get; set;}
    public string? Name { get; set; }

    public  Customer(string email, string name)
    {
        Email = email;
        Name = name;
    }

    public override string ToString()
    {
        return $"[Email: {Email}    Name: {Name}]";
    }
}


public class Customers
{
    private Customer[] customers;
    private int newIndexCustomer;

    public Customers(int capacity)
    {
        customers = new Customer[capacity];
        newIndexCustomer = 0;
    }

    public Customer? this[string? email]
    {
        get
        {
            for (int i = 0; i < newIndexCustomer; i++)
            {
                if(customers[i].Email == email)
                {
                    return customers[i];
                }
            }
            return null;
        }

        set
        {
            for (int i = 0; i < newIndexCustomer; i++)
            {
                if(customers[i].Email == email)
                {
                    #pragma warning disable CS8601 // Possible null reference assignment.
                    customers[i] = value;
                    #pragma warning restore CS8601 // Possible null reference assignment.
                }
            }
        }
    }

    public void add(Customer customer)
    {
        customers[newIndexCustomer] = customer;
        newIndexCustomer++;
    }
}