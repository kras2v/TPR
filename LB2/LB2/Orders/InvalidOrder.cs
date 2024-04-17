using LB2.Infrastructure.Interfaces;

namespace LB2.Orders;

internal class InvalidOrder : IOrder
{
    public void Process()
    {
        Console.WriteLine("Invalid order type!");
    }

    public void Validate()
    {
        Console.WriteLine("Invalid order type!");
    }

    public void SendEmail()
    {
        Console.WriteLine("Invalid order type!");
    }
}