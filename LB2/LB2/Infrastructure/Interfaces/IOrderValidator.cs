namespace LB2.Infrastructure.Interfaces;

internal interface IOrderValidator
{
    public void ValidateOrder(IOrder order);
}