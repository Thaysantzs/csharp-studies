using System;

namespace OurStore;

public class Products
{
    private List<Product> products;

    public Products()
    {
        products = new List<Product>();
    }

     public void Add(Product product)
    {
        products.Add(product);
    }

    public Product Add(int id, string description, double price)
    {
        Product product = new(id, description, price);
        products.Add(product);
        return product;
    }

    public Product? FindById(int id)
    {
        foreach (Product product in products)
        {
            if(product.ID == id)
            {
                return product;
            }
        }
        return null;
    }

    public void Print()
    {
        Console.WriteLine(" Products ".PadLeft(99,'-') + "".PadRight(99,'-'));
        foreach(Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("".PadLeft(198,'-'));
    } 
}