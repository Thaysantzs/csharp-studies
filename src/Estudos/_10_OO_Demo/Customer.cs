
namespace OurStore;

public class Customer
{
    public string? Email { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    private List<Order> orders;

    public Customer(string email, string name, string address)
    {
        Email = email;
        Name = name;
        Address = address;
        orders = new List<Order>();
    }

    public override string ToString()
    {
        return $"Email: {Email} - Name: {Name} - Address: {Address}";
    }

    public Order AddOrder()
    {
        Order? currentOpenOrder = GetCurrentOpenOrder();
        if(currentOpenOrder != null)
        {
            currentOpenOrder.Status = OrderStatus.Cancelled;
        }
        Order neworder = new Order(GetNextOrderId());
        orders.Add(neworder);
        return neworder;
    }

    public Order? FindOrderById(int id)
    {
        foreach (Order order in orders)
        {
            if(order.ID == id)
            {
                return order;
            }
        }
        return null;
    }

    public void PrintOrders()
    {
        Console.WriteLine("".PadLeft(100,'='));
        Console.WriteLine($"Order for Customer: {Name}");
        foreach (Order order in orders)
        {
            order.Print();
        }
    }

    private int GetNextOrderId()
    {
        if(orders.Count == 0){
            return 1;
        }
        else
        {
            return orders.Last().ID + 1;
        }
    }

    public Order? GetCurrentOpenOrder()
    {
        foreach(Order order in orders)
        {
            if(order.Status == OrderStatus.Open)
            {
                return order;
            }
        }
        return null;
    }
}