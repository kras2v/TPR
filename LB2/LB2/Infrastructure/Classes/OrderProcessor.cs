using LB2.Infrastructure.Interfaces;

namespace LB2.Infrastructure.Classes;

internal class OrderProcessor : IOrderProcessor
{
    public void ProcessOrder(IOrder order)
    {
        order.Process();
    }
}