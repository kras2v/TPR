using LB2.Infrastructure.Interfaces;

namespace LB2.Orders;

public class ElectronicOrder : IOrder
{
    public void Process()
    {
        Console.WriteLine("Processing electronic order...");
    }

    public void Validate()
    {
        Console.WriteLine("Electronic order validated.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Confirmation email sent for electronic order.");
    }
}