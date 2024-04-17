using LB2.Infrastructure.Interfaces;

namespace LB2.Orders;

public class BookOrder : IOrder
{
    public void Process()
    {
        Console.WriteLine("Processing book order...");
    }

    public void Validate()
    {
        Console.WriteLine("Book order validated.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Confirmation email sent for book order.");
    }
}