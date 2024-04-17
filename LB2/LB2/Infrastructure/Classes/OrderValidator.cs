using LB2.Infrastructure.Interfaces;

namespace LB2.Infrastructure.Classes;

internal class OrderValidator : IOrderValidator
{
    public void ValidateOrder(IOrder order)
    {
        order.Validate();
    }
}