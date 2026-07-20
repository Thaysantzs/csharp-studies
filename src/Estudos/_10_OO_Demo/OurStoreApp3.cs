using System;

namespace OurStore;


public class OurStoreApp3
{
    public static void Main(string[] args)
    {
        Customers customers = new Customers();
        Products products = new Products();

        while (true)
        {
            Console.Clear();
            int option = GetMenuOption();

            switch (option)
            {
                case 0:
                    return;
                case 1:
                    AddCustomer(customers);
                    break;
                case 2:
                    AddProducts(products);
                    break;
                case 3:
                    AddOrder(customers, products);
                    break;
                case 4: 
                    PrintCustomers(customers);
                    break;
                case 5: 
                    PrintProducts(products);
                    break;
                case 6: 
                    PrintOrder(customers);
                    break;
            }
            Console.Write("Press any Key... ");
            Console.ReadKey();
        }
    }

    private static void AddCustomer(Customers customers)
    {
       Console.Write("Email: ");
       string? email = Console.ReadLine();

       Console.Write("Name: ");
       string? name = Console.ReadLine();

       Console.Write("Address: ");
       string? address = Console.ReadLine();

       customers.Add(email, name, address);
    }

    private static void AddProducts(Products products)
    {
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Description of Product: ");
        string? description = Console.ReadLine();

        Console.Write("Price: ");
        double price = Convert.ToInt32(Console.ReadLine());

        products.Add(id, description, price);
    }

    private static void AddOrder(Customers customers, Products products)
    {
        Console.Write("Email: ");
        string? email = Console.ReadLine();
        Customer? customer = customers.FindByEmail(email);
        Order? order =  customer.AddOrder();
        while (true)
        {
            products.Print();

            Console.Write("Id Of Products: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            order.AddProduct(products.FindById(id), quantity);

            Console.Write("Type 0 to exit or 1 to continue: ");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if(option == 0)
            {
                break;
            }
        }

    }

    private static void PrintCustomers(Customers customers)
    {
        customers.Print();
    }

    private static void PrintProducts(Products products)
    {
        products.Print();
    }

    private static void PrintOrder(Customers customers)
    {
        Console.Write("Email: ");
        string? email = Console.ReadLine();

        Customer? customer = customers.FindByEmail(email);
        customer.PrintOrders();
    }

    private static int GetMenuOption()
    {
        Console.WriteLine("----------------- Select an Option -----------------");
        Console.WriteLine("0: Exit");
        Console.WriteLine("1: Add a customer");
        Console.WriteLine("2: Add a product");
        Console.WriteLine("3: Create order");
        Console.WriteLine("4: Print customers");
        Console.WriteLine("5: Print products");
        Console.WriteLine("6: Print Order");
        Console.Write("Option: ");
        int option =  Convert.ToInt32(Console.ReadLine());
        return option;
    }
} 